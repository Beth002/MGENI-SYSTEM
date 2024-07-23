using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUEST_APK
{
    public partial class frmAjout : Form
    {
        Visiteurs visiteurs = new Visiteurs();

        //Notre BindingClass pour Ajout des Visiteurs
        public void BindingClassAdd()
        {
            visiteurs.Nom = txtNom.Text;
            visiteurs.Postnom = txtPostnom.Text;
            visiteurs.Prenom = txtPrenom.Text;
            visiteurs.Telephone = txtTelephone.Text;
            visiteurs.Adresse = txtAdresse.Text;
            visiteurs.Sexe = Convert.ToString(cbSexe.SelectedItem);
        }

        //Notre BindingClass pour mise à jour des Visiteurs
        public void BindingClassUpdate()
        {
            visiteurs.Id_Visiteur = txtId.Text;
            visiteurs.Nom = txtNom.Text;
            visiteurs.Postnom = txtPostnom.Text;
            visiteurs.Prenom = txtPrenom.Text;
            visiteurs.Telephone = txtTelephone.Text;
            visiteurs.Adresse = txtAdresse.Text;
            visiteurs.Sexe = Convert.ToString(cbSexe.SelectedItem);
        }
        public void Refresh()
        {
            txtId.Text = "";
            txtNom.Text = "";
            txtPostnom.Text = "";
            txtPrenom.Text = "";
            txtTelephone.Text = "";
            txtAdresse.Text = "";
            cbSexe.Text = "";
        }

        public frmAjout()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            if (txtNom.Text.Equals("") || txtPostnom.Text.Equals("") || txtPrenom.Text.Equals("") || txtTelephone.Text.Equals("") || txtAdresse.Text.Equals("") || cbSexe.Text.Equals(""))
            {
                MessageBox.Show("Veuillez remplir les champs vides!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //APPEL DU BINDING CLASS
                BindingClassAdd();
                Refresh();

                int value = visiteurs.AjouterVisiteur(visiteurs);

                if (value >= 1)
                {
                    MessageBox.Show("Enregistrement Réussi", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Enregistrement Echoué", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            //APPEL DU BINDING CLASS
            BindingClassUpdate();
            Refresh();

            int value = visiteurs.ModifierVisiteur(visiteurs);
            if (value >= 1)
            {
                MessageBox.Show("Visiteur modifié avec succès", "SUCCES!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Visiteur non modifié", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
