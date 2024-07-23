using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace GUEST_APK
{
    class DataAccess
    {
        SqlConnection con;
        public SqlConnection DBConnect()
        {
            try
            {
                //Connexion avec la base de données
                string strConnectionString = "Server = DESKTOP-F2S3F87; Database = DB_GESTION_VISITEUR; User Id = sa; Password = dddd;";
                con = new SqlConnection(strConnectionString);
                con.Open();

                return con;
            }

            catch (SqlException ex)
            {
                return null;
            }
        }
    }
}
