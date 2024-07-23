using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GUEST_APK.Classes
{
    class Controler
    {
        string id_controler;
        string visiteur;
        string agent;
        DateTime date_heure;

        public string Id_controler
        {
            get
            {
                return id_controler;
            }

            set
            {
                id_controler = value;
            }
        }

        public string Visiteur
        {
            get
            {
                return visiteur;
            }

            set
            {
                visiteur = value;
            }
        }

        public string Agent
        {
            get
            {
                return agent;
            }

            set
            {
                agent = value;
            }
        }

        public DateTime Date_heure
        {
            get
            {
                return date_heure;
            }

            set
            {
                date_heure = value;
            }
        }

        SqlConnection con;

        public int AjouterControle(Controler controle)
        {
            int value = 0;
            con = new DataAccess().DBConnect();
            if (con != null)
            {
                string strquery = "exec Gestion_Controler null, @Visiteur, @Agent, @Date_Heure,'INSERT'";
                SqlCommand cmd = new SqlCommand(strquery, con);
                
                SqlParameter prVisiteur = new SqlParameter("@Visiteur", controle.Visiteur);
                SqlParameter prAgent = new SqlParameter("@Agent", controle.Agent);
                SqlParameter prDateControle = new SqlParameter("@Date_Heure", controle.Date_heure);
                
                cmd.Parameters.Add(prVisiteur);
                cmd.Parameters.Add(prAgent);
                cmd.Parameters.Add(prDateControle);
                value = cmd.ExecuteNonQuery();

                return value;
            }

            else
            {
                return value;
            }
        }

        public List<Controler> getControle()
        {
            //Definition de la liste Controle
            List<Controler> list = new List<Controler>();

            //Pour lire les elements qu'il y a dans la table Controler : Liste de Controle
            con = new DataAccess().DBConnect();
            string strquery = "select * from V_CONTROLER ORDER BY DATE_HEURE ASC";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Controler controle = new Controler();
                controle.Id_controler = dr["Id_Controler"].ToString();
                controle.Visiteur = Convert.ToString(dr["Visiteur"].ToString());
                controle.Agent = Convert.ToString(dr["Agent"].ToString());
                controle.Date_heure = Convert.ToDateTime(dr["Date_Heure"].ToString());
                list.Add(controle);
            }
            return list;
        }

        public int ModifierControler(Controler controle)
        {
            int value = 0;

            string strquery = "exec Gestion_Controler @Id_Controler, @Visiteur, @Agent, @Date_heure, 'UPDATE'";
            con = new DataAccess().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);

                SqlParameter prId = new SqlParameter("@Id_Controler", controle.Id_controler);
                SqlParameter prVisiteur = new SqlParameter("@Visiteur", controle.Visiteur);
                SqlParameter prAgent = new SqlParameter("@Agent", controle.Agent);
                SqlParameter prDateControle = new SqlParameter("@Date_heure", controle.Date_heure);
                
                cmd.Parameters.Add(prId);
                cmd.Parameters.Add(prVisiteur);
                cmd.Parameters.Add(prAgent);
                cmd.Parameters.Add(prDateControle);
                value = cmd.ExecuteNonQuery();
            }
            return value;
        }

        public int SupprimerControler(string code)
        {
            int value = 0;

            string strquery = "exec Gestion_Controler @Id_Controler,'','','','DELETE'";
            con = new DataAccess().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);

                SqlParameter prId = new SqlParameter("@Id_Controler", code);

                cmd.Parameters.Add(prId);
                value = cmd.ExecuteNonQuery();
            }
            return value;
        }
    }
}
