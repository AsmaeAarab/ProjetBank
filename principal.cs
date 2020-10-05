using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class principal : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        SqlConnection connection = new SqlConnection(connectionString);
        public string login;
        public string mdp;
        public principal()
        {
            InitializeComponent();
        }

        private void principal_Load(object sender, EventArgs e)
        {
            string compteId = "none";
            connection.Open();

            //
            SqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select compte_id from [authentification] where login = '" + login + "'";
            cmd1.ExecuteNonQuery();
            DataTable dta1 = new DataTable();
            SqlDataAdapter dataadp1 = new SqlDataAdapter(cmd1.CommandText, connection); ;
            dataadp1.Fill(dta1);
            foreach (DataRow dr1 in dta1.Rows)
            {
                compteId = dr1["compte_id"].ToString();
            }
            //Convert.ToInt32(compteId)

            string clientID = "none";
            SqlCommand cmd3 = connection.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select client_id from [compte] where Id = '" + compteId + "'";
            cmd3.ExecuteNonQuery();
            DataTable dta3 = new DataTable();
            SqlDataAdapter dataadp3 = new SqlDataAdapter(cmd3.CommandText, connection); 
            dataadp3.Fill(dta3);
            foreach (DataRow dr3 in dta3.Rows)
            {
                clientID = dr3["client_id"].ToString();
            }
            string Nom = " ";
            string Prenom = " ";
            string Tel = " ";
            string Civilite = " ";

            SqlCommand cmd4 = connection.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "select * from [client] where id = '" + clientID + "'";
            cmd4.ExecuteNonQuery();
            DataTable dta4 = new DataTable();
            SqlDataAdapter dataadp4 = new SqlDataAdapter(cmd4.CommandText, connection); ;
            dataadp4.Fill(dta4);
            foreach (DataRow dr4 in dta4.Rows)
            {
               Civilite= dr4["civilite"].ToString();
                Nom = dr4["nom_client"].ToString();
                Prenom = dr4["prenom_client"].ToString();
                Tel= dr4["num_tel"].ToString();


            }

            NomComplet.Text = Civilite + " " + Nom + " " + Prenom;
            lblTel.Text = Tel;
            lblName.Text= Civilite + " " + Nom + " " + Prenom;

            //MES COMPTES
            SqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from [compte] where id = '" + compteId + "'";
            cmd2.ExecuteNonQuery();
            DataTable dta2 = new DataTable();
            SqlDataAdapter dataadp2 = new SqlDataAdapter(cmd2.CommandText, connection); ;
            dataadp2.Fill(dta2);
            foreach (DataRow dr2 in dta2.Rows)
            {
                //compteId = dr2["ClientId"].ToString();
                lblSolde.Text = dr2["montant"].ToString() + " MAD";
                Ncompte.Text = dr2["compte_num"].ToString();

            }

            //AGENCE
            string agenceID = "none";
            SqlCommand cmd6 = connection.CreateCommand();
            cmd6.CommandType = CommandType.Text;
            cmd6.CommandText = "select agence_id from [compte] where id = '" + compteId + "'";
            cmd6.ExecuteNonQuery();
            DataTable dta6 = new DataTable();
            SqlDataAdapter dataadp6 = new SqlDataAdapter(cmd6.CommandText, connection); ;
            dataadp6.Fill(dta6);
            foreach (DataRow dr6 in dta6.Rows)
            {
                agenceID = dr6["agence_id"].ToString();
            }

            SqlCommand cmd5 = connection.CreateCommand();
            cmd5.CommandType = CommandType.Text;
            cmd5.CommandText = "select * from [agence] where Id = '" + agenceID + "'";
            cmd5.ExecuteNonQuery();
            DataTable dta5 = new DataTable();
            SqlDataAdapter dataadp5 = new SqlDataAdapter(cmd5.CommandText, connection); ;
            dataadp5.Fill(dta5);
            foreach (DataRow dr5 in dta5.Rows)
            {
             
                nom_agence.Text = dr5["nom_agence"].ToString();
                AdrAgence.Text= dr5["adresse_agence"].ToString();
                telAgence.Text=dr5["tel_agence"].ToString();

            }
            //ville Agence
            string IDville = "";
            SqlCommand cmd7 = connection.CreateCommand();
            cmd7.CommandType = CommandType.Text;
            cmd7.CommandText = "select ville_id from [agence] where Id = '" + agenceID + "'";
            cmd7.ExecuteNonQuery();
            DataTable dta7 = new DataTable();
            SqlDataAdapter dataadp7 = new SqlDataAdapter(cmd7.CommandText, connection); ;
            dataadp7.Fill(dta7);
            foreach (DataRow dr7 in dta7.Rows)
            {
                IDville = dr7["ville_id"].ToString();
            }

            SqlCommand cmd8 = connection.CreateCommand();
            cmd8.CommandType = CommandType.Text;
            cmd8.CommandText = "select * from [ville] where Id = '" + IDville + "'";
            cmd8.ExecuteNonQuery();
            DataTable dta8 = new DataTable();
            SqlDataAdapter dataadp8 = new SqlDataAdapter(cmd8.CommandText, connection); ;
            dataadp8.Fill(dta8);
            foreach (DataRow dr8 in dta8.Rows)
            {
               // villeAgence.Text =" - "+ dr8["label"].ToString();
            }




            connection.Close();



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
