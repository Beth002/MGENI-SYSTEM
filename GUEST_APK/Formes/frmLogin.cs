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
        Timer bg = new Timer();
        
        public frmLogin()
        {
            InitializeComponent();
            con.ConnectionString = string.Format("Server = EL; Database = DB_GESTION_VISITEUR; User Id = sa; Password = dddd;");
            bg.Tick += (s, e) => { lblHeure.Text = DateTime.Now.ToString(); };
            bg.Interval = 333;
            bg.Start();
        }

        //La Methode pour Fermer l'Application
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //La Methode pour actualiser les champs du LOGIN PAGE
        private void Actualiser()
        {
            txtUserN.Text = "";
            txtPassword.Text = "";
            cbStatut.Text = null;
        }

        //La Methode pour cacher les caracteres saisis dans le champs du mot de passe
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = (char)0x25CF;
        }

        //La methode pour se connecter dans l'application
        private void SeConnecter()
        {
            if (txtPassword.Text.Equals("") && txtUserN.Text.Equals(""))
            {
                MessageBox.Show("Veuillez remplir les champs vides !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txtUserN.Text.Equals(""))
            {
                MessageBox.Show("Veuillez saisir le nom d'utilisateur !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Veuillez saisir le mot de passe !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from T_User where Noms = '" + txtUserN.Text + "' and Motdepasse = '" + txtPassword.Text + "' and Statut = '" + cbStatut.SelectedItem + "'";

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    try
                    {
                        if (txtUserN.Text.Equals(dr["Noms"].ToString()) && txtPassword.Text.Equals(dr["Motdepasse"].ToString()) && cbStatut.Text.Equals(dr["Statut"].ToString()))
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
        }
        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            //Appel de la methode de connexion
            SeConnecter();
            Actualiser();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cbStatut.SelectedItem = "Utilisateur";
        }
    }
}
