using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUEST_APK
{
    public partial class frmLogin : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        
        public frmLogin()
        {
            InitializeComponent();
            con.ConnectionString = string.Format("Server = DESKTOP-F2S3F87; Database = DB_GESTION_VISITEUR; User Id = sa; Password = dddd;");
        }

        //La Methode pour Fermer l'Application
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //La Methode pour actualiser les champs du LOGIN PAGE
        private void Actualiser()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        //La Methode pour cacher les caracteres saisis dans le champs du mot de passe
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = (char)0x25CF;
        }

        //Pour charger le combobox des utilisateurs
        public void ChargerComboUser()
        {
            cbUsername.DataSource = new Classes.Users().getUsers();
            cbUsername.DisplayMember = "Noms";
            cbUsername.ValueMember = "Id_User";
        }

        //Pour l'Authentification
        //public void Authentification()
        //{
        //    if (cbStatut.Text.Equals("Administrateur"))
        //    {
        //        frmGUEST guest = new frmGUEST();
        //        guest.btnControler.Visible = false;
        //    }
        //}

        //La methode pour se connecter dans l'application
        private void SeConnecter()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from T_User";
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                try
                {
                    if (txtPassword.Text.Equals(""))
                    {
                        MessageBox.Show("Veuillez remplir le Mot de passe !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (cbUsername.Text.Equals(dr["Noms"].ToString()) && txtPassword.Text.Equals(dr["Motdepasse"].ToString()) && cbStatut.Text.Equals(dr["Statut"].ToString()))
                        {
                            frmGUEST Guest = new frmGUEST();
                            frmLogin access = new frmLogin();
                            this.Hide();
                            Guest.Show();
                        }
                    else
                        {
                            MessageBox.Show("Nom d'utilisateur ou Mot de passe incorrect!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                catch (Exception ex)
                {
                    //MessageBox.Show("Nom d'utilisateur ou Mot de passe incorrect!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
        }
        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            //Appel de la methode de connexion
            SeConnecter();
            Actualiser();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ChargerComboUser();
        }
    }
}
