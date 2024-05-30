using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace eczane_otomasyonu_deneme
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        database d = new database();
        SqlConnection conn;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                if (textBox5.Text != "")
                {
                    if (textBox1.Text != "")
                    {
                        if (textBox2.Text != "")
                        {
                            if (textBox6.Text != "")
                            {
                                if (comboBox1.SelectedIndex != -1)
                                {
                                    if (textBox3.Text != "")
                                    {
                                        d.databaseOpen(conn);
                                        SqlCommand cmd = new SqlCommand("select PersonelKullaniciAdi,PersonelSifre, PersonelEczaneID from EczanePersonel where PersonelUnvan= @unvan", conn);
                                        cmd.Parameters.AddWithValue("@unvan", "Yönetici");

                                        SqlDataReader dr = cmd.ExecuteReader();
                                        dr.Read();
                                        string yetkilinick = dr["PersonelKullaniciAdi"].ToString();
                                        string yetkilisifre = dr["PersonelSifre"].ToString();
                                        dr.Close();
                                        if (yetkilisifre == textBox3.Text)
                                        {
                                            cmd = new SqlCommand("insert into EczanePersonel(PersonelAd,PersonelSoyad,PersonelUnvan,PersonelKullaniciAdi,PersonelSifre,PersonelIletisim,PersonelEczaneId) values(@pad,@psad,@punvan,@pnick,@ppass,@piletisim,@peczaneid )  ", conn);

                                            cmd.Parameters.AddWithValue("@pad", textBox4.Text);
                                            cmd.Parameters.AddWithValue("@psad", textBox5.Text);
                                            cmd.Parameters.AddWithValue("@punvan", comboBox1.SelectedItem.ToString());
                                            cmd.Parameters.AddWithValue("@pnick", textBox1.Text);
                                            cmd.Parameters.AddWithValue("@ppass", textBox2.Text);
                                            cmd.Parameters.AddWithValue("@piletisim", textBox6.Text);

                                            int sonuc = cmd.ExecuteNonQuery();
                                            if (sonuc == 1)
                                            {
                                                MessageBox.Show("Kayıt Başarılı!");
                                            }
                                            else
                                            {
                                                MessageBox.Show("Başarısız Kayıt!");
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("Yeni Personel Kayıt Edebilmek İçin Bir Yetkiliye İhtiyacınız Var.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Lütfen Eczacı Şifresini Giriniz!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Lütfen Çalışan Unvanını Giriniz!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Lütfen İletişim Numarasını Giriniz!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Şifrenizi Giriniz!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Kullanıcı Adını Giriniz!");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Soyad Giriniz!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Adınızı Giriniz!");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(d.databaseCreate());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            Dispose();
            f.ShowDialog();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 f = new Form2();
            Dispose();
            f.ShowDialog();
        }
    }
}
