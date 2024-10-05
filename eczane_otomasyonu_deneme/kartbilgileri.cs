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
    public partial class kartbilgileri : Form
    {
        public kartbilgileri()
        {
            InitializeComponent();
        }
        ilacsatisislemeleri sat = ilacsatisislemeleri.GetInstance();
        satinalmaekrani ekr = new satinalmaekrani();
        database d=new database();
        SqlConnection conn;
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            string kartNumarasi = txtKartNumarasi.Text;
            string kartSahibi = txtKartSahibi.Text;
            string sonKullanmaTarihi = txtSonKullanmaTarihi.Text;
            string cvv = txtCVV.Text;

            bool kont = sat.KartlaOdemeYap(kartNumarasi, kartSahibi, sonKullanmaTarihi, cvv);
            if (kont ==true)
            {
                this.Close();
            }
        }

        private void kartbilgileri_Load(object sender, EventArgs e)
        {
            conn= new SqlConnection(d.databaseCreate());
            SqlCommand com = new SqlCommand("insert into dbo.Hasta(HastaAd, HastaSoyad, HastaSigortaTuru, HastaTc, HastaBorcMiktari) values(@ad, @soyad, @sigorta, @tc, @borc)", conn);
            com.Parameters.AddWithValue("@ad", ekr.tb_isim.Text);
            com.Parameters.AddWithValue("@soyad", ekr.tb_soyisim.Text);
            com.Parameters.AddWithValue("@sigorta", ekr.tb_sigorta.Text);
            com.Parameters.AddWithValue("@tc", ekr.tb_tc.Text);
            d.databaseOpen(conn);
            try
            {
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            label2.Text = sat.Tutar.ToString();
        }
    }
}
