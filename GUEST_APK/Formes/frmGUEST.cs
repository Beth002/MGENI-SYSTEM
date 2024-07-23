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
    public partial class frmGUEST : Form
    {
        Timer bg = new Timer();
        public frmGUEST()
        {
            InitializeComponent();
            panelCouleur.Height = btnHome.Height;
            panelCouleur.Top = btnHome.Top;
            bg.Tick += (s, e) => { lblHeure.Text = DateTime.Now.ToString(); };
            bg.Interval = 333;
            bg.Start();
        }

        private void AppelUserControlVisiteur()
        {
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(new UCVisiteurs());
        }

        private void AppelUserControlContoler()
        {
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(new UserControls.UCControler());
        }

        private void AppelUserControlVisiter()
        {
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(new UserControls.UCVisiter());
        }
        private void AppelUserControlAccueil()
        {
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(new UserControls.UCAccueil());
        }
        private void btnVisiteur_Click(object sender, EventArgs e)
        {
            panelCouleur.Height = btnVisiteur.Height;
            panelCouleur.Top = btnVisiteur.Top;
            AppelUserControlVisiteur();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin access = new frmLogin();
            frmGUEST Guest = new frmGUEST();
            this.Hide();
            access.Show();
        }

        private void btnControler_Click(object sender, EventArgs e)
        {
            panelCouleur.Height = btnControler.Height;
            panelCouleur.Top = btnControler.Top;
            AppelUserControlContoler();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelCouleur.Height = btnHome.Height;
            panelCouleur.Top = btnHome.Top;
            AppelUserControlAccueil();
        }

        private void btnVisite_Click(object sender, EventArgs e)
        {
            panelCouleur.Height = btnVisite.Height;
            panelCouleur.Top = btnVisite.Top;
            AppelUserControlVisiter();
        }

        //private void Authentic()
        //{
        //    frmLogin login = new frmLogin();
        //    login.Authentification();
        //}

        private void frmGUEST_Load(object sender, EventArgs e)
        {
            AppelUserControlAccueil();
            //Authentic();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelCouleur.Height = btnDashboard.Height;
            panelCouleur.Top = btnDashboard.Top;
            AppelUserControlAccueil();
        }
    }
}
