using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

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

        ilacsatisislemeleri sat = ilacsatisislemeleri.GetInstance();
        database d = new database();
        SqlConnection conn;
        arduino ard = new arduino();
        decimal tutar;

        private void satinalmaekrani_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(d.databaseCreate());
            d.databaseOpen(conn);
            label_tutar.Text = sat.Tutar.ToString();
            if (!string.IsNullOrEmpty(sat.AliciTc))
            {
                tb_isim.Text = sat.AliciAdi;
                tb_soyisim.Text = sat.AliciSoyadi;
                tb_sigorta.Text = sat.AliciSigorta.ToString();
                tb_tc.Text = sat.AliciTc;

                textBox1.Text = sat.AliciAdi;
                textBox2.Text = sat.AliciSoyadi;
                textBox3.Text = sat.AliciSigorta.ToString();
                textBox4.Text = sat.AliciTc;
            }
            else
            {
                tb_isim.Text = "İsim Giriniz";
                tb_soyisim.Text = "Soyisim Giriniz";
                tb_tc.Text = "T.C. Giriniz";
                tb_sigorta.Text = "Sigorta Giriniz";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nakit Ödeme...", "Nakit", MessageBoxButtons.OK, MessageBoxIcon.None);
            MessageBox.Show("Ödeme Tamamlandı!");
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)//kart
        {
            if (!string.IsNullOrEmpty(tb_tc.Text))
            {
                kartbilgileri kartbilgileri = new kartbilgileri();
                kartbilgileri.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen İlk Önce Hasta Bilgilerini Giriniz!", "Hasta Bilgileri Eksik", MessageBoxButtons.OK);
            }
        }

        private void button4_Click(object sender, EventArgs e)//borç
        {
            sat.SatisYap(2);
        }

        private void satinalmaekrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 f = new Form2();
            this.Dispose();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Bilgileri Güncelle")
            {
                tb_isim.Text = "";
                tb_soyisim.Text = "";
                tb_sigorta.Text = "";
                tb_tc.Text = "";

                tb_isim.ReadOnly = false;
                tb_soyisim.ReadOnly = false;
                tb_sigorta.ReadOnly = false;
                tb_tc.ReadOnly = false;

                button2.Text = "Kaydet";
            }
            else if (button2.Text == "Kaydet")
            {
                conn = new SqlConnection(d.databaseCreate());
                SqlCommand com = new SqlCommand("insert into dbo.Hasta(HastaAd, HastaSoyad, HastaSigortaTuru, HastaTc, HastaBorcMiktari) values(@ad, @soyad, @sigorta, @tc, @borc)", conn);
                com.Parameters.AddWithValue("@ad", tb_isim.Text);
                com.Parameters.AddWithValue("@soyad", tb_soyisim.Text);
                com.Parameters.AddWithValue("@sigorta", tb_sigorta.Text);
                com.Parameters.AddWithValue("@tc", tb_tc.Text);
                com.Parameters.AddWithValue("@borc", 0);
                d.databaseOpen(conn);
                try
                {
                    com.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                sat.hastabilgileri(tb_isim.Text, tb_soyisim.Text, Convert.ToInt32(tb_sigorta.Text), tb_tc.Text);
                tb_isim.ReadOnly = true;
                tb_soyisim.ReadOnly = true;
                tb_sigorta.ReadOnly = true;
                tb_tc.ReadOnly = true;
                conn.Close();
                MessageBox.Show("Hasta Kayıt Edildi!");
                button2.Text = "Bilgileri Güncelle";

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(d.databaseCreate());
            SqlCommand com = new SqlCommand("UPDATE dbo.Hasta SET HastaBorcMiktari = 0 WHERE HastaTc = @tc;", conn);
            com.Parameters.AddWithValue("@tc", sat.AliciTc);
            d.databaseOpen(conn);
            try
            {
                com.ExecuteNonQuery();
                MessageBox.Show(sat.AliciTc +" T.C. numarasına sahip hastanın borcu SİLİNDİ!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
