using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace eczane_otomasyonu_deneme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<int> ilacID = new List<int>();
        List<string> ilacadiList = new List<string>();
        List<int> stoksayisi = new List<int>();
        database d = new database();
        SqlConnection conn;
        ilacsatisislemeleri sat = ilacsatisislemeleri.GetInstance();
        int receteID = -1;




        private void aramaYapGENEL(string tabloadi, string sutunadi, object aranan)
        {
            try
            {
                d.databaseOpen(conn);

                string sqlkod = string.Format("SELECT * FROM {0} WHERE {1} LIKE '%' + @aranan + '%'", tabloadi, sutunadi);

                SqlCommand cmd = new SqlCommand(sqlkod, conn);
                cmd.Parameters.AddWithValue("@aranan", aranan);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgv_Ilaclar.DataSource = dt;
                    reader.Close();
                }
                else
                {
                    dgv_Ilaclar.DataSource = null;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void ereceteDoldurma(int receteID)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.UrunRecete WHERE UrunReceteID = @receteid", conn);
            cmd.Parameters.AddWithValue("@receteid", receteID);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns[0].HeaderText = "Reçete Kodu";
                dataGridView1.Columns[1].HeaderText = "İlaç Kodu";


                foreach (DataRow row in dt.Rows)
                {
                    if (row["UrunReceteUrunID"] != DBNull.Value)
                    {
                        int number;
                        if (int.TryParse(row["UrunReceteUrunID"].ToString(), out number))
                        {
                            ilacID.Add(number);
                        }
                    }
                }
                ilaclariAktar(ilacID);
            }
            else if (!reader.HasRows && textBox5.Text.Length > 8)
            {
                MessageBox.Show("Bu Reçete Boş Girilmiştir!");
            }
            reader.Close();
        }

        private void ilaclariAktar(List<int> ilacID)
        {
            listBox1.Items.Clear();

            foreach (int item in ilacID)
            {
                StringBuilder sb = new StringBuilder();

                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Urunler WHERE UrunlerID = @item", conn);
                cmd.Parameters.AddWithValue("@item", item);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    sb.AppendLine(item.ToString() + " " + dr["UrunlerAd"].ToString());

                    ilacadiList.Add(dr["UrunlerAd"].ToString());
                }

                dr.Close();

                sat.satinalinacakilaclar(ilacID, ilacadiList, urunstoksayisi(ilacID));

                listBox1.Items.Add(sb.ToString());
            }
        }

        private List<int> urunstoksayisi(List<int> urunid)
        {
            d.databaseOpen(conn);



            SqlDataReader dr = null;

            try
            {
                foreach (var item in urunid)
                {
                    SqlCommand cmd = new SqlCommand("SELECT DepoyaGelenUrunlerAdet FROM dbo.DepoyaGelenUrunler WHERE DepoyaGelenUrunlerUrunID = @id", conn);
                    cmd.Parameters.AddWithValue("@id", item);

                    dr = cmd.ExecuteReader();
                    dr.Read();

                    while (dr.Read())
                    {
                        stoksayisi.Add(Convert.ToInt32(dr["DepoyaGelenUrunlerAdet"]));
                    }

                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                dr.Close();
            }

            return stoksayisi;
        }

        private void hastaArama(int receteID)
        {
            textBox6.Text = "";

            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Recete INNER JOIN dbo.Hasta ON dbo.Recete.ReceteHastaTcNo = dbo.Hasta.HastaTc WHERE dbo.Recete.ReceteID = @receteid", conn);
            cmd.Parameters.AddWithValue("@receteid", receteID);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Adı: " + reader["HastaAd"].ToString());
                sb.AppendLine("Soyadı: " + reader["HastaSoyad"].ToString());
                sb.AppendLine("Sigorta Türü: " + reader["HastaSigortaTuru"].ToString());
                sb.AppendLine("TC: " + reader["HastaTc"].ToString());

                sat.hastabilgileri(reader["HastaAd"].ToString(), reader["HastaSoyad"].ToString(), Convert.ToInt32(reader["HastaSigortaTuru"]), reader["HastaTc"].ToString());
                textBox6.Text = sb.ToString();
            }

            reader.Close();            
        }


        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f = new Form1();
            Dispose();
            f.ShowDialog();

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(d.databaseCreate());
            for (int i = 0; i < dgv_Ilaclar.Columns.Count; i++)
            {
                dgv_Ilaclar.Columns[i].Width = 180;
            }
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "İlaç Ekle";
            buttonColumn.Name = "Buton";
            buttonColumn.Text = "Sat";
            buttonColumn.UseColumnTextForButtonValue = true;
            dgv_Ilaclar.Columns.Add(buttonColumn);

            dgv_Ilaclar.CellContentClick += new DataGridViewCellEventHandler(dgv_ilaclar_CellContentClick);

        }

        private void dgv_ilaclar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_Ilaclar.Columns["Buton"].Index && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                var cellValue = dgv_Ilaclar.Rows[rowIndex].Cells[1].Value;

                if (cellValue != null) {

                    d.databaseOpen(conn);
                    SqlCommand cmd = new SqlCommand("select * from dbo.Urunler where UrunlerID = @cell ", conn);
                    cmd.Parameters.AddWithValue("@cell",cellValue );
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        ilacID.Add((int)reader[0]);
                    }
                    reader.Close();

                    ilaclariAktar(ilacID);
                    hastaArama(receteID);

                    sat.satinalinacakilaclar(ilacID,ilacadiList,stoksayisi);
                    listBox2.Items.Add(dgv_Ilaclar.Rows[rowIndex].Cells[2].Value);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            brkd brkd = new brkd();
            brkd.ShowDialog();
            textBox2.Text = brkd.barkod;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length > 1)
            {
                d.databaseOpen(conn);
                SqlCommand cmd = new SqlCommand("select * from dbo.Recete where ReceteElektronik like  + @erecete + '%' ", conn);
                cmd.Parameters.AddWithValue("@erecete", textBox5.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    receteID = (int)reader[0];
                }
                reader.Close();

                ereceteDoldurma(receteID);
                hastaArama(receteID);
            }
            if (textBox5.Text.Length < 1)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Update();
                listBox1.Items.Clear();
                textBox6.Text = "";
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 3)
            {
                aramaYapGENEL("Urunler", "UrunlerAd", textBox1.Text);
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length >= 3)
            {
                aramaYapGENEL("Urunler", "UrunlerATC_Adi", textBox3.Text);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length >= 3)
            {
                aramaYapGENEL("Urunler", "UrunlerBarkod", textBox2.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          satinalmaekrani satinalmaekrani = new satinalmaekrani();
            satinalmaekrani.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            satinalmaekrani satinalmaekrani = new satinalmaekrani();
            satinalmaekrani.Show();
            this.Hide();
        }
    }
}
