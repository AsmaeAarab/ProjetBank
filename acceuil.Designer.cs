namespace Projet
{
    partial class acceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(acceuil));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.Panel_Bienvenue = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Panel_Login = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mot_passe_Oublier = new System.Windows.Forms.Label();
            this.Eye_Opend = new System.Windows.Forms.PictureBox();
            this.Eye_Closed = new System.Windows.Forms.PictureBox();
            this.errorMsg = new System.Windows.Forms.Label();
            this.confirmationDeCreation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogintextBox = new System.Windows.Forms.TextBox();
            this.Close_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LabelBienvenue = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LabelMessage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Espace_Personnel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.animator1 = new BunifuAnimatorNS.Animator(this.components);
            this.Panel_Bienvenue.SuspendLayout();
            this.Panel_Login.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Eye_Opend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eye_Closed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Bienvenue
            // 
            this.Panel_Bienvenue.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Bienvenue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Bienvenue.BackgroundImage")));
            this.Panel_Bienvenue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Bienvenue.Controls.Add(this.Panel_Login);
            this.Panel_Bienvenue.Controls.Add(this.LabelBienvenue);
            this.Panel_Bienvenue.Controls.Add(this.LabelMessage);
            this.animator1.SetDecoration(this.Panel_Bienvenue, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Bienvenue.GradientBottomLeft = System.Drawing.Color.Maroon;
            this.Panel_Bienvenue.GradientBottomRight = System.Drawing.Color.White;
            this.Panel_Bienvenue.GradientTopLeft = System.Drawing.Color.White;
            this.Panel_Bienvenue.GradientTopRight = System.Drawing.Color.CornflowerBlue;
            this.Panel_Bienvenue.Location = new System.Drawing.Point(546, -2);
            this.Panel_Bienvenue.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Bienvenue.Name = "Panel_Bienvenue";
            this.Panel_Bienvenue.Quality = 10;
            this.Panel_Bienvenue.Size = new System.Drawing.Size(550, 675);
            this.Panel_Bienvenue.TabIndex = 6;
            // 
            // Panel_Login
            // 
            this.Panel_Login.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Login.BackgroundImage")));
            this.Panel_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Login.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Login.Controls.Add(this.groupBox1);
            this.Panel_Login.Controls.Add(this.Close_Button);
            this.animator1.SetDecoration(this.Panel_Login, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Login.GradientBottomLeft = System.Drawing.Color.Maroon;
            this.Panel_Login.GradientBottomRight = System.Drawing.Color.Silver;
            this.Panel_Login.GradientTopLeft = System.Drawing.Color.Beige;
            this.Panel_Login.GradientTopRight = System.Drawing.Color.LightSkyBlue;
            this.Panel_Login.Location = new System.Drawing.Point(0, 0);
            this.Panel_Login.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Login.Name = "Panel_Login";
            this.Panel_Login.Quality = 10;
            this.Panel_Login.Size = new System.Drawing.Size(550, 675);
            this.Panel_Login.TabIndex = 2;
            this.Panel_Login.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mot_passe_Oublier);
            this.groupBox1.Controls.Add(this.Eye_Opend);
            this.groupBox1.Controls.Add(this.Eye_Closed);
            this.groupBox1.Controls.Add(this.errorMsg);
            this.groupBox1.Controls.Add(this.confirmationDeCreation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Login_button);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.PasswordtextBox);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.LogintextBox);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.animator1.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(18, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 385);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // mot_passe_Oublier
            // 
            this.mot_passe_Oublier.BackColor = System.Drawing.Color.Transparent;
            this.mot_passe_Oublier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.mot_passe_Oublier, BunifuAnimatorNS.DecorationType.None);
            this.mot_passe_Oublier.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mot_passe_Oublier.ForeColor = System.Drawing.Color.Maroon;
            this.mot_passe_Oublier.Location = new System.Drawing.Point(247, 351);
            this.mot_passe_Oublier.Name = "mot_passe_Oublier";
            this.mot_passe_Oublier.Size = new System.Drawing.Size(171, 22);
            this.mot_passe_Oublier.TabIndex = 61;
            this.mot_passe_Oublier.Text = "Mot de passe oublié ?";
            this.mot_passe_Oublier.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mot_passe_Oublier.Click += new System.EventHandler(this.mot_passe_Oublier_Click);
            // 
            // Eye_Opend
            // 
            this.Eye_Opend.BackColor = System.Drawing.Color.Transparent;
            this.Eye_Opend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Eye_Opend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.Eye_Opend, BunifuAnimatorNS.DecorationType.None);
            this.Eye_Opend.Image = ((System.Drawing.Image)(resources.GetObject("Eye_Opend.Image")));
            this.Eye_Opend.Location = new System.Drawing.Point(424, 242);
            this.Eye_Opend.Name = "Eye_Opend";
            this.Eye_Opend.Size = new System.Drawing.Size(33, 32);
            this.Eye_Opend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Eye_Opend.TabIndex = 60;
            this.Eye_Opend.TabStop = false;
            this.Eye_Opend.Visible = false;
            this.Eye_Opend.Click += new System.EventHandler(this.Eye_Opend_Click);
            // 
            // Eye_Closed
            // 
            this.Eye_Closed.BackColor = System.Drawing.Color.Transparent;
            this.Eye_Closed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Eye_Closed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.Eye_Closed, BunifuAnimatorNS.DecorationType.None);
            this.Eye_Closed.Image = ((System.Drawing.Image)(resources.GetObject("Eye_Closed.Image")));
            this.Eye_Closed.Location = new System.Drawing.Point(424, 242);
            this.Eye_Closed.Name = "Eye_Closed";
            this.Eye_Closed.Size = new System.Drawing.Size(33, 32);
            this.Eye_Closed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Eye_Closed.TabIndex = 11;
            this.Eye_Closed.TabStop = false;
            this.Eye_Closed.Click += new System.EventHandler(this.Eye_Closed_Click);
            // 
            // errorMsg
            // 
            this.errorMsg.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.errorMsg, BunifuAnimatorNS.DecorationType.None);
            this.errorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMsg.ForeColor = System.Drawing.Color.Maroon;
            this.errorMsg.Location = new System.Drawing.Point(99, 139);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(329, 41);
            this.errorMsg.TabIndex = 59;
            this.errorMsg.Text = "L\'authentification a échoué !!\r\nVeuillez vérifier votre Login et votre Password\r\n" +
    "";
            this.errorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorMsg.Visible = false;
            // 
            // confirmationDeCreation
            // 
            this.confirmationDeCreation.BackColor = System.Drawing.Color.Transparent;
            this.confirmationDeCreation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.confirmationDeCreation, BunifuAnimatorNS.DecorationType.None);
            this.confirmationDeCreation.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Underline);
            this.confirmationDeCreation.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.confirmationDeCreation.Location = new System.Drawing.Point(178, 334);
            this.confirmationDeCreation.Name = "confirmationDeCreation";
            this.confirmationDeCreation.Size = new System.Drawing.Size(240, 22);
            this.confirmationDeCreation.TabIndex = 57;
            this.confirmationDeCreation.Text = "Si vous n\'avez pas de compte, Cliquer ici\r\n";
            this.confirmationDeCreation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.confirmationDeCreation.Click += new System.EventHandler(this.confirmationDeCreation_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.animator1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(90, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 63);
            this.label1.TabIndex = 56;
            this.label1.Text = "Sign UP ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.animator1.SetDecoration(this.Login_button, BunifuAnimatorNS.DecorationType.None);
            this.Login_button.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(89)))), ((int)(((byte)(124)))));
            this.Login_button.Location = new System.Drawing.Point(90, 291);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(328, 40);
            this.Login_button.TabIndex = 55;
            this.Login_button.Text = "LOGIN";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Silver;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animator1.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(90, 242);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.animator1.SetDecoration(this.PasswordtextBox, BunifuAnimatorNS.DecorationType.None);
            this.PasswordtextBox.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordtextBox.ForeColor = System.Drawing.Color.DimGray;
            this.PasswordtextBox.Location = new System.Drawing.Point(150, 242);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(268, 32);
            this.PasswordtextBox.TabIndex = 54;
            this.PasswordtextBox.Text = "Password";
            this.PasswordtextBox.Enter += new System.EventHandler(this.PasswordtextBox_Enter);
            this.PasswordtextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PasswordtextBox_KeyUp);
            this.PasswordtextBox.Leave += new System.EventHandler(this.PasswordtextBox_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animator1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // LogintextBox
            // 
            this.LogintextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.animator1.SetDecoration(this.LogintextBox, BunifuAnimatorNS.DecorationType.None);
            this.LogintextBox.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogintextBox.ForeColor = System.Drawing.Color.DimGray;
            this.LogintextBox.Location = new System.Drawing.Point(150, 181);
            this.LogintextBox.Name = "LogintextBox";
            this.LogintextBox.Size = new System.Drawing.Size(268, 32);
            this.LogintextBox.TabIndex = 52;
            this.LogintextBox.Text = "Login";
            this.LogintextBox.Enter += new System.EventHandler(this.LogintextBox_Enter);
            this.LogintextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LogintextBox_KeyPress);
            this.LogintextBox.Leave += new System.EventHandler(this.LogintextBox_Leave);
            // 
            // Close_Button
            // 
            this.Close_Button.Activecolor = System.Drawing.Color.Transparent;
            this.Close_Button.BackColor = System.Drawing.Color.Transparent;
            this.Close_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Close_Button.BackgroundImage")));
            this.Close_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close_Button.BorderRadius = 0;
            this.Close_Button.ButtonText = "";
            this.Close_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.Close_Button, BunifuAnimatorNS.DecorationType.None);
            this.Close_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Close_Button.Iconimage = ((System.Drawing.Image)(resources.GetObject("Close_Button.Iconimage")));
            this.Close_Button.Iconimage_right = null;
            this.Close_Button.Iconimage_right_Selected = null;
            this.Close_Button.Iconimage_Selected = null;
            this.Close_Button.IconZoom = 50D;
            this.Close_Button.IsTab = false;
            this.Close_Button.Location = new System.Drawing.Point(488, 3);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Close_Button.OnHovercolor = System.Drawing.Color.Transparent;
            this.Close_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Close_Button.selected = false;
            this.Close_Button.Size = new System.Drawing.Size(37, 38);
            this.Close_Button.TabIndex = 58;
            this.Close_Button.Textcolor = System.Drawing.Color.White;
            this.Close_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click_1);
            // 
            // LabelBienvenue
            // 
            this.LabelBienvenue.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.LabelBienvenue, BunifuAnimatorNS.DecorationType.None);
            this.LabelBienvenue.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBienvenue.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LabelBienvenue.Image = ((System.Drawing.Image)(resources.GetObject("LabelBienvenue.Image")));
            this.LabelBienvenue.Location = new System.Drawing.Point(122, 151);
            this.LabelBienvenue.Name = "LabelBienvenue";
            this.LabelBienvenue.Size = new System.Drawing.Size(334, 112);
            this.LabelBienvenue.TabIndex = 1;
            this.LabelBienvenue.Text = "Bienvenue";
            this.LabelBienvenue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelMessage
            // 
            this.LabelMessage.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.LabelMessage, BunifuAnimatorNS.DecorationType.None);
            this.LabelMessage.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMessage.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.LabelMessage.Image = ((System.Drawing.Image)(resources.GetObject("LabelMessage.Image")));
            this.LabelMessage.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LabelMessage.Location = new System.Drawing.Point(122, 254);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(334, 165);
            this.LabelMessage.TabIndex = 0;
            this.LabelMessage.Text = "créer votre compte bancaire en ligne, où que vous soyer en toute sécurité .\r\n\r\n";
            this.LabelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.Espace_Personnel);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton1);
            this.animator1.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.RosyBrown;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.MediumPurple;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-4, -2);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(550, 675);
            this.bunifuGradientPanel1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.label6.Location = new System.Drawing.Point(118, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Rania BOUMAZZOUGH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.label5.Location = new System.Drawing.Point(118, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Laila EL HALOUI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.label4.Location = new System.Drawing.Point(118, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Meriem DAOUCHI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.label3.Location = new System.Drawing.Point(118, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Asmae AARAB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.label2.Location = new System.Drawing.Point(16, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Réalisé par:";
            // 
            // Espace_Personnel
            // 
            this.Espace_Personnel.Activecolor = System.Drawing.Color.Thistle;
            this.Espace_Personnel.BackColor = System.Drawing.Color.Thistle;
            this.Espace_Personnel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Espace_Personnel.BorderRadius = 5;
            this.Espace_Personnel.ButtonText = "ESPACE PERSONNEL";
            this.Espace_Personnel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.Espace_Personnel, BunifuAnimatorNS.DecorationType.None);
            this.Espace_Personnel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Espace_Personnel.Iconcolor = System.Drawing.Color.Transparent;
            this.Espace_Personnel.Iconimage = ((System.Drawing.Image)(resources.GetObject("Espace_Personnel.Iconimage")));
            this.Espace_Personnel.Iconimage_right = null;
            this.Espace_Personnel.Iconimage_right_Selected = null;
            this.Espace_Personnel.Iconimage_Selected = null;
            this.Espace_Personnel.IconZoom = 60D;
            this.Espace_Personnel.IsTab = false;
            this.Espace_Personnel.Location = new System.Drawing.Point(155, 348);
            this.Espace_Personnel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Espace_Personnel.Name = "Espace_Personnel";
            this.Espace_Personnel.Normalcolor = System.Drawing.Color.Thistle;
            this.Espace_Personnel.OnHovercolor = System.Drawing.Color.Thistle;
            this.Espace_Personnel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Espace_Personnel.selected = false;
            this.Espace_Personnel.Size = new System.Drawing.Size(213, 51);
            this.Espace_Personnel.TabIndex = 3;
            this.Espace_Personnel.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Espace_Personnel.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Espace_Personnel.Click += new System.EventHandler(this.Espace_Personnel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.animator1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(544, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Thistle;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Thistle;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 5;
            this.bunifuFlatButton1.ButtonText = "DEVENIR CLIENT";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconZoom = 60D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(155, 266);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Thistle;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Thistle;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(213, 51);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // animator1
            // 
            this.animator1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.animator1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation1;
            this.animator1.MaxAnimationTime = 2500;
            // 
            // acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 636);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.Panel_Bienvenue);
            this.animator1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "acceuil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.acceuil_Load);
            this.Panel_Bienvenue.ResumeLayout(false);
            this.Panel_Login.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Eye_Opend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eye_Closed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel Panel_Bienvenue;
        private Bunifu.Framework.UI.BunifuCustomLabel LabelBienvenue;
        private Bunifu.Framework.UI.BunifuCustomLabel LabelMessage;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton Espace_Personnel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private BunifuAnimatorNS.Animator animator1;
        private Bunifu.Framework.UI.BunifuGradientPanel Panel_Login;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton Close_Button;
        private System.Windows.Forms.Label confirmationDeCreation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox LogintextBox;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.PictureBox Eye_Closed;
        private System.Windows.Forms.PictureBox Eye_Opend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label mot_passe_Oublier;
    }
}

