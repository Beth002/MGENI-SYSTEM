using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUEST_APK.Classes;

namespace GUEST_APK.Formes
{
    public partial class frmVisiter : Form
    {
        Classes.Visiter visite = new Classes.Visiter();
        Classes.Agents agent = new Classes.Agents();

        //Notre BindingClass pour Visite
        public void BindingClassAdd()
        {
            visite.Visiteur = Convert.ToString(cbVisiteur.SelectedValue);
            visite.Agent = Convert.ToString(cbAgent.SelectedValue);
            visite.Badge = Convert.ToString(cbBadge.SelectedValue);
            visite.Date_heure = DateTime.Now;
            visite.Motif = Convert.ToString(cbMotif.SelectedItem);
        }

        //Notre BindingClass pour mise à jour de la Visite
        public void BindingClassUpdate()
        {
            visite.Id_visite = txtId.Text;
            visite.Visiteur = Convert.ToString(cbVisiteur.SelectedValue);
            visite.Agent = Convert.ToString(cbAgent.SelectedValue);
            visite.Badge = Convert.ToString(cbBadge.SelectedValue);
            visite.Date_heure = DateTime.Now;
            visite.Motif = Convert.ToString(cbMotif.SelectedItem);
        }

        public void Refresh()
        {
            txtId.Text = "";
        }
        public frmVisiter()
        {
            InitializeComponent();
        }

        public void ChargerCombo()
        {
            cbVisiteur.DataSource = new Visiteurs().getVisiteursComboControles();
            cbVisiteur.DisplayMember = "Nom";
            cbVisiteur.ValueMember = "Id_Visiteur";

            cbAgent.DataSource = new Agents().getAgentsComboVisiter();
            cbAgent.DisplayMember = "Nom";
            cbAgent.ValueMember = "Id_Agent";

            cbBadge.DataSource = new Badge().getBadge();
            cbBadge.DisplayMember = "Numero";
            cbBadge.ValueMember = "Id_Badge";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (cbMotif.Text.Equals(""))
            {
                MessageBox.Show("Veuillez indiquer le motif!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BindingClassAdd();
                Refresh();

                int value = visite.AjouterVisite(visite);

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

        private void frmVisiter_Load(object sender, EventArgs e)
        {
            ChargerCombo();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            //APPEL DU BINDING CLASS
            BindingClassUpdate();
            Refresh();

            int value = visite.ModifierVisite(visite);
            if (value >= 1)
            {
                MessageBox.Show("Visite modifiée avec succès", "SUCCES!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Visite non modifiée", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
