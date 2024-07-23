using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GUEST_APK.RapportsEtatsDeSortie;
using DevExpress.XtraReports.UI;
//using DevExpress.XtraReports.UI;


namespace GUEST_APK
{
    public partial class UCVisiteurs : UserControl
    {
        Visiteurs visiteur = new Visiteurs();
        frmAjout frmAjouter = new frmAjout();

        string code;
        public UCVisiteurs()
        {
            InitializeComponent();
        }

        public void LoadList()
        {
            try
            {
                //Charger DataGrid
                dgVisiteurs.DataSource = visiteur.getVisiteurs();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de chargement", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        SqlConnection con;
        //Permettent la recherche dans la DataGrid
        SqlDataAdapter datatable = null;
        SqlDataReader dr = null;
        DataSet ds = null;

        //Pour rechercher un Visiteur
        public DataTable Searching(string search)
        {
            SqlCommand cmd;
            con = new DataAccess().DBConnect();
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            cmd = new SqlCommand("select * from visiteur where nom like '%" + search + "%'", con);
            datatable = null;
            datatable = new SqlDataAdapter(cmd);
            ds = new DataSet();
            datatable.Fill(ds);
            con.Close();

            return ds.Tables[0];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void UCVisiteurs_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            var forme = new frmAjout();
            frmAjouter.lblMENU.Text = "ENREGISTREMENT";
            forme.ShowDialog();
            frmAjouter.btnModifier.Visible = false;
            LoadList();
        }

        private void Searching_TextChanged(object sender, EventArgs e)
        {
            dgVisiteurs.DataSource= Searching(txtSearch.Text);
        }

        public void Chargement_DataGrid()
        {
            if (dgVisiteurs.RowCount > 0)
            {
                frmAjouter.txtId.Text = dgVisiteurs["id_visiteur", dgVisiteurs.CurrentRow.Index].Value.ToString();
                frmAjouter.txtNom.Text = dgVisiteurs["Nom", dgVisiteurs.CurrentRow.Index].Value.ToString();
                frmAjouter.txtPostnom.Text = dgVisiteurs["Postnom", dgVisiteurs.CurrentRow.Index].Value.ToString();
                frmAjouter.txtPrenom.Text = dgVisiteurs["Prenom", dgVisiteurs.CurrentRow.Index].Value.ToString();
                frmAjouter.txtTelephone.Text = dgVisiteurs["Telephone", dgVisiteurs.CurrentRow.Index].Value.ToString();
                frmAjouter.txtAdresse.Text = dgVisiteurs["Adresse", dgVisiteurs.CurrentRow.Index].Value.ToString();
                frmAjouter.cbSexe.Text = dgVisiteurs["Sexe", dgVisiteurs.CurrentRow.Index].Value.ToString();

                //Enlever l'action du Bouton Ajouter dans le formulaire d'ajout quand on veut modifier
                //frmAjouter.btnAjouter.Visible = false;
            }
        }

        private void dgVisiteurs_DoubleClick(object sender, EventArgs e)
        {
            Chargement_DataGrid();
            frmAjouter.ShowDialog();
            frmAjouter.lblMENU.Text = "MODIFICATION";
            LoadList();
        }

        private void dgVisiteurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if(e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    visiteur.Id_Visiteur = (dgVisiteurs["id_visiteur", dgVisiteurs.CurrentRow.Index].Value.ToString());
                    visiteur.SupprimerVisiteur(code = visiteur.Id_Visiteur);
                    LoadList();
                }
                else
                {
                    LoadList();
                }
            }
            else if (e.ColumnIndex == 0)
            {
                Chargement_DataGrid();
                frmAjouter.ShowDialog();
                frmAjouter.BindingClassUpdate();

                int value = visiteur.ModifierVisiteur(visiteur);
                if (value >= 1)
                {
                    MessageBox.Show("Visiteur modifié avec succès", "SUCCES!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadList();
                }
                else
                {
                    MessageBox.Show("Visiteur non modifié", "ECHEC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            RapportVisiteur rapport = new RapportVisiteur();
            ReportPrintTool impression = new ReportPrintTool(rapport);
            rapport.ShowPreviewDialog();
        }
    }
}
