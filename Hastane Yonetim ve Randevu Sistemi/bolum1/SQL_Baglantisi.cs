using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace bolum1
{
    class SQL_Baglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=RABIA-AYDEMIR;Initial Catalog=HastaneYonetimVeRandevuSistemi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
