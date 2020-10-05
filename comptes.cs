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
    public partial class comptes : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        SqlConnection connection = new SqlConnection(connectionString);
        public string login;
        public string mdp;
        Form1 form;
        string compteId = "none";

        public comptes()
        {
            InitializeComponent();
        }

        private void comptes_Load(object sender, EventArgs e)
        {
           
            connection.Open();

            
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
                solde.Text= dr2["montant"].ToString() + " MAD";
                compteN.Text= dr2["compte_num"].ToString();

            }
         
            connection.Close();
            
        }



        private void panel_histo_Paint(object sender, PaintEventArgs e)
        {
            AddDynamicLabels();
        }

        private void AddDynamicLabels()
        {
            int d = 1;
            //string Virement = "v";
            string facture = "Facture";

            connection.Open();
            SqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from [operation] where compte_id = '" + compteId + "' order by Id desc";
            SqlDataReader reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                if (string.Compare(facture, reader["operation_type"].ToString()) == 0)
                {
                    Label lbl = new Label();

                    lbl.Text = DateTime.Parse(reader["operation_date"].ToString()).ToString("dd/MM/yy") + ":              Paiement  " + reader["libelle"].ToString()
                            + "\r\n                                                                                                                                                 "
                            +"-"+ reader["montant"].ToString();
                    lbl.BackColor = System.Drawing.Color.DarkGray;
                    lbl.ForeColor = System.Drawing.Color.DarkRed;
                    lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lbl.BorderStyle = BorderStyle.Fixed3D;
                    

                    lbl.Size = new System.Drawing.Size(600, 40);
                    lbl.Top = d * 40; d++;
                    lbl.Left = 45;

                    panel_histo.Controls.Add(lbl);
                }
                else {
                    Label lbl = new Label();
                    lbl.Text = DateTime.Parse(reader["operation_date"].ToString()).ToString("dd/MM/yy") + ":              Emis en faveur de " + reader["libelle"].ToString()
                        + "\r\n                                                                                                                                                 "
                        +"-"+ reader["montant"].ToString();

                    lbl.BackColor = System.Drawing.Color.LightGray;
                    lbl.ForeColor = System.Drawing.Color.DarkRed;
                    lbl.BorderStyle = BorderStyle.Fixed3D;
                    lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    lbl.Size = new System.Drawing.Size(600, 35);
                    lbl.Top = d * 40; d++;
                    lbl.Left = 45;
                    //lbl.Margin = new Padding(1000);

                    panel_histo.Controls.Add(lbl);
                }

            }

            connection.Close();
        }

        private void panel_principal_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
