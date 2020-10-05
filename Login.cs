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
    public partial class Login : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand cmd;

        comptes comptes;
        principal principal;
        Form1 form ;
        public Login()
        {
            InitializeComponent();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            animator1.HideSync(loginPanel);
        }

        private void LogintextBox_Enter(object sender, EventArgs e)
        {
            if (LogintextBox.Text == "Login")
            {
                LogintextBox.Text = "";
                LogintextBox.ForeColor = Color.Black;
            }
        }

        private void LogintextBox_Leave(object sender, EventArgs e)
        {
            if (LogintextBox.Text == "")
            {
                LogintextBox.Text = "Login";
                LogintextBox.ForeColor = Color.DimGray;
            }
        }

        private void PasswordtextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordtextBox.Text == "Password")
            {
                PasswordtextBox.Text = "";
                PasswordtextBox.ForeColor = Color.Black;
            }
        }

        private void PasswordtextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordtextBox.Text == "")
            {
                PasswordtextBox.Text = "Password";
                PasswordtextBox.ForeColor = Color.DimGray;
            }
        }

        private void PasswordtextBox_KeyUp(object sender, KeyEventArgs e)
        {
                PasswordtextBox.UseSystemPasswordChar = true;
            Eye_Closed.Visible = true;
            Eye_Opend.Visible = false;
        }


        private void acceuilButton_Click(object sender, EventArgs e)
        {
            acceuil ac = new acceuil();
            this.Hide();
            ac.Show();
        }

        private void fermerButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Eye_Closed_Click(object sender, EventArgs e)
        {
            Eye_Closed.Visible = false;
            Eye_Opend.Visible = true;
            PasswordtextBox.UseSystemPasswordChar = false;

        }

        private void Eye_Opend_Click(object sender, EventArgs e)
        {
            Eye_Closed.Visible = true;
            Eye_Opend.Visible = false;
            PasswordtextBox.UseSystemPasswordChar = true;
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            
            comptes = new comptes();
            comptes.login = LogintextBox.Text;
            comptes.mdp = PasswordtextBox.Text;

            principal = new principal();
            principal.login = LogintextBox.Text;
            principal.mdp = PasswordtextBox.Text;

            form = new Form1();
            form.login = LogintextBox.Text;
            form.mdp = PasswordtextBox.Text;
            int compte_id;
            try
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select compte_id from [authentification] where login = '" + LogintextBox.Text + "' and password = '" + PasswordtextBox.Text + "'";
                compte_id = Convert.ToInt32(cmd.ExecuteScalar());
                if (compte_id != 0)
                {
                    errorMsg.Visible = false;
                    this.Hide();
                    form.compte_id = compte_id;
                    form.Show();
                }
                else
                {
                    errorMsg.Visible = true;
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                BoxMessage box = new BoxMessage("erreur de connection: "+ex.Message);
                box.Show();
            }
        }

        private void LogintextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string st = "0123456789" + (char)8; //(char)8 c'est pour l'escpace
            if (st.IndexOf(e.KeyChar) == -1)
            {
                String message = "Please enter digits only !!";
                BoxMessage Boxmsg = new BoxMessage(message);
                Boxmsg.Show();
                //MessageBox.Show("please enter digits only");
                e.Handled = true;
            }
        }
    }
}
