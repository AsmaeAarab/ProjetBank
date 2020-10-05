using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Management;
using System.Web.Security;
using System.Windows.Forms;

namespace Projet
{
    public partial class Creation_user : Form
    {

        static string connectionString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand cmd;

        RadioButton selectedRadio_civilite;
        RadioButton selectedRadio_type_compte;

        List<string> NumcompteTableau = new List<string>();

        List<string> LoginTableau = new List<string>();
        Regex patternEmail = new Regex(@"(?<word>\w+)[@]([a-zA-Z]+)[.]([a-zA-Z]{2,3})$");
        pleaseWait wait = new pleaseWait();

        public Creation_user()
        {
            InitializeComponent();
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from compte";
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                NumcompteTableau.Add(read.GetString(1));
            }
            read.Close();
            connection.Close();
            //--------------------------------------------

        }
        private void Creation_user_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.agence'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.agenceTableAdapter.Fill(this.dataSet1.agence);
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.ville'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.villeTableAdapter.Fill(this.dataSet1.ville);
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.agence'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.agenceTableAdapter.Fill(this.dataSet1.agence);
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.type_compte'. Vous pouvez la déplacer ou la supprimer selon les besoins.
           // this.type_compteTableAdapter.Fill(this.dataSet1.type_compte);
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.ville'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.villeTableAdapter.Fill(this.dataSet1.ville);// fillby c pour les donnees trier
            selectedRadio_civilite = Ms_radio;
            selectedRadio_type_compte = Compte_cheque;
            operateur_comboBox.Text = operateur_comboBox.Items[0].ToString();

        }
        // mettre la main sur le contenue du radio button
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
            {
                return;
                //selectedRadioButton = Ms_radio;
            }
            if (rb.Checked)
            {
                // Keep track of the selected RadioButton by saving a reference
                // to it.
                selectedRadio_civilite = rb;
            }
        }

        private void radioButton_typeCompte_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
            {
                return;
                //selectedRadioButton = Ms_radio;
            }
            if (rb.Checked)
            {
                // Keep track of the selected RadioButton by saving a reference
                // to it.
                selectedRadio_type_compte = rb;
            }
        }


        //placeholder du nom 
        private void NametextBox_Enter(object sender, EventArgs e)
        {
            if (NametextBox.Text == "Votre Nom")
            {
                NametextBox.Text = "";
                NametextBox.ForeColor = Color.Black;
            }
        }

        private void NametextBox_Leave(object sender, EventArgs e)
        {
            if (NametextBox.Text == "")
            {
                NametextBox.Text = "Votre Nom";
                NametextBox.ForeColor = Color.DimGray;
            }
        }
        private void NametextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (NametextBox.Text == "")
            {
                NomMsg.Visible = true;
            }
            else
                NomMsg.Visible = false;
        }
        // placeholder prenom
        private void PrenomtextBox_Enter(object sender, EventArgs e)
        {
            if (PrenomtextBox.Text == "Votre Prénom")
            {
                PrenomtextBox.Text = "";
                PrenomtextBox.ForeColor = Color.Black;
            }
        }
        private void PrenomtextBox_Leave(object sender, EventArgs e)
        {
            if (PrenomtextBox.Text == "")
            {
                PrenomtextBox.Text = "Votre Prénom";
                PrenomtextBox.ForeColor = Color.DimGray;
            }
        }

        private void PrenomtextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (PrenomtextBox.Text == "")
            {
                PrenomMsg.Visible = true;
            }
            else
                PrenomMsg.Visible = false;
        }

        //place holder email 

        private void EmailtextBox_Enter(object sender, EventArgs e)
        {
            if (EmailtextBox.Text == "xxx.xx@xx")
            {
                EmailtextBox.Text = "";
                EmailtextBox.ForeColor = Color.Black;
            }
        }

        private void EmailtextBox_Leave(object sender, EventArgs e)
        {
            if (EmailtextBox.Text == "")
            {
                EmailtextBox.Text = "xxx.xx@xx";
                EmailtextBox.ForeColor = Color.DimGray;
            }
        }
        private void EmailtextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (EmailtextBox.Text == "")
            {
                EmailMsg.Text = "Empty field";
                EmailMsg.Visible = true;
            }
            else
            {
                if (!patternEmail.IsMatch(EmailtextBox.Text))
                {
                    EmailMsg.Text = "Email is not valid";
                    EmailMsg.Visible = true;
                }
                else
                {
                    EmailMsg.Visible = false;
                }
            }
        }

        // email confirmation
        private void EmailConfirmationtextBox_Enter(object sender, EventArgs e)
        {
            if (EmailConfirmationtextBox.Text == "Confirmer votre Email")
            {
                EmailConfirmationtextBox.Text = "";
                EmailConfirmationtextBox.ForeColor = Color.Black;
            }
        }

        private void EmailConfirmationtextBox_Leave(object sender, EventArgs e)
        {
            if (EmailConfirmationtextBox.Text == "")
            {
                EmailConfirmationtextBox.Text = "Confirmer votre Email";
                EmailConfirmationtextBox.ForeColor = Color.DimGray;
            }
        }

        private void EmailConfirmationtextBox_KeyUp(object sender, KeyEventArgs e)
        {

           if(EmailConfirmationtextBox.Text == "") 
            {
                EmailConfirmationMsg.Text = "Empty field";
                EmailConfirmationMsg.Visible = true;
            }
           else
            {
                if (EmailtextBox.Text == EmailConfirmationtextBox.Text)
                {
                    EmailConfirmationMsg.Visible = false;
                }
                else
                {
                    EmailConfirmationMsg.Text = "Email addresses don't match";
                    EmailConfirmationMsg.Visible = true;
                }
            }
        }
        //placeholder telephone
        private void TeltextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(TeltextBox.TextLength != 9 && TeltextBox.Text.StartsWith("0"))
            {
                TelMsg.Text = "must not start with '0'" + "\n" + "number must be 9 digits long";
                TelMsg.Visible = true;
            }
            else
            {
                if (TeltextBox.Text == "")
                {
                    TelMsg.Text = "Empty field";
                    TelMsg.Visible = true;
                }
                else
                {
                    if (TeltextBox.Text.StartsWith("0"))
                    {
                    TelMsg.Text = "must not start with '0'";
                    TelMsg.Visible = true;
                     }
                     else
                     {
                        if (TeltextBox.TextLength != 9)
                        {
                            TelMsg.Text = "number must be 9 digits long";
                            TelMsg.Visible = true;
                        }
                        else
                            TelMsg.Visible = false;
                    }
                }
            }


        }
        //stoper les lettre d'etre ecrite
        private void TeltextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private Boolean Empty_formulaire_validation()
        {
            if (EmailtextBox.Text != "xxx.xx@xx" && EmailtextBox.Text != "" && EmailConfirmationtextBox.Text != "Confirmer votre Email" && EmailConfirmationtextBox.Text != "" && NametextBox.Text !="Votre Nom"
                && NametextBox.Text != "" & PrenomtextBox.Text !="Votre Prénom" && PrenomtextBox.Text != ""  && !String.IsNullOrEmpty(TeltextBox.Text) )
                return true;
            else
            {
                if(EmailtextBox.Text == "xxx.xx@xx" || EmailtextBox.Text == "")
                {
                    EmailMsg.Text = "Empty field";
                    EmailMsg.Visible = true;
                }
                if(EmailConfirmationtextBox.Text == "Confirmer votre Email" || EmailConfirmationtextBox.Text == "")
                {
                    EmailConfirmationMsg.Text = "Empty field";
                    EmailConfirmationMsg.Visible = true;
                }
                if (NametextBox.Text == "Votre Nom" || NametextBox.Text == "")
                {
                    NomMsg.Visible = true;
                }
                if (PrenomtextBox.Text == "Votre Prénom" || PrenomtextBox.Text == "")
                {
                    PrenomMsg.Visible = true;
                }
                if (String.IsNullOrEmpty(TeltextBox.Text))
                {
                    TelMsg.Text = "Empty field";
                    TelMsg.Visible = true;
                }
                return false;
            }         
        }

        private Boolean Error_formulaire_validation()
        {
            if (!NomMsg.Visible && !PrenomMsg.Visible && !EmailMsg.Visible && !EmailConfirmationMsg.Visible
                && !TelMsg.Visible )
                return true;// pas d'erreur
            else
                return false;
        }
        // get password avec generate password
        private Boolean Validated_password(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            //var hasSpecialChar = new Regex(@"*! @#\$%\^&\(){}\[]:;<>\?/~_\+-=\|\");
          //  var hasMinimum8Chars = new Regex(@".{6,}");

            var isValidated = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasLowerChar.IsMatch(password) ;
            return isValidated;
        }
        public string GetPassword()
        {
            string pwd;
            do
            {
                pwd = Membership.GeneratePassword(8, 0);
            } while (!Validated_password(pwd));
            return pwd;
        }

        // get numero de compte 
        private Boolean Validated_NumCompte(string numCompte)
        {
            var hasNumber = new Regex(@"\b[0-9]{12}?\b");
            var isValidated = hasNumber.IsMatch(numCompte);
            return isValidated && !numCompte.StartsWith("0");
        }
        public string GetRandomString(int stringLength)
        {
            Random ran = new Random();
            String b = "0123456789";
            string random = "20089"; // comme id de la banque
            for (int i = 0; i < stringLength; i++)
            {
                int a = ran.Next(b.Length); //string.Lenght gets the size of string
                random = random + b.ElementAt(a);
            }
            return random;
        }
        public string GetNumCompte()
        {   string numCompte;
            do
            {
                numCompte = GetRandomString(7);// numCompte est compose de 12 chiffres 7+5
            } while (!Validated_NumCompte(numCompte));
            return numCompte;
        }

        public string GetUniqueNumCompte()
        {
            string numCompte;
            do
            {
                numCompte = GetNumCompte();
            } while (NumcompteTableau.IndexOf(numCompte) != -1);
            NumcompteTableau.Add(numCompte);
            return numCompte;
        }
        // get password sans trop de char speciaux 
        public static string GetRandomPassword(int stringLength)
        {
            Random ran = new Random();
            String b = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789%@*-_!:&/+$";
            string random = "";
            for (int i = 0; i < stringLength; i++)
            {
                int a = ran.Next(b.Length); //string.Lenght gets the size of string
                random = random + b.ElementAt(a);
            }

            return random;
        }

     /*   public string GetUniquelogin()
        {
            string login;
            do
            {
                login = GetRandomlogin(7);
            } while (LoginTableau.IndexOf(login) != -1);
            LoginTableau.Add(login);
            return login;
        }*/

        public bool Send_password_to_Client(string login, string password)
        {
            bool success = true;
            String pswd = password;

            String log = login;                //numero du compte
            //----------------------------------------------//

            String Mail_from = "gto.banque@gmail.com";
            String Mail_To = EmailtextBox.Text;
            String Mail_Subject = "Activation du Compte Bancaire";

            String Mail_content = @"<h5 style = 'background-color:rgb(64, 54, 86);' width = '200' > <img src = 'cid:EmbeddedContent_1' width = '50' height = '50' align = 'middle'/> " +
            "<Font size='4pt' color='white' > Bonjour " + ",</FONT></h5><br/>" + selectedRadio_civilite.Text + " " + NametextBox.Text.ToUpper() + ",</FONT></h5><br/>"
                + "<pre> <FONT color='black' size='4pt'>Suite à votre demande de création de compte en ligne nous vous communiquons Votre login et votre mot de passe pour que " +
                "vous puissiez accéder à votre Espace Personnel.</FONT></pre><br/>"
                + "<center><FONT size='5pt'><mark>Votre Login :" + log + "</mark><br/>"
                + "<mark>Votre Password: " + pswd + " </mark></Font></center><br/> " +
                "<br/><small><FONT color='red'>Pour votre sécurité, nous vous rappelons de ne communiquer à personne vos codes secrets de connexion.</FONT></small></br>";

            string mediaType = MediaTypeNames.Image.Jpeg;
            LinkedResource img = new LinkedResource(@"bank-icon.jpg", mediaType);
            img.ContentId = "EmbeddedContent_1";
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
                SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
                sc.UseDefaultCredentials = false;
                NetworkCredential cre = new NetworkCredential("gto.banque@gmail.com", "alrm2020");
                sc.Credentials = cre;
                sc.EnableSsl = true;
                sc.Send(msg);
            }
            catch(Exception ex)
            {
                success = false;
                wait.Hide();
                if (MessageBox.Show(this, ex.Message, "erreur de connection !! ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    acceuil ac = new acceuil();
                    ac.Show();
                    this.Hide();
                }
            }
            return success;

        }
       
        private void valider(object sender, EventArgs e)
        {
            SqlTransaction transaction;
            if (Empty_formulaire_validation() && Error_formulaire_validation())
            {
                // wait msg
                
                wait.Show();
                Application.DoEvents();

                connection.Open();
                transaction = connection.BeginTransaction();
                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Transaction = transaction;
                // creation new client

                int insertedId_Client;
                   
                    
                    cmd.CommandText = @"insert into client (nom_client, prenom_client, civilite, num_tel, operateur, email) " +
                        "values (@nom_client, @prenom_client, @civilite, @num_tel, @operateur, @email); SELECT @@IDENTITY";
                    cmd.Parameters.Add(new SqlParameter("nom_client", NametextBox.Text));
                    cmd.Parameters.Add(new SqlParameter("prenom_client", PrenomtextBox.Text));
                    cmd.Parameters.Add(new SqlParameter("civilite", selectedRadio_civilite.Text));
                    cmd.Parameters.Add(new SqlParameter("num_tel", "+212" + TeltextBox.Text));
                    cmd.Parameters.Add(new SqlParameter("operateur", operateur_comboBox.SelectedItem.ToString()));
                    cmd.Parameters.Add(new SqlParameter("email", EmailtextBox.Text));
                    insertedId_Client = Convert.ToInt32(cmd.ExecuteScalar());
                    //connection.Close();
    
                // creation new compte pour ce client
                int insertedId_Compte;
                string compte_num = GetUniqueNumCompte();

                cmd.CommandText = @"insert into [compte] (compte_num, ouverture_compte_date, montant, type_compte_id, agence_id, client_id) " +
                                                "values (@compte_num, @ouverture_compte_date, @montant, @type_compte_id, @agence_id, @client_id); SELECT @@IDENTITY";
                cmd.Parameters.Add(new SqlParameter("@compte_num",compte_num));
                cmd.Parameters.Add(new SqlParameter("@ouverture_compte_date", DateTime.Now.ToString()));
                cmd.Parameters.Add(new SqlParameter("@montant", 6000));
                //-------------------
                if(selectedRadio_civilite.Text == "Compte chèque")
                    cmd.Parameters.Add(new SqlParameter("@type_compte_id", 1));
                else
                    cmd.Parameters.Add(new SqlParameter("@type_compte_id", 2));
                //-------------------
                cmd.Parameters.Add(new SqlParameter("@agence_id", (int)agence_comboBox.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@client_id", (int)insertedId_Client));
                insertedId_Compte = Convert.ToInt32(cmd.ExecuteScalar());
               // connection.Close();

                // attachemnet du client avec un pws et un login
                int insertedId_athentif;
                string login = compte_num.Substring(5,7);//12 chiffres unique pour chaque client 
                string pswd = GetRandomPassword(8);
                cmd.CommandText = "insert into authentification (login, password, compte_id) values (@login, @password, @compte_id); SELECT @@IDENTITY";
                cmd.Parameters.Add(new SqlParameter("@login", login));
                cmd.Parameters.Add(new SqlParameter("@password", pswd));
                cmd.Parameters.Add(new SqlParameter("@compte_id", insertedId_Compte));
                insertedId_athentif = Convert.ToInt32(cmd.ExecuteScalar());

                if (insertedId_Client != 0 && insertedId_Compte != 0 && insertedId_athentif != 0)
                {
                    if (Send_password_to_Client(login, pswd))
                    {
                        transaction.Commit();
                        connection.Close();
                        Login log = new Login();
                        this.Hide();
                        log.Show();
                        wait.Hide();
                    }
                    else
                    {
                        transaction.Rollback();
                        connection.Close();
                        BoxMessage box = new BoxMessage("Probleme de connexion: Votre requete de creation de compte n'est pas prise en consideration Veuillez réessayer plus tard");
                        box.Show();
                    }

                }

            }
               
            else
            {
                this.Cursor = Cursors.Default;
                String message = "Un ou plusieurs champs sont vides ou bien invalide !!\nVeuillez bien revérifier votre formulaire.";
                BoxMessage Boxmsg = new BoxMessage(message);
                Boxmsg.Show();
            }
            
        }

        private void Sortir_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            acceuil ac = new acceuil();
            ac.Show();
        }

    }
}
