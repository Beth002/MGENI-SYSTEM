using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GUEST_APK.Classes
{
    class Agents
    {
        string id_agent;
        string nom;
        string postnom;
        string prenom;
        string telephone;
        string adresse;
        string sexe;
        string fonction;
        string categorie;
        string departement;

        public string Id_agent
        {
            get
            {
                return id_agent;
            }

            set
            {
                id_agent = value;
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

        public string Fonction
        {
            get
            {
                return fonction;
            }

            set
            {
                fonction = value;
            }
        }

        public string Categorie
        {
            get
            {
                return categorie;
            }

            set
            {
                categorie = value;
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

        SqlConnection con;
        public int AjouterAgent(Agents agent)
        {
            int value = 0;
            con = new DataAccess().DBConnect();
            if (con != null)
            {
                string strquery = "exec Gestion_Agent null, @nom, @postnom, @prenom, @telephone, @adresse, @sexe, @fonction, @categorie, @departement 'INSERT'";
                SqlCommand cmd = new SqlCommand(strquery, con);

                SqlParameter prNom = new SqlParameter("@nom", agent.Nom);
                SqlParameter prPostnom = new SqlParameter("@postnom", agent.Postnom);
                SqlParameter prPrenom = new SqlParameter("@prenom", agent.Prenom);
                SqlParameter prTelephone = new SqlParameter("@telephone", agent.Telephone);
                SqlParameter prAdresse = new SqlParameter("@adresse", agent.Adresse);
                SqlParameter prSexe = new SqlParameter("@sexe", agent.Sexe);
                SqlParameter prFonction = new SqlParameter("@fonction", agent.Fonction);
                SqlParameter prCategorie = new SqlParameter("@categorie", agent.Categorie);
                SqlParameter prDepartement = new SqlParameter("@departement", agent.Departement);

                cmd.Parameters.Add(prNom);
                cmd.Parameters.Add(prPostnom);
                cmd.Parameters.Add(prPrenom);
                cmd.Parameters.Add(prTelephone);
                cmd.Parameters.Add(prAdresse);
                cmd.Parameters.Add(prSexe);
                cmd.Parameters.Add(prFonction);
                cmd.Parameters.Add(prCategorie);
                cmd.Parameters.Add(prDepartement);

                value = cmd.ExecuteNonQuery();

                return value;
            }

            else
            {
                return value;
            }
        }


        public List<Agents> getAgents()
        {
            //Definition de la liste des Agents
            List<Agents> list = new List<Agents>();

            //Pour lire les elements qu'il y a dans la table Agents : Liste de Agents
            con = new DataAccess().DBConnect();
            string strquery = "exec Gestion_Agent '','','','','','','','','','','SELECT'";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Agents agent = new Agents();
                agent.Id_agent = dr["Id_Agent"].ToString();
                agent.Nom = dr["Nom"].ToString();
                agent.Postnom = dr["Postnom"].ToString();
                agent.Prenom = dr["Prenom"].ToString();
                agent.Telephone = dr["Telephone"].ToString();
                agent.Adresse = dr["Adresse"].ToString();
                agent.Sexe = Convert.ToString(dr["Sexe"].ToString());
                agent.Fonction = dr["Fonction"].ToString();
                agent.Categorie = dr["Categorie"].ToString();
                agent.Departement = dr["Departement"].ToString();
                list.Add(agent);
            }
            return list;
        }
        public List<Agents> getAgentsCombo()
        {
            //Definition de la liste des Agents
            List<Agents> list = new List<Agents>();

            //Pour lire les elements qu'il y a dans la table Agents : Liste de Agents
            con = new DataAccess().DBConnect();
            string strquery = "select * from VV_AGENT";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Agents agent = new Agents();
                agent.Id_agent = dr["Id_Agent"].ToString();
                agent.Nom = dr["Nom"].ToString();
                list.Add(agent);
            }
            return list;
        }

        public List<Agents> getAgentsComboVisiter()
        {
            //Definition de la liste des Agents
            List<Agents> list = new List<Agents>();

            //Pour lire les elements qu'il y a dans la table Agents : Liste de Agents
            con = new DataAccess().DBConnect();
            string strquery = "select * from V_AGENT";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Agents agent = new Agents();
                agent.Id_agent = dr["Id_Agent"].ToString();
                agent.Nom = dr["Nom"].ToString();
                list.Add(agent);
            }
            return list;
        }

        public int ModifierAgent(Agents agent)
        {
            int value = 0;

            string strquery = "exec Gestion_Agent @id_agent, @nom, @postnom, @prenom, @telephone, @adresse, @sexe, @fonction, @categorie, @departement, 'UPDATE'";
            con = new DataAccess().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);

                SqlParameter prId = new SqlParameter("@id_visiteur", agent.Id_agent);
                SqlParameter prNom = new SqlParameter("@nom", agent.Nom);
                SqlParameter prPostnom = new SqlParameter("@postnom", agent.Postnom);
                SqlParameter prPrenom = new SqlParameter("@prenom", agent.Prenom);
                SqlParameter prTelephone = new SqlParameter("@telephone", agent.Telephone);
                SqlParameter prAdresse = new SqlParameter("@adresse", agent.Adresse);
                SqlParameter prSexe = new SqlParameter("@sexe", agent.Sexe);
                SqlParameter prFonction = new SqlParameter("@fonction", agent.Fonction);
                SqlParameter prCategorie = new SqlParameter("@categorie", agent.Categorie);
                SqlParameter prDepartement = new SqlParameter("@departement", agent.Departement);

                cmd.Parameters.Add(prId);
                cmd.Parameters.Add(prNom);
                cmd.Parameters.Add(prPostnom);
                cmd.Parameters.Add(prPrenom);
                cmd.Parameters.Add(prTelephone);
                cmd.Parameters.Add(prAdresse);
                cmd.Parameters.Add(prSexe);
                cmd.Parameters.Add(prFonction);
                cmd.Parameters.Add(prCategorie);
                cmd.Parameters.Add(prDepartement);
                value = cmd.ExecuteNonQuery();
            }
            return value;
        }

        public int SupprimerAgent(string code)
        {
            int value = 0;

            string strquery = "exec Gestion_Agent @id_agent, '', '', '', '', '', '', '', '', '', 'DELETE'";
            con = new DataAccess().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);

                SqlParameter prId = new SqlParameter("@id_agent", code);

                cmd.Parameters.Add(prId);
                value = cmd.ExecuteNonQuery();
            }
            return value;
        }

    }
}
