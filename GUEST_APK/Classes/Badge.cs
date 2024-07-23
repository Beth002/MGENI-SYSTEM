using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GUEST_APK.Classes
{
    class Badge
    {
        string id_badge;
        string numero;

        public string Id_badge
        {
            get
            {
                return id_badge;
            }

            set
            {
                id_badge = value;
            }
        }

        public string Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        SqlConnection con;
        public int AjouterBadge(Badge badge)
        {
            int value = 0;
            con = new DataAccess().DBConnect();
            if (con != null)
            {
                string strquery = "exec Gestion_Badge null, @numero, 'INSERT'";
                SqlCommand cmd = new SqlCommand(strquery, con);

                SqlParameter prNumero = new SqlParameter("@numero", badge.Numero);

                cmd.Parameters.Add(prNumero);

                value = cmd.ExecuteNonQuery();

                return value;
            }

            else
            {
                return value;
            }
        }

        public List<Badge> getBadge()
        {
            //Definition de la liste des Badge
            List<Badge> list = new List<Badge>();

            //Pour lire les elements qu'il y a dans la table badge : Liste de badges
            con = new DataAccess().DBConnect();
            string strquery = "exec Gestion_Badge '','','SELECT'";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Badge badge = new Badge();
                badge.Id_badge = dr["Id_Badge"].ToString();
                badge.Numero = dr["Numero"].ToString();
                list.Add(badge);
            }
            return list;
        }

        public int ModifierBadge(Badge badge)
        {
            int value = 0;

            string strquery = "exec Gestion_Badge @Id_Badge, @Numero, 'UPDATE'";
            con = new DataAccess().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);

                SqlParameter prId = new SqlParameter("@Id_Badge", badge.Id_badge);
                SqlParameter prNumero = new SqlParameter("@Numero", badge.Numero);

                cmd.Parameters.Add(prId);
                cmd.Parameters.Add(prNumero);
                value = cmd.ExecuteNonQuery();
            }
            return value;
        }

        public int SupprimerBadge(string code)
        {
            int value = 0;

            string strquery = "exec Gestion_Badge @Id_Badge, '', 'DELETE'";
            con = new DataAccess().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);

                SqlParameter prId = new SqlParameter("@Id_Badge", code);

                cmd.Parameters.Add(prId);
                value = cmd.ExecuteNonQuery();
            }
            return value;
        }
    }
}
