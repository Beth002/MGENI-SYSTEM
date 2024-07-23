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
    public partial class UCControler : UserControl
    {
        Formes.frmControler frmControler = new Formes.frmControler();
        Classes.Controler controler = new Classes.Controler();

        string code;
        public UCControler()
        {
            InitializeComponent();
        }

        //public void ChargerComboVisiteur()
        //{
        //    frmControler.cbVisiteur.DataSource = new Visiteurs().getVisiteurs();
        //    frmControler.cbVisiteur.DisplayMember = "Nom";
        //    frmControler.cbVisiteur.ValueMember = "Id_Visiteur";
        //}
        public void LoadList()
        {
            try
            {
                //Charger DataGrid
                dgControler.DataSource = controler.getControle();

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
            cmd = new SqlCommand("select * from V_CONTROLER where visiteur like '%" + search + "%'", con);
            datatable = null;
            datatable = new SqlDataAdapter(cmd);
            ds = new DataSet();
            datatable.Fill(ds);
            con.Close();

            return ds.Tables[0];
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmControler.btnModifier.Visible = false;
            var forme = new Formes.frmControler();
            forme.ShowDialog();
            LoadList();
        }

        public void Chargement_DataGrid()
        {
            if (dgControler.RowCount > 0)
            {
                frmControler.txtId.Text = dgControler["Id_Controler", dgControler.CurrentRow.Index].Value.ToString();
                frmControler.cbVisiteur.Text = dgControler["Visiteur", dgControler.CurrentRow.Index].Value.ToString();
                frmControler.cbAgent.Text = dgControler["Agent", dgControler.CurrentRow.Index].Value.ToString();
                frmControler.DateControle.Text = dgControler["Date_Heure", dgControler.CurrentRow.Index].Value.ToString();

                //Enlever l'action du Bouton Ajouter dans le formulaire d'ajout quand on veut modifier
                frmControler.btnAjouter.Visible = false;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgControler.DataSource = Searching(txtSearch.Text);
        }

        private void dgControler_DoubleClick(object sender, EventArgs e)
        {
            Chargement_DataGrid();
            frmControler.ShowDialog();
            LoadList();
        }

        private void UCControler_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void dgControler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    controler.Id_controler = (dgControler["Id_Controler", dgControler.CurrentRow.Index].Value.ToString());
                    controler.SupprimerControler(code = controler.Id_controler);
                    LoadList();
                }
                else
                {
                    LoadList();
                }
            }
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            var impression = new Formes.RapportControle();
            impression.ShowDialog();
        }
    }
}
