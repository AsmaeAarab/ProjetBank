using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Twilio.TwiML.Voice;

namespace Projet
{
    public partial class Passwordoublier : Form
    {
       // SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asmae\Desktop\Projet\Banque.mdf;Integrated Security=True");
        static string connectionString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        SqlConnection connection = new SqlConnection(connectionString);
         pleaseWait wait = new pleaseWait();
     // private static System.Timers.Timer aTimer;
        SqlCommand cmd;
        public Passwordoublier()
        {
            InitializeComponent();
        }



        public bool Send_password_to_Client(string password, string emailto)
        {
            bool success = true;
            String pswd = password;

            //----------------------------------------------//

            String Mail_from = "gto.banque@gmail.com";
            String Mail_To = emailto;
            String Mail_Subject = "Changement du mot de passe";


            String Mail_content = @"<h5 style='background-color:rgb(64, 54, 86);' width='200' ><img src='cid:EmbeddedContent_1' width='50' height='50' align='middle'/>" +
            "<Font size='4pt' color='white' > Bonjour " + ",</FONT></h5><br/>"
                + "<pre> <FONT color='black' size='4pt'>Suite à votre demande de changement de mot de passe nous vous communiquons votre nouveau mot de passe pour que " +
                "vous puissiez accéder à votre Espace Personnel.</FONT></pre><br/>"
                + "<center><FONT size='5pt'><mark> Votre Password: " + pswd + "</mark></Font></center><br/>" +
                "<br/><small><FONT color='red'>Pour votre sécurité, nous vous rappelons de ne communiquer à personne vos codes secrets de connexion.</FONT></small></br>"
                ;
            string mediaType = MediaTypeNames.Image.Jpeg;
            LinkedResource img = new LinkedResource(@"bank-icon.jpg", mediaType)
            {
                ContentId = "EmbeddedContent_1"
            };
            img.ContentType.MediaType = mediaType;
            img.TransferEncoding = TransferEncoding.Base64;
            img.ContentType.Name = img.ContentId;
            img.ContentLink = new Uri("cid:" + img.ContentId);
            
            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(
                                             Mail_content,
                                             Encoding.UTF8,
                                             MediaTypeNames.Text.Html);
            htmlView.LinkedResources.Add(img);
            try
            {
                MailMessage msg = new MailMessage(Mail_from, Mail_To, Mail_Subject, Mail_content);
                msg.AlternateViews.Add(htmlView);
                msg.IsBodyHtml = true;
                SmtpClient sc = new SmtpClient("smtp.gmail.com", 587)
                {
                    UseDefaultCredentials = false
                };
                NetworkCredential cre = new NetworkCredential("gto.banque@gmail.com", "alrm2020");
                sc.Credentials = cre;
                sc.EnableSsl = true;
                sc.Send(msg);
            }
            catch (Exception ex)
            {
                success = false;
                wait.Hide();
                if (MessageBox.Show(this, ex.Message, "erreur de connexion !! " , MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    acceuil ac = new acceuil();
                    ac.Show();
                    this.Hide();
                }

            }
            return success;
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction;
            if (LogintextBox.Text == "Login" || LogintextBox.Text == "")
            {
                errorMsg.Visible = true;
            }
            else
            {
                errorMsg.Visible = false;
                this.Visible = false;
                //wait msg
                wait.Show();
                Application.DoEvents();

                connection.Open();
                transaction = connection.BeginTransaction();
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Transaction = transaction;

                //chercher le compte_id
                cmd.CommandText = "select compte_id from [authentification] where login = '" + LogintextBox.Text + "'";
                int compte_id = Convert.ToInt32(cmd.ExecuteScalar());

                //chercher le client id
                cmd.CommandText = "select client_id from [compte] where Id = '" + compte_id + "'";
                int client_id = Convert.ToInt32(cmd.ExecuteScalar());

                // chercher l email
                cmd.CommandText = "select email from [client] where Id = '" + client_id + "'";
                string email = Convert.ToString(cmd.ExecuteScalar());

                string pswd = Creation_user.GetRandomPassword(8);

                //update password
                cmd.CommandText = "update authentification set password = @password where compte_id = @compte_id";
                cmd.Parameters.Add(new SqlParameter("@password", pswd));
                cmd.Parameters.Add(new SqlParameter("@compte_id", compte_id));
                cmd.ExecuteNonQuery();


                if (email != "" && compte_id != 0 && client_id != 0)
                {
                    if (Send_password_to_Client(pswd, email) == true)
                    {
                        transaction.Commit();
                        connection.Close();
                        wait.Hide();
                        MessageBox_confirmation confirmation = new MessageBox_confirmation("votre nouveau mot de passe sera envoyé à l'adresse email que vous avez utilisée lors de votre enregistrement. ");
                        confirmation.ShowDialog();
                        Login log = new Login();
                        log.LabelBienvenue.Text = "Votre Demande de Changement du mot de passe est prise en compte";
                        log.message.Text = "Un email de confirmation vous sera envoyé à votre adresse mail que vous avais renseignée dans le formulaire," +
                            "Ce mail contiendra votre nouveau mot de passe pour que vous pouviez acceder à votre compte personnel.";
                        log.Show();
                        this.Hide();
                    }
                    else
                    {
                        transaction.Rollback();
                        connection.Close();
                        BoxMessage box = new BoxMessage("Probleme de connexion: Votre requete de changement de mot de passe n'est pas prise en consideration Veuillez réessayer plus tard");
                        box.Show();
                    }
                }
                else
                {
                    BoxMessage box = new BoxMessage("utilisateur non reconnu");
                    box.Show();
                    wait.Hide();
                    this.Show();
                    connection.Close();
                }

            }

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


        private void close_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            acceuil ac = new acceuil();
            ac.Show();
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
