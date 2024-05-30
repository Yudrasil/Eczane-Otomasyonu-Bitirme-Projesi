using System;
using System.Data;
using System.Data.SqlClient;

namespace eczane_otomasyonu_deneme
{
    internal class database
    {
        public String databaseCreate()
        {
            string database_name = "EczaneOtomasyonuVeArduinoAraciligiylaStokTakip";
            string connect = "Data Source=.; Initial Catalog=" + database_name + "; Integrated Security=true";
            return connect;
        }
        public void databaseOpen(SqlConnection sql)
        {
            if (sql.State != ConnectionState.Open)
            {
                sql.Open();
            }
        }
    }
}