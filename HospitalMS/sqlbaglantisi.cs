using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace HospitalMs
{
    internal class Sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection bgl = new SqlConnection(@"Data Source= .; Initial Catalog=HastaneDB; Integrated Security = True;TrustServerCertificate = True");
            bgl.Open();
            return bgl;
        }
    }
}
