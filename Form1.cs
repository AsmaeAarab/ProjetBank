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
namespace Projet
{
    public partial class Form1 : Form
    {
        public string login;
        public string mdp;
        public int compte_id;
        principal principal;
        comptes comptes;
        virement virement;
        Tel_Internet Tel_Internet;
        Eau_Electricite Eau_Electricite;
        Administration administration;
        
        //SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\W\Downloads\Projet\Projet\Banque.mdf;Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
            CustomizeMenu();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }
        private void CustomizeMenu()
        {
            panel1.Visible = false;
        }
        private void hideFactureMenu()
        {
            if (panel1.Visible == true)
                panel1.Visible = false;
        }
       
        private void showFactureMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideFactureMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        
//panel facture
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            showFactureMenu(panel1);
        }
    //panel liste facture
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
               
        }

        // open child Form
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.TopMost = true;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelRightBottom.Controls.Add(childForm);
            panelRightBottom.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

      

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            virement = new virement();
            virement.login = login;
            virement.mdp = mdp;
            virement.compte_id = compte_id;
            openChildForm(virement);
            hideFactureMenu();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

      

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            Tel_Internet = new Tel_Internet();
            Tel_Internet.compte_id = compte_id;
            
            openChildForm(Tel_Internet);
            hideFactureMenu();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            Eau_Electricite = new Eau_Electricite();
            Eau_Electricite.compte_id = compte_id;
            Console.WriteLine("id" + compte_id);

            openChildForm(Eau_Electricite);
            hideFactureMenu();
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            administration = new Administration();
            administration.compte_id = compte_id;
            openChildForm(administration);
            hideFactureMenu();
            
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRightTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRightBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {

            comptes = new comptes();
            comptes.login = login;
            comptes.mdp = mdp;
            openChildForm(comptes);
            hideFactureMenu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            principal = new principal();
            principal.login = login;
            principal.mdp = mdp;
            openChildForm(principal);
            hideFactureMenu();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            principal = new principal();
            principal.login = login;
            principal.mdp = mdp;
            openChildForm(principal);
            hideFactureMenu();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            acceuil acceuil = new acceuil();
            this.Close();
            acceuil.Show();
        }
    }
}

