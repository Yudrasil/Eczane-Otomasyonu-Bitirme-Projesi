using System;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Collections.Generic;

namespace eczane_otomasyonu_deneme
{
    internal class arduino
    {

        public void ledyak(int urunlerID)
        {
            SerialPort serialPort = new SerialPort();
            database d = new database();
            SqlConnection conn;
            string portname = "COM4";

            conn = new SqlConnection(d.databaseCreate());
            d.databaseOpen(conn);

            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = portname; 
                    serialPort.BaudRate = 9600;
                    serialPort.Open();
                }
                    string komut = "";

                    SqlCommand com = new SqlCommand("SELECT UrunlerSutun, UrunlerSatir FROM Urunler WHERE UrunlerID = @id", conn);
                    com.Parameters.AddWithValue("@id", urunlerID);

                    SqlDataReader reader = com.ExecuteReader();

                    if (reader.Read())
                    {
                        komut = reader["UrunlerSutun"].ToString() + reader["UrunlerSatir"].ToString();
                    }

                    reader.Close();

                    if (komut.Length >= 2 && char.IsLetter(komut[0]) && char.IsDigit(komut[1]))
                    {
                        System.Windows.Forms.MessageBox.Show(komut);
                        serialPort.WriteLine(komut);

                    }
                    else
                    {
                        serialPort.WriteLine("0");
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
            finally
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }
        }
    }
}