using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace eczane_otomasyonu_deneme
{
    internal class ilacsatisislemeleri
    {
        private static ilacsatisislemeleri instance = null;
        private static readonly object padlock = new object();

        private database d = new database();
        private SqlConnection conn;

        public string AliciAdi { get; private set; }
        public string AliciSoyadi { get; private set; }
        public int AliciSigorta { get; private set; }
        public string AliciTc { get; private set; }
        public List<int> IlacID { get; private set; } = new List<int>();
        public List<string> IlacAdi { get; private set; } = new List<string>();
        public List<int> IlacStokSayisi { get; private set; } = new List<int>();
        public decimal Tutar { get; private set; }

        private ilacsatisislemeleri() { }

        public static ilacsatisislemeleri GetInstance()
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new ilacsatisislemeleri();
                }
                return instance;
            }
        }

        public decimal ilacfiyatbul(List<int> ilacID)
        {
            conn = new SqlConnection(d.databaseCreate());
            d.databaseOpen(conn);
            Tutar = 0;

            foreach (var item in ilacID)
            {
                SqlCommand cmd = new SqlCommand("SELECT UrunlerFiyat FROM Urunler WHERE UrunlerID = @id", conn);
                cmd.Parameters.AddWithValue("@id", item);
                decimal fiyat = Convert.ToDecimal(cmd.ExecuteScalar());
                Tutar += fiyat;
            }
            return Tutar;
        }

        public void hastabilgileri(string aliciAdi, string aliciSoyadi, int aliciSigorta, string aliciTc)
        {
            AliciAdi = aliciAdi;
            AliciSoyadi = aliciSoyadi;
            AliciSigorta = aliciSigorta;
            AliciTc = aliciTc;
        }

        public void satinalinacakilaclar(List<int> ilacID, List<string> ilacAdi, List<int> ilacStokSayisi)
        {
            IlacID = ilacID;
            IlacAdi = ilacAdi;
            IlacStokSayisi = ilacStokSayisi;
            Tutar = ilacfiyatbul(ilacID);
        }
        public bool KartlaOdemeYap(string kartNumarasi, string kartSahibi, string sonKullanmaTarihi, string cvv)
        {
            try
            {
                if (kartNumarasi.Length != 16 || !kartNumarasi.All(char.IsDigit))
                {
                    MessageBox.Show("Geçersiz kart numarası.");
                    return false;
                }
                if (string.IsNullOrWhiteSpace(kartSahibi))
                {
                    MessageBox.Show("Kart sahibi adı boş olamaz.");
                    return false;
                }
                DateTime sonKullanma;
                if (!DateTime.TryParseExact(sonKullanmaTarihi, "MM/yy", null, System.Globalization.DateTimeStyles.None, out sonKullanma))
                {
                    MessageBox.Show("Geçersiz son kullanma tarihi.");
                    return false;
                }

                if (sonKullanma < DateTime.Now)
                {
                    MessageBox.Show("Kartın son kullanma tarihi geçmiş.");
                    return false;
                }
                if (cvv.Length < 3 || cvv.Length > 4 || !cvv.All(char.IsDigit))
                {
                    MessageBox.Show("Geçersiz CVV.");
                    return false;
                }

                MessageBox.Show("Ödeme başarıyla gerçekleştirildi.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ödeme işlemi sırasında bir hata oluştu: " + ex.Message);
                return false;
            }
        }



        public void SatisYap(int odemeyontemi)
        {
            if (odemeyontemi == 0) //Nakit Ödeme
            {
                // Nakit ödeme işlemleri
            }
            else if (odemeyontemi == 1) //Kartla Ödeme
            {
                //kart işlemlerine atar.
            }
            else if (odemeyontemi == 2)//borç alma
            {
                if (!string.IsNullOrEmpty(AliciTc))
                {
                    d.databaseOpen(conn);
                    string query = "UPDATE dbo.Hasta SET HastaBorcMiktari = HastaBorcMiktari + @tutar WHERE HastaTc = @tc";

                    SqlCommand com = new SqlCommand(query, conn);
                    com.Parameters.AddWithValue("@tutar", Tutar);
                    com.Parameters.AddWithValue("@tc", AliciTc);
                    try
                    {
                        com.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    MessageBox.Show("Borç Eklendi!");
                }
                else
                {
                    MessageBox.Show("Lütfen Hasta Kaydedin ya da E-Reçete Sistemini Kullanın!!!!","Geçersiz Hasta Satışı",MessageBoxButtons.OK);
                }
            }
        }

        public void bilgilerigoster()
        {
            MessageBox.Show(AliciAdi);
            MessageBox.Show(AliciSoyadi);
            MessageBox.Show(AliciSigorta.ToString());
            MessageBox.Show(AliciTc);
          /*  foreach (string s in IlacAdi)
            {
                MessageBox.Show(s);
            }
            foreach (var item in IlacID)
            {
                MessageBox.Show(item.ToString());
            }
            MessageBox.Show(IlacStokSayisi.Count.ToString());
            foreach (var item in IlacStokSayisi)
            {
                MessageBox.Show("Stok: " + item.ToString());
            }*/
        }
    }
}
