using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eczane_otomasyonu_deneme
{
    public partial class satinalmaekrani : Form
    {
        public satinalmaekrani()
        {
            InitializeComponent();
        }
        //Fonksiyon



        //Fonskiyon son

        ilacsatisislemeleri sat =  ilacsatisislemeleri.GetInstance();

        database d = new database();
        SqlConnection conn;
        decimal tutar;

        private void satinalmaekrani_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(d.databaseCreate());
            d.databaseOpen(conn);
            label_isim.Text = sat.AliciAdi;
            label_soyisim.Text = sat.AliciSoyadi;
            label_tc.Text = sat.AliciTc;

            label_tutar.Text = sat.Tutar.ToString();
        }

        private void button3_Click(object sender, EventArgs e)//kart
        {

        }

        private void button4_Click(object sender, EventArgs e)//borç
        {
            d.databaseOpen(conn);
            tutar = sat.Tutar;
            MessageBox.Show(sat.AliciTc);
            string query = "UPDATE dbo.Hasta SET HastaBorcMiktari = HastaBorcMiktari + @tutar WHERE HastaTc = @tc";

            SqlCommand com = new SqlCommand(query, conn);
            com.Parameters.AddWithValue("@tutar", tutar);
            com.Parameters.AddWithValue("@tc", sat.AliciTc);

            com.ExecuteNonQuery();

            MessageBox.Show("Borç Eklendi!");

        }

        private void satinalmaekrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 f = new Form2();
            this.Dispose();
            f.Show();
        }
    }
}
