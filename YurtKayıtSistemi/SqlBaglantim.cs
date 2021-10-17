using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace YurtKayıtSistemi
{
    public class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-7K9A0NG\SQLEXPRESS;Initial Catalog=ÖğrenciKayıt;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
