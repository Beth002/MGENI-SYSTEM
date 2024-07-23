using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GUEST_APK.Classes
{
    class Visiter
    {
        string id_visite;
        string visiteur;
        string motif;
        string badge;
        string agent;

        string fonction_agent;
        string departement;

        DateTime date_heure;

        //string query;
        //string ConnectionString = "Server = DESKTOP-F2S3F87; Database = DB_GESTION_VISITEUR; User Id = sa; Password = dddd;";

        public string Id_visite
        {
            get
            {
                return id_visite;
            }

            set
            {
                id_visite = value;
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

        public string Motif
        {
            get
            {
                return motif;
            }

            set
            {
                motif = value;
            }
        }

        public string Badge
        {
            get
            {
                return badge;
            }

            set
            {
                badge = value;
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

        public string Fonction_agent
        {
            get
            {
                return fonction_agent;
            }

            set
            {
                fonction_agent = value;
            }
        }

        public string Departement
        {
            get
            {
                return departement;
            }

            set
            {
                departement = value;
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

        public int AjouterVisite(Visiter visite)
        {
            int value = 0;
            con = new DataAccess().DBConnect();
            if (con != null)
            {
                string strquery = "exec Gestion_Visite null, @Visiteur, @Agent, @Badge, @Date_Heure, @Motif,'INSERT'";
                SqlCommand cmd = new SqlCommand(strquery, con);

                SqlParameter prVisiteur = new SqlParameter("@Visiteur", visite.Visiteur);
                SqlParameter prAgent = new SqlParameter("@Agent", visite.Agent);
                SqlParameter prBadge = new SqlParameter("@Badge", visite.Badge);
                SqlParameter prDateVisite = new SqlParameter("@Date_Heure", visite.Date_heure);
                SqlParameter prMotif = new SqlParameter("@Motif", visite.Motif);

                cmd.Parameters.Add(prVisiteur);
                cmd.Parameters.Add(prAgent);
                cmd.Parameters.Add(prBadge);
                cmd.Parameters.Add(prDateVisite);
                cmd.Parameters.Add(prMotif);
                value = cmd.ExecuteNonQuery();

                return value;
            }

            else
            {
                return value;
            }
        }

        public List<Visiter> getVisite()
        {
            //Definition de la liste Controle
            List<Visiter> list = new List<Visiter>();

            //Pour lire les elements qu'il y a dans la table Visiter : Liste des Visites
            con = new DataAccess().DBConnect();
            string strquery = "select * from V_VISITE ORDER BY DATE_HEURE ASC";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Visiter visite = new Visiter();
                visite.Id_visite = dr["Id_Visite"].ToString();
                visite.Visiteur = Convert.ToString(dr["Visiteur"].ToString());
                visite.Motif = Convert.ToString(dr["Motif"].ToString());
                visite.Badge = Convert.ToString(dr["Badge"].ToString());
                visite.Agent = Convert.ToString(dr["Agent"].ToString());
                visite.Fonction_agent = Convert.ToString(dr["fonction_agent"].ToString());
                visite.Departement = Convert.ToString(dr["departement"].ToString());
                visite.Date_heure = Convert.ToDateTime(dr["Date_Heure"].ToString());
                list.Add(visite);
            }
            return list;
        }

        public int ModifierVisite(Visiter visite)
        {
            int value = 0;

            string strquery = "exec Gestion_Visite @id_visite, @visiteur, @agent, @badge, @date_heure, @motif, 'UPDATE'";
            con = new DataAccess().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);

                SqlParameter prId = new SqlParameter("@id_visite", visite.Id_visite);
                SqlParameter prVisiteur = new SqlParameter("@visiteur", visite.Visiteur);
                SqlParameter prAgent = new SqlParameter("@agent", visite.Agent);
                SqlParameter prBadge = new SqlParameter("@badge", visite.Badge);
                SqlParameter prDate = new SqlParameter("@date_heure", visite.Date_heure);
                SqlParameter prMotif = new SqlParameter("@motif", visite.Motif);

                cmd.Parameters.Add(prId);
                cmd.Parameters.Add(prVisiteur);
                cmd.Parameters.Add(prAgent);
                cmd.Parameters.Add(prBadge);
                cmd.Parameters.Add(prDate);
                cmd.Parameters.Add(prMotif);
                value = cmd.ExecuteNonQuery();
            }
            return value;
        }

        public int SupprimerVisite(string code)
        {
            int value = 0;

            string strquery = "exec Gestion_Visite @id_visite, '', '', '', '', '', 'DELETE'";
            con = new DataAccess().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);

                SqlParameter prId = new SqlParameter("@id_visite", code);

                cmd.Parameters.Add(prId);
                value = cmd.ExecuteNonQuery();
            }
            return value;
        }
        //public DataSet PrintCard(string Table)
        //{
        //    //con = new DataAccess().DBConnect();
        //    SqlCommand cmd = new SqlCommand();
        //    DataSet ds = new DataSet();
        //    query = "SELECT * FROM V_VISITE WHERE Id_Visite ='240DBE8E-6'";
        //    cmd.CommandText = query;
        //    //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    //da.Fill(ds, Table);
        //    using (SqlConnection con = new SqlConnection(ConnectionString))
        //    {
        //        con.Open();
        //        cmd.Connection = con;
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(ds, Table);
        //    }
        //    return ds;
        //}
    }
}
