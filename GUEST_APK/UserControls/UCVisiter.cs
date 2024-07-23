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
using DevExpress.XtraReports.UI;
using GUEST_APK.RapportsEtatsDeSortie;

namespace GUEST_APK.UserControls
{
    public partial class UCVisiter : UserControl
    {
        string query;
        string ConnectionString = "Server = EL; Database = DB_GESTION_VISITEUR; User Id = sa; Password = dddd;";


        Formes.frmVisiter frmVisiter = new Formes.frmVisiter();
        Classes.Visiter visite = new Classes.Visiter();
        Classes.Agents agent = new Classes.Agents();

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
            ChargerCombo();
            cbAgent.Enabled = false;
            btnImprinerCarte.Enabled = false;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmVisiter.btnModifier.Visible = false;
            var forme = new Formes.frmVisiter();
            forme.ShowDialog();
            LoadList();
            btnImprinerCarte.Enabled = false;
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
            btnImprinerCarte.Enabled = false;
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            RapportVisite rapport = new RapportVisite();
            ReportPrintTool impression = new ReportPrintTool(rapport);
            rapport.ShowPreviewDialog();
        }
        
        public DataSet PrintCard(string Table)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            query = "SELECT * FROM V_VISITE WHERE Id_Visite ='" + lblGetId.Text + "'";
            cmd.CommandText = query;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, Table);
            }
            return ds;
        }

        private void btnImprinerCarte_Click(object sender, EventArgs e)
        {
            VisitCard Card = new VisitCard();
            Card.DataSource = PrintCard("V_VISITE");
            using (ReportPrintTool print = new ReportPrintTool(Card))
            {
                print.ShowPreviewDialog();
            }
        }

        private void dgVisiter_Click(object sender, EventArgs e)
        {

        }

        public DataSet PrintByDate(string Table)
        {
            if (chkAgent.Checked == true)
            {
                SqlCommand cmd = new SqlCommand();
                DataSet ds = new DataSet();
                //query = "SELECT * FROM V_VISITE WHERE DATE_HEURE = '" + DateDebut.Value.ToString("yyyy-MM-dd") + "' AND  '" + cbAgent.SelectedValue + "'";
                query = "SELECT * FROM V_VISITE WHERE DATE_HEURE BETWEEN '" + DateDebut.Value.ToString("yyyy-MM-dd") + "' AND '" + DateFin.Value.ToString("yyyy-MM-dd") + "' AND AGENT = '" + cbAgent.SelectedValue + "'";
                cmd.CommandText = query;
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    cmd.Connection = con;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds, Table);
                }
                return ds;
            }
            else if (chkAgent.Checked == false)
            {
                SqlCommand cmd = new SqlCommand();
                DataSet ds = new DataSet();
                query = "SELECT * FROM V_VISITE WHERE DATE_HEURE BETWEEN '" + DateDebut.Value.ToString("yyyy-MM-dd") + "' AND '" + DateFin.Value.ToString("yyyy-MM-dd") + "'";
                cmd.CommandText = query;
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    cmd.Connection = con;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds, Table);
                }
                return ds;
            }
            return ds;
        }

        public void CheckAgent()
        {
            if (chkAgent.Checked)
            {
                cbAgent.Enabled = true;
            }
            else
            {
                cbAgent.Enabled = false;
            }
        }
        private void btnRapportDateAgent_Click(object sender, EventArgs e)
        {
            RapportVisite RapByDate = new RapportVisite();
            RapByDate.DataSource = PrintByDate("V_VISITE");
            using (ReportPrintTool print = new ReportPrintTool(RapByDate))
            {
                print.ShowPreviewDialog();
            }
        }

        public void ChargerCombo()
        {
            cbAgent.DataSource = new Classes.Agents().getAgentsComboVisiter();
            cbAgent.DisplayMember = "Nom";
            cbAgent.ValueMember = "Nom";
        }

        private void chkAgent_CheckedChanged(object sender, EventArgs e)
        {
            CheckAgent();
        }
    }
}
