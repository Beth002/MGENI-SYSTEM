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
using GUEST_APK.Classes;

namespace GUEST_APK.Formes
{
    public partial class frmControler : Form
    {
        Classes.Controler controle = new Classes.Controler();
        Classes.Agents agent = new Classes.Agents();

        //Notre BindingClass pour Controler
        public void BindingClassAdd()
        {
            controle.Visiteur = Convert.ToString(cbVisiteur.SelectedValue);
            controle.Agent = Convert.ToString(cbAgent.SelectedValue);
            //controle.Date_heure = Convert.ToDateTime(DateControle.Text);
            controle.Date_heure = DateTime.Now;
        }

        //Notre BindingClass pour mise à jour du controle
        public void BindingClassUpdate()
        {
            controle.Id_controler = txtId.Text;
            controle.Visiteur = Convert.ToString(cbVisiteur.SelectedValue);
            controle.Agent = Convert.ToString(cbAgent.SelectedValue);
            controle.Date_heure = DateTime.Now;
        }

        public void Refresh()
        {
            txtId.Text = "";
        }
        public frmControler()
        {
            InitializeComponent();
        }

        public void ChargerCombo()
        {
            cbVisiteur.DataSource = new Visiteurs().getVisiteursCombo();
            cbVisiteur.DisplayMember = "Nom";
            cbVisiteur.ValueMember = "Id_Visiteur";

            cbAgent.DataSource = new Agents().getAgentsCombo();
            cbAgent.DisplayMember = "Nom";
            cbAgent.ValueMember = "Id_Agent";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //APPEL DU BINDING CLASS
            BindingClassAdd();
            Refresh();

                int value = controle.AjouterControle(controle);

                if (value >= 1)
                {
                    MessageBox.Show("Enregistrement Réussi", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Enregistrement Echoué", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
        }

        private void frmControler_Load(object sender, EventArgs e)
        {
            ChargerCombo();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            //APPEL DU BINDING CLASS
            BindingClassUpdate();
            Refresh();

            int value = controle.ModifierControler(controle);
            if (value >= 1)
            {
                MessageBox.Show("Contrôle modifié avec succès", "SUCCES!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Contrôle non modifié", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
