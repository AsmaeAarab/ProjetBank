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
using System.Text.RegularExpressions;
using System.Configuration;

namespace Projet
{
    public partial class virement : Form
    {
       // string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HPr\source\repos\Projet\Projet\Banque.mdf;Integrated Security=True";
        static string connectionString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        public string login;
        public string mdp;
        public int compte_id;
        public string compteNum;
        ErrMsg ErrMessage;
        private void compte_depart()
        {

            using (SqlConnection con1 = new SqlConnection(connectionString))
            {
                con1.Open();
                string compte_num = textBox1.Text;
                string sql = "select montant from compte where compte_num='" + compte_num + "'";
                SqlCommand cmd1 = new SqlCommand(sql, con1);
                SqlDataReader reader = cmd1.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        int soldeIndex = reader.GetOrdinal("montant");
                        int solde = 0;
                        if (reader[soldeIndex] != DBNull.Value)
                            solde = reader.GetInt32(soldeIndex);

                        int decouvert = (solde / 3);
                        textBox5.Text = decouvert.ToString();
                        textBox5.Enabled = false;
                    }

                }

                reader.Close();
            }
    }

        private bool IsValidate()
        {

            int destinataire;
            bool isNumeric = int.TryParse(textBox3.Text.Trim(), out destinataire);

            if (!isNumeric)

            {
                ErrMessage.Errmsg = "Le montant ne doit contenir que des nombres";
                ErrMessage.ShowDialog();
                textBox3.Clear();
                textBox3.Focus();

         
                return false;
            }
            return true;
        }

        public virement()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(connectionString))
            {
                con1.Open();


                SqlCommand cmd1 = con1.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select compte_num from [compte] where id = '" + compte_id + "'";
                cmd1.ExecuteNonQuery();
                DataTable dta1 = new DataTable();
                SqlDataAdapter dataadp1 = new SqlDataAdapter(cmd1.CommandText, con1); ;
                dataadp1.Fill(dta1);
                foreach (DataRow dr1 in dta1.Rows)
                {
                    compteNum = dr1["compte_num"].ToString();
                }
            }
            textBox1.Text = compteNum;
            textBox1.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            compte_depart();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            ErrMessage = new ErrMsg();

            if (string.IsNullOrEmpty(textBox2.Text))
            {
               
                ErrMessage.Errmsg = "Le champ compte d arrive est obligatoire!!";
                ErrMessage.ShowDialog(); 
                textBox2.Focus();
                
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                ErrMessage.Errmsg = "Le champ montant est obligatoire!!";
                ErrMessage.ShowDialog();
                textBox3.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                ErrMessage.Errmsg = "Le champ motif est obligatoire!!";
                ErrMessage.ShowDialog();
                textBox4.Focus();
                
                return;
            }
          
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                ErrMessage.Errmsg = "Le champ de votre numero de compte est \n obligatoire!!";
                ErrMessage.ShowDialog();
                textBox1.Focus();
                return;
            }
            if (dateTimePicker1.Value < DateTime.Today)
            {
                ErrMessage.Errmsg = "La date d'émission ne peut pas être \n inférieure à la date du jour!!!";
                ErrMessage.ShowDialog(); 
                dateTimePicker1.Focus();
                return;
            }

            if (string.Equals(textBox1.Text, textBox2.Text))
            {
                ErrMessage.Errmsg = "Les numéros de l'émetteur et du destinataire\ndoivent être différents!!!";
                ErrMessage.ShowDialog();
                textBox2.Clear();
                textBox2.Focus();
                return;
            }
            try
            {
                Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                ErrMessage.Errmsg = "Le champ destinataire ne doit contenir que des nombres!";
                ErrMessage.ShowDialog();
                textBox2.Clear();
                textBox2.Focus();

            }
           
         
            if (IsValidate()) { 
                if (double.Parse(textBox5.Text) <= double.Parse(textBox3.Text))
            {
                ErrMessage.Errmsg = "le montant de transfert ne doit pas etre superieur  \n au decouvert maximum";
                ErrMessage.ShowDialog();
                    return;
            }
            else
            {
                using (SqlConnection con7 = new SqlConnection(connectionString))
                {
                    con7.Open();
                    string CD = textBox1.Text;
                    string sql7 = "SELECT Id FROM compte where compte_num = '" + CD + "'";
                    SqlCommand cmd7 = new SqlCommand(sql7, con7);
                    SqlDataReader reader7 = cmd7.ExecuteReader();

                    if (reader7.HasRows)
                    {
                        while (reader7.Read())
                        {
                            int compte_identifiantIndex = reader7.GetOrdinal("Id");
                            int compte_identifiant = 0;

                            if (reader7[compte_identifiantIndex] != DBNull.Value)
                                compte_identifiant = reader7.GetInt32(compte_identifiantIndex);

                            using (SqlConnection con8 = new SqlConnection(connectionString))
                            {
                                con8.Open();
                                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                                dateTimePicker1.CustomFormat = "MM-dd-yyyy";
                                string sql8 = "SELECT SUM(montant) AS Monmontant FROM operation where compte_id  = '" + compte_identifiant + "' AND operation_date= '" + dateTimePicker1.Text + "'  ";

                                SqlCommand cmd8 = new SqlCommand(sql8, con8);

                                SqlDataReader reader8 = cmd8.ExecuteReader();
                                if (reader8.HasRows)
                                {
                                    while (reader8.Read())
                                    {

                                        int MonmontantIndex = reader8.GetOrdinal("Monmontant");
                                        int Monmontant = 0;
                                        int montantTotal;
                                        int montantAtr = Int32.Parse(textBox3.Text);
                                        if (reader8[MonmontantIndex] != DBNull.Value)
                                            Monmontant = reader8.GetInt32(MonmontantIndex);
                                        montantTotal = Monmontant + montantAtr;


                                        if (15000 <= montantTotal)
                                        {
                                                ErrMessage.Errmsg = "le montant de transfert ne doit pas etre superieur \n au débit maximum autorisé quotidien\n(15000)";
                                                ErrMessage.ShowDialog();
                                                break;
                                        }
                                        else
                                        {
                                            using (SqlConnection con1 = new SqlConnection(connectionString))
                                            {
                                                con1.Open();
                                                string CA = textBox2.Text;


                                                string sql1 = "select montant from compte where compte_num  = '" + CA + "'";
                                                SqlCommand cmd1 = new SqlCommand(sql1, con1);
                                                SqlDataReader reader = cmd1.ExecuteReader();

                                                if (reader.HasRows)
                                                {


                                                    while (reader.Read())
                                                    {
                                                        int soldeIndex = reader.GetOrdinal("montant");
                                                        int solde = 0;

                                                        if (reader[soldeIndex] != DBNull.Value)
                                                            solde = reader.GetInt32(soldeIndex);

                                                        int soldeNV = solde + Convert.ToInt16(textBox3.Text);


                                                        using (SqlConnection con2 = new SqlConnection(connectionString))
                                                        {
                                                            con2.Open();
                                                            //string mdp = textBox6.Text;
                                                            string sql2 = "select montant from compte,authentification where compte_num= '" + CD + "' AND compte.id=authentification.compte_id ";

                                                            SqlCommand cmd2 = new SqlCommand(sql2, con2);
                                                            SqlDataReader reader1 = cmd2.ExecuteReader();

                                                            if (reader1.HasRows)
                                                            {
                                                                while (reader1.Read())
                                                                {
                                                                    int solde1Index = reader1.GetOrdinal("montant");
                                                                    if (reader1[solde1Index] != DBNull.Value)
                                                                        solde = reader1.GetInt32(solde1Index);

                                                                    int soldeNV1 = solde - Convert.ToInt16(textBox3.Text);

                                                                    using (SqlConnection con3 = new SqlConnection(connectionString))
                                                                    {
                                                                        con3.Open();
                                                                        string sql3 = "update compte set montant = '" + soldeNV1 + "' where compte_num  = '" + CD + "'";
                                                                        SqlCommand cmd = new SqlCommand(sql3, con3);
                                                                        cmd.ExecuteNonQuery();
                                                                    }


                                                                }
                                                            }
                                                            else
                                                            {
                                                                    ErrMessage.Errmsg = "Une erreur s'est produite \n et a empêché le virement, veillez s assurer de vos information de compte \n (verifier votre mot de passe ou votre numero de compte)";
                                                                    ErrMessage.ShowDialog();

                                                                       break;

                                                            }

                                                            reader1.Close();
                                                        }

                                                        using (SqlConnection con4 = new SqlConnection(connectionString))
                                                        {
                                                            con4.Open();
                                                            string sql4 = "update compte set montant = '" + soldeNV + "' where compte_num = '" + CA + "'";
                                                            SqlCommand cmd = new SqlCommand(sql4, con4);
                                                            cmd.ExecuteNonQuery();

                                                            using (SqlConnection con5 = new SqlConnection(connectionString))
                                                            {
                                                                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                                                                dateTimePicker1.CustomFormat = "MM-dd-yyyy";
                                                                con5.Open();
                                                                using (SqlConnection con6 = new SqlConnection(connectionString))
                                                                {
                                                                    con6.Open();
                                                                    string sql6 = "SELECT Id FROM compte where compte_num  = '" + CD + "'";
                                                                    SqlCommand cmd6 = new SqlCommand(sql6, con6);
                                                                    SqlDataReader reader6 = cmd6.ExecuteReader();

                                                                    if (reader6.HasRows)
                                                                    {
                                                                        while (reader6.Read())
                                                                        {
                                                                            int compte_identifiant2Index = reader6.GetOrdinal("Id");
                                                                            int compte_identifiant2 = 0;

                                                                            if (reader6[compte_identifiant2Index] != DBNull.Value)
                                                                                compte_identifiant2 = reader6.GetInt32(compte_identifiant2Index);



                                                                            string op_montant = textBox3.Text;

                                                                            string libelle = textBox4.Text;
                                                                            string op_type = "Virement";
                                                                            string sql5 = "INSERT INTO operation(operation_type,operation_date,montant,compte_id,libelle,num_compte_beneficiaire) VALUES ('" + op_type + "','" + dateTimePicker1.Text + "','" + op_montant + "','" + compte_identifiant + "','" + libelle + "','" + CA + "')";

                                                                            SqlCommand cmd5 = new SqlCommand(sql5, con5);
                                                                            cmd5.ExecuteNonQuery();



                                                                        }


                                                                    }

                                                                }


                                                            }
                                                            ErrMessage.Errmsg = "le virement réussi";
                                                            ErrMessage.ShowDialog();
                                                            // MessageBox.Show("le virement réussi");



                                                        }



                                                    }

                                                }
                                                else
                                                {
                                                    ErrMessage.Errmsg = "compte introuvable veillez s assurer du numero du compte destinataire";
                                                    ErrMessage.ShowDialog();
                                                    //MessageBox.Show("compte introuvable veillez s assurer du numero du compte destinataire");
                                                }

                                                reader.Close();
                                            }
                                        }


                                    }

                                }
                            }
                        }



                    }


                }

            }



        }
    }
}
}
