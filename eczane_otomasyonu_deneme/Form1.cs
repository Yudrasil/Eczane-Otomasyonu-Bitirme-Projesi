using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace eczane_otomasyonu_deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            beni_hatirlaDoldur();
        }

        private void beni_hatirlaDoldur()
        {
            if (Properties.Settings.Default.username != "")
            {
                if (Properties.Settings.Default.beni_hatirla == true)
                {
                    tb_username.Text = Properties.Settings.Default.username;
                    tb_userpassword.Text = Properties.Settings.Default.pass;
                    checkBox1.Checked = true;
                }
                else
                {
                    tb_username.Text = Properties.Settings.Default.username;
                    tb_userpassword.Text = Properties.Settings.Default.pass;
                }
            }
        }

        private void beni_hatirlaKaydet()
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.username = tb_username.Text;
                Properties.Settings.Default.pass = tb_userpassword.Text;
                Properties.Settings.Default.beni_hatirla = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.pass = "";
                Properties.Settings.Default.beni_hatirla = false;
                Properties.Settings.Default.Save();
            }
        }

        SqlConnection conn;
        database d = new database();




        private void button1_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_userpassword.Text;

            d.databaseOpen(conn);
            SqlCommand cmd = new SqlCommand("select PersonelKullaniciAdi , PersonelSifre from EczanePersonel where PersonelKullaniciAdi = @nick and PersonelSifre=@pass", conn);
            cmd.Parameters.AddWithValue("@nick", username);
            cmd.Parameters.AddWithValue("@pass", password);
            SqlDataReader son = cmd.ExecuteReader();
            if (son.Read())
            {
                Form2 f = new Form2();
                beni_hatirlaKaydet();
                Hide();
                f.ShowDialog();

            }
            else
            {
                MessageBox.Show("yok");
            }

            cmd = new SqlCommand("select PersonelEczaneID from EczanePersonel where PersonelKullaniciAdi=@nick and PersonelSifre=@pass", conn);
            cmd.Parameters.AddWithValue("@nick", username);
            cmd.Parameters.AddWithValue("@pass", password);

            son.Close();
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(d.databaseCreate());
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            Hide();
            f.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
