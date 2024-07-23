using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace GUEST_APK
{
    class Visiteurs
    {
        string id_visiteur;
        string nom;
        string postnom;
        string prenom;
        string telephone;
        string adresse;
        string sexe;

        public string Id_Visiteur
        {
            get
            {
                return id_visiteur;
            }

            set
            {
                id_visiteur = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Postnom
        {
            get
            {
                return postnom;
            }

            set
            {
                postnom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string Telephone
        {
            get
            {
                return telephone;
            }

            set
            {
                telephone = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string Sexe
        {
            get
            {
                return sexe;
            }

            set
            {
                sexe = value;
            }
        }

        SqlConnection con;
        public int AjouterVisiteur(Visiteurs visiteur)
        {
            int value = 0;
            con = new DataAccess().DBConnect();
            if (con != null)
            {
                string strquery = "exec Gestion_Visiteur null, @nom, @postnom, @prenom, @telephone, @adresse, @sexe, 'INSERT'";
                SqlCommand cmd = new SqlCommand(strquery, con);

                SqlParameter prNom = new SqlParameter("@nom", visiteur.Nom);
                SqlParameter prPostnom = new SqlParameter("@postnom", visiteur.Postnom);
                SqlParameter prPrenom = new SqlParameter("@prenom", visiteur.Prenom);
                SqlParameter prTelephone = new SqlParameter("@telephone", visiteur.Telephone);
                SqlParameter prAdresse = new SqlParameter("@adresse", visiteur.Adresse);
                SqlParameter prSexe = new SqlParameter("@sexe",visiteur.Sexe);
                
                cmd.Parameters.Add(prNom);
                cmd.Parameters.Add(prPostnom);
                cmd.Parameters.Add(prPrenom);
                cmd.Parameters.Add(prTelephone);
                cmd.Parameters.Add(prAdresse);
                cmd.Parameters.Add(prSexe);

                value = cmd.ExecuteNonQuery();

                return value;
            }

            else
            {
                return value;
            }
        }

        public List<Visiteurs> getVisiteurs()
        {
            //Definition de la liste des Visiteurs
            List<Visiteurs> list = new List<Visiteurs>();

            //Pour lire les elements qu'il y a dans la table Visiteur : Liste de Visiteurs
            con = new DataAccess().DBConnect();
            string strquery = "exec Gestion_Visiteur '','','','','','','','SELECT'";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Visiteurs visiteur = new Visiteurs();
                visiteur.Id_Visiteur = dr["Id_Visiteur"].ToString();
                visiteur.Nom = dr["Nom"].ToString();
                visiteur.Postnom = dr["Postnom"].ToString();
                visiteur.Prenom = dr["Prenom"].ToString();
                visiteur.Telephone = dr["Telephone"].ToString();
                visiteur.Adresse = dr["Adresse"].ToString();
                visiteur.Sexe = Convert.ToString(dr["Sexe"].ToString());
                list.Add(visiteur);
            }
            return list;
        }

        public List<Visiteurs> getVisiteursCombo()
        {
            //Definition de la liste des Visiteurs
            List<Visiteurs> list = new List<Visiteurs>();

            //Pour lire les elements qu'il y a dans la table Visiteur : Liste de Visiteurs
            con = new DataAccess().DBConnect();
            string strquery = "select * from VV_VISITEUR ORDER BY NOM ASC";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Visiteurs visiteur = new Visiteurs();
                visiteur.Id_Visiteur = dr["Id_Visiteur"].ToString();
                visiteur.Nom = dr["Nom"].ToString();
                list.Add(visiteur);
            }
            return list;
        }

        public List<Visiteurs> getVisiteursComboControles()
        {
            //Definition de la liste des Visiteurs
            List<Visiteurs> list = new List<Visiteurs>();

            //Pour lire les elements qu'il y a dans la table Visiteur : Liste de Visiteurs
            con = new DataAccess().DBConnect();
            string strquery = "SELECT * FROM VV_VISITEURS_CONTROLES ORDER BY Date_Heure ASC";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Visiteurs visiteur = new Visiteurs();
                visiteur.Id_Visiteur = dr["Id_Visiteur"].ToString();
                visiteur.Nom = dr["Nom"].ToString();
                list.Add(visiteur);
            }
            return list;
        }

        public int ModifierVisiteur(Visiteurs visiteur)
        {
            int value = 0;

            string strquery = "exec Gestion_Visiteur @id_visiteur, @nom, @postnom, @prenom, @telephone, @adresse, @sexe, 'UPDATE'";
            con = new DataAccess().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);

                SqlParameter prId = new SqlParameter("@id_visiteur", visiteur.Id_Visiteur);
                SqlParameter prNom = new SqlParameter("@nom", visiteur.Nom);
                SqlParameter prPostnom = new SqlParameter("@postnom", visiteur.Postnom);
                SqlParameter prPrenom = new SqlParameter("@prenom", visiteur.Prenom);
                SqlParameter prTelephone = new SqlParameter("@telephone", visiteur.Telephone);
                SqlParameter prAdresse = new SqlParameter("@adresse", visiteur.Adresse);
                SqlParameter prSexe = new SqlParameter("@sexe", visiteur.Sexe);

                cmd.Parameters.Add(prId);
                cmd.Parameters.Add(prNom);
                cmd.Parameters.Add(prPostnom);
                cmd.Parameters.Add(prPrenom);
                cmd.Parameters.Add(prTelephone);
                cmd.Parameters.Add(prAdresse);
                cmd.Parameters.Add(prSexe);
                value = cmd.ExecuteNonQuery();
            }
            return value;
        }

        public int SupprimerVisiteur(string code)
        {
            int value = 0;

            string strquery = "exec Gestion_Visiteur @id_visiteur, '', '', '', '', '', '', 'DELETE'";
            con = new DataAccess().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);

                SqlParameter prId = new SqlParameter("@id_visiteur", code);

                cmd.Parameters.Add(prId);
                value = cmd.ExecuteNonQuery();
            }
            return value;
        }
    }
}
