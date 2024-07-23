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
    public partial class UCAccueil : UserControl
    {
        SqlConnection con;
        public UCAccueil()
        {
            InitializeComponent();
            graphiqueEpargne();
            graphiqueAgent();
            vusLabel();
        }

        private void graphiqueEpargne()
        {
            con = new DataAccess().DBConnect();
            if (con != null)
            {
               con = new DataAccess().DBConnect();
               string query = "select top 5 count(*)as Flux, AGENT.Prenom+' '+AGENT.Postnom as Noms from VISITE inner join AGENT on VISITE.Agent = AGENT.Id_Agent group by AGENT.Prenom+' '+AGENT.Postnom";
               SqlCommand cmd = new SqlCommand(query, con);
               SqlDataReader reader = cmd.ExecuteReader();
               while (reader.Read())
                {
                    chartAgent.Series["Series1"].Points.AddXY(reader["Noms"], reader["Flux"]);

                }
            }
            
        }

        private void graphiqueAgent()
        {
            con = new DataAccess().DBConnect();
            if (con != null)
            {
                con = new DataAccess().DBConnect();
                string query = "select top 5 count(*)as Flux, AGENT.Prenom+' '+AGENT.Postnom as Noms from VISITE inner join AGENT on VISITE.Agent = AGENT.Id_Agent group by AGENT.Prenom+' '+AGENT.Postnom";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chartFlux.Series["Series1"].Points.AddXY(reader["Noms"], reader["Flux"]);

                }
            }

        }

        private void vusLabel()
        {
            int value = 0;
            con = new DataAccess().DBConnect();
            if (con != null)
            {
                con = new DataAccess().DBConnect();
                string visiteur = "select count(*)from VISITEUR ";
                var cmd1 = new SqlCommand(visiteur, con);
                float n1 = float.Parse(cmd1.ExecuteScalar().ToString());
                lblVisiteur.Text = n1.ToString();

                string controle = "select count(*)from CONTROLER ";
                var cmd2 = new SqlCommand(controle, con);
                float n2 = float.Parse(cmd2.ExecuteScalar().ToString());
                lblcontrole.Text = n2.ToString();

                string visite = "select count(*)from VISITE ";
                var cmd3 = new SqlCommand(visite, con);
                float n3 = float.Parse(cmd3.ExecuteScalar().ToString());
                lblVisite.Text = n3.ToString();

                string agent = "select count(*)from AGENT ";
                var cmd4 = new SqlCommand(agent, con);
                float n4 = float.Parse(cmd4.ExecuteScalar().ToString());
                lblagent.Text = n4.ToString();

                value = cmd1.ExecuteNonQuery();
                value = cmd2.ExecuteNonQuery();
                value = cmd3.ExecuteNonQuery();
                value = cmd4.ExecuteNonQuery();
            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
