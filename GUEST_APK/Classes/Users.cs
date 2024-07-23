using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GUEST_APK.Classes
{
    class Users
    {
        int id_user;
        string noms;
        string motdepasse;
        string statut;

        public int Id_user
        {
            get
            {
                return id_user;
            }

            set
            {
                id_user = value;
            }
        }

        public string Noms
        {
            get
            {
                return noms;
            }

            set
            {
                noms = value;
            }
        }

        public string Motdepasse
        {
            get
            {
                return motdepasse;
            }

            set
            {
                motdepasse = value;
            }
        }

        public string Statut
        {
            get
            {
                return statut;
            }

            set
            {
                statut = value;
            }
        }

        SqlConnection con;

        public List<Users> getUsers()
        {

            //Definition de la liste utilisateurs
            List<Users> list = new List<Users>();

            //Pour lire les elements qu'il y a dans la table user : Liste d'utilisateurs
            con = new DataAccess().DBConnect();
            string strquery = "SELECT * FROM T_USER";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Users user = new Users();
                user.Id_user = Convert.ToInt32(dr["Id_User"].ToString());
                user.Noms = dr["Noms"].ToString();
                user.Motdepasse = dr["Motdepasse"].ToString();
                user.Statut = dr["Statut"].ToString();
                list.Add(user);
            }
            return list;
        }
    }
}
