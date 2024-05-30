using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public void SatisYap(int odemeyontemi)
        {
            if (odemeyontemi == 0) //Nakit Ödeme
            {
                // Nakit ödeme işlemleri
            }
            else if (odemeyontemi == 1) //Kartla Ödeme
            {
                // Kartla ödeme işlemleri
            }
            else if (odemeyontemi == 2)//borç alma
            {
                // Borç alma işlemleri
            }
        }

        public void bilgilerigoster()
        {
            MessageBox.Show(AliciAdi);
            MessageBox.Show(AliciSoyadi);
            MessageBox.Show(AliciTc);
            MessageBox.Show(AliciSigorta.ToString());
            foreach (string s in IlacAdi)
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
            }
        }
    }
}
