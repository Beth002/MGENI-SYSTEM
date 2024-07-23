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

namespace GUEST_APK.UserControls
{
    public partial class UCVisiter : UserControl
    {
        Formes.frmVisiter frmVisiter = new Formes.frmVisiter();
        Classes.Visiter visite = new Classes.Visiter();

        string code;
        public UCVisiter()
        {
            InitializeComponent();
        }

        public void LoadList()
        {
            try
            {
                //Charger DataGrid
                dgVisiter.DataSource = visite.getVisite();

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

        //Pour rechercher un controle
        public DataTable Searching(string search)
        {
            SqlCommand cmd;
            con = new DataAccess().DBConnect();
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            cmd = new SqlCommand("Select * from V_VISITE where visiteur like '%" + search + "%'", con);
            datatable = null;
            datatable = new SqlDataAdapter(cmd);
            ds = new DataSet();
            datatable.Fill(ds);
            con.Close();

            return ds.Tables[0];
        }

        private void UCVisiter_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmVisiter.btnModifier.Visible = false;
            var forme = new Formes.frmVisiter();
            forme.ShowDialog();
            LoadList();
        }

        public void Chargement_DataGrid()
        {
            if (dgVisiter.RowCount > 0)
            {
                frmVisiter.txtId.Text = dgVisiter["Id_Visite", dgVisiter.CurrentRow.Index].Value.ToString();
                frmVisiter.cbVisiteur.Text = dgVisiter["Visiteur", dgVisiter.CurrentRow.Index].Value.ToString();
                frmVisiter.cbAgent.Text = dgVisiter["Agent", dgVisiter.CurrentRow.Index].Value.ToString();
                frmVisiter.cbBadge.Text = dgVisiter["Badge", dgVisiter.CurrentRow.Index].Value.ToString();
                frmVisiter.DateVisite.Text = dgVisiter["Date_Heure", dgVisiter.CurrentRow.Index].Value.ToString();
                frmVisiter.cbMotif.Text = dgVisiter["Motif", dgVisiter.CurrentRow.Index].Value.ToString();

                //Enlever l'action du Bouton Ajouter dans le formulaire d'ajout quand on veut modifier
                frmVisiter.btnAjouter.Visible = false;
            }
        }

        private void dgVisiter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    visite.Id_visite = (dgVisiter["Id_Visite", dgVisiter.CurrentRow.Index].Value.ToString());
                    visite.SupprimerVisite(code = visite.Id_visite);
                    LoadList();
                }
                else
                {
                    LoadList();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgVisiter.DataSource = Searching(txtSearch.Text);
        }

        private void dgVisiter_DoubleClick(object sender, EventArgs e)
        {
            Chargement_DataGrid();
            frmVisiter.ShowDialog();
            LoadList();
        }
    }
}
