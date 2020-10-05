namespace Projet
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.Panel_Login = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.message = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LabelBienvenue = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Eye_Closed = new System.Windows.Forms.PictureBox();
            this.Eye_Opend = new System.Windows.Forms.PictureBox();
            this.errorMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogintextBox = new System.Windows.Forms.TextBox();
            this.Close_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.acceuilButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fermerButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.animator1 = new BunifuAnimatorNS.Animator(this.components);
            this.Panel_Login.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Eye_Closed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eye_Opend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Login
            // 
            this.Panel_Login.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Login.BackgroundImage")));
            this.Panel_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Login.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Login.Controls.Add(this.message);
            this.Panel_Login.Controls.Add(this.LabelBienvenue);
            this.Panel_Login.Controls.Add(this.groupBox1);
            this.animator1.SetDecoration(this.Panel_Login, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Login.GradientBottomLeft = System.Drawing.Color.Maroon;
            this.Panel_Login.GradientBottomRight = System.Drawing.Color.WhiteSmoke;
            this.Panel_Login.GradientTopLeft = System.Drawing.Color.White;
            this.Panel_Login.GradientTopRight = System.Drawing.Color.LightSkyBlue;
            this.Panel_Login.Location = new System.Drawing.Point(0, 0);
            this.Panel_Login.Name = "Panel_Login";
            this.Panel_Login.Quality = 10;
            this.Panel_Login.Size = new System.Drawing.Size(1101, 675);
            this.Panel_Login.TabIndex = 4;
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.message, BunifuAnimatorNS.DecorationType.None);
            this.message.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.message.Location = new System.Drawing.Point(122, 120);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(795, 68);
            this.message.TabIndex = 54;
            this.message.Text = resources.GetString("message.Text");
            this.message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelBienvenue
            // 
            this.LabelBienvenue.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.LabelBienvenue, BunifuAnimatorNS.DecorationType.None);
            this.LabelBienvenue.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBienvenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.LabelBienvenue.Image = ((System.Drawing.Image)(resources.GetObject("LabelBienvenue.Image")));
            this.LabelBienvenue.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LabelBienvenue.Location = new System.Drawing.Point(120, -2);
            this.LabelBienvenue.Name = "LabelBienvenue";
            this.LabelBienvenue.Size = new System.Drawing.Size(797, 122);
            this.LabelBienvenue.TabIndex = 52;
            this.LabelBienvenue.Text = "Votre Demande de création de compte en ligne est prise en compte";
            this.LabelBienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginPanel);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.acceuilButton);
            this.groupBox1.Controls.Add(this.fermerButton);
            this.groupBox1.Controls.Add(this.bunifuFlatButton2);
            this.groupBox1.Controls.Add(this.bunifuFlatButton1);
            this.animator1.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(241, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 421);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // loginPanel
            // 
            this.loginPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginPanel.BackgroundImage")));
            this.loginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginPanel.Controls.Add(this.groupBox2);
            this.loginPanel.Controls.Add(this.Close_Button);
            this.animator1.SetDecoration(this.loginPanel, BunifuAnimatorNS.DecorationType.None);
            this.loginPanel.GradientBottomLeft = System.Drawing.Color.Maroon;
            this.loginPanel.GradientBottomRight = System.Drawing.Color.Beige;
            this.loginPanel.GradientTopLeft = System.Drawing.Color.LavenderBlush;
            this.loginPanel.GradientTopRight = System.Drawing.Color.LightBlue;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Quality = 10;
            this.loginPanel.Size = new System.Drawing.Size(534, 421);
            this.loginPanel.TabIndex = 59;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Eye_Closed);
            this.groupBox2.Controls.Add(this.Eye_Opend);
            this.groupBox2.Controls.Add(this.errorMsg);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Login_button);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.PasswordtextBox);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.LogintextBox);
            this.animator1.SetDecoration(this.groupBox2, BunifuAnimatorNS.DecorationType.None);
            this.groupBox2.Location = new System.Drawing.Point(70, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 404);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            // 
            // Eye_Closed
            // 
            this.Eye_Closed.BackColor = System.Drawing.Color.Transparent;
            this.Eye_Closed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Eye_Closed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.Eye_Closed, BunifuAnimatorNS.DecorationType.None);
            this.Eye_Closed.Image = ((System.Drawing.Image)(resources.GetObject("Eye_Closed.Image")));
            this.Eye_Closed.Location = new System.Drawing.Point(352, 268);
            this.Eye_Closed.Name = "Eye_Closed";
            this.Eye_Closed.Size = new System.Drawing.Size(33, 32);
            this.Eye_Closed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Eye_Closed.TabIndex = 62;
            this.Eye_Closed.TabStop = false;
            this.Eye_Closed.Click += new System.EventHandler(this.Eye_Closed_Click);
            // 
            // Eye_Opend
            // 
            this.Eye_Opend.BackColor = System.Drawing.Color.Transparent;
            this.Eye_Opend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Eye_Opend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.Eye_Opend, BunifuAnimatorNS.DecorationType.None);
            this.Eye_Opend.Image = ((System.Drawing.Image)(resources.GetObject("Eye_Opend.Image")));
            this.Eye_Opend.Location = new System.Drawing.Point(352, 268);
            this.Eye_Opend.Name = "Eye_Opend";
            this.Eye_Opend.Size = new System.Drawing.Size(33, 32);
            this.Eye_Opend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Eye_Opend.TabIndex = 61;
            this.Eye_Opend.TabStop = false;
            this.Eye_Opend.Visible = false;
            this.Eye_Opend.Click += new System.EventHandler(this.Eye_Opend_Click);
            // 
            // errorMsg
            // 
            this.errorMsg.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.errorMsg, BunifuAnimatorNS.DecorationType.None);
            this.errorMsg.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.errorMsg.ForeColor = System.Drawing.Color.Maroon;
            this.errorMsg.Location = new System.Drawing.Point(28, 151);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(329, 51);
            this.errorMsg.TabIndex = 59;
            this.errorMsg.Text = "L\'authentification a échoué !!\r\nVeuillez vérifier votre Login et votre Password\r\n" +
    "";
            this.errorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorMsg.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.animator1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(31, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 63);
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
            this.Login_button.Location = new System.Drawing.Point(28, 318);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(320, 40);
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
            this.pictureBox3.Location = new System.Drawing.Point(28, 268);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 32);
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
            this.PasswordtextBox.Location = new System.Drawing.Point(81, 268);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(267, 32);
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
            this.pictureBox1.Location = new System.Drawing.Point(28, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 32);
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
            this.LogintextBox.Location = new System.Drawing.Point(81, 216);
            this.LogintextBox.Name = "LogintextBox";
            this.LogintextBox.Size = new System.Drawing.Size(267, 32);
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
            this.Close_Button.Location = new System.Drawing.Point(491, 3);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Normalcolor = System.Drawing.Color.Transparent;
            this.Close_Button.OnHovercolor = System.Drawing.Color.Transparent;
            this.Close_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Close_Button.selected = false;
            this.Close_Button.Size = new System.Drawing.Size(37, 38);
            this.Close_Button.TabIndex = 58;
            this.Close_Button.Textcolor = System.Drawing.Color.White;
            this.Close_Button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(18, 96);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(503, 100);
            this.bunifuCustomLabel1.TabIndex = 57;
            this.bunifuCustomLabel1.Text = "Nous vous remercions de la confiance que vous nous accordez. \r\nAu plaisir de vous" +
    " recevoir à nouveau .\r\n";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuCustomLabel3.Image")));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(212, 220);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(101, 65);
            this.bunifuCustomLabel3.TabIndex = 58;
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // acceuilButton
            // 
            this.acceuilButton.Activecolor = System.Drawing.Color.Transparent;
            this.acceuilButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.acceuilButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.acceuilButton.BorderRadius = 5;
            this.acceuilButton.ButtonText = "     HOME";
            this.acceuilButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.acceuilButton, BunifuAnimatorNS.DecorationType.None);
            this.acceuilButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceuilButton.Iconcolor = System.Drawing.Color.Transparent;
            this.acceuilButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("acceuilButton.Iconimage")));
            this.acceuilButton.Iconimage_right = null;
            this.acceuilButton.Iconimage_right_Selected = null;
            this.acceuilButton.Iconimage_Selected = null;
            this.acceuilButton.IconZoom = 50D;
            this.acceuilButton.IsTab = false;
            this.acceuilButton.Location = new System.Drawing.Point(23, 369);
            this.acceuilButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.acceuilButton.Name = "acceuilButton";
            this.acceuilButton.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.acceuilButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.acceuilButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.acceuilButton.selected = false;
            this.acceuilButton.Size = new System.Drawing.Size(145, 51);
            this.acceuilButton.TabIndex = 27;
            this.acceuilButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.acceuilButton.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceuilButton.Click += new System.EventHandler(this.acceuilButton_Click);
            // 
            // fermerButton
            // 
            this.fermerButton.Activecolor = System.Drawing.Color.Transparent;
            this.fermerButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fermerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fermerButton.BorderRadius = 5;
            this.fermerButton.ButtonText = "         FERMER";
            this.fermerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.fermerButton, BunifuAnimatorNS.DecorationType.None);
            this.fermerButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermerButton.Iconcolor = System.Drawing.Color.Transparent;
            this.fermerButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("fermerButton.Iconimage")));
            this.fermerButton.Iconimage_right = null;
            this.fermerButton.Iconimage_right_Selected = null;
            this.fermerButton.Iconimage_Selected = null;
            this.fermerButton.IconZoom = 50D;
            this.fermerButton.IsTab = false;
            this.fermerButton.Location = new System.Drawing.Point(356, 369);
            this.fermerButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.fermerButton.Name = "fermerButton";
            this.fermerButton.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.fermerButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.fermerButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fermerButton.selected = false;
            this.fermerButton.Size = new System.Drawing.Size(153, 51);
            this.fermerButton.TabIndex = 26;
            this.fermerButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.fermerButton.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermerButton.Click += new System.EventHandler(this.fermerButton_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "     Quitter";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(530, 609);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(249, 60);
            this.bunifuFlatButton2.TabIndex = 1;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.BlanchedAlmond;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "     Login";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(35, 542);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(209, 59);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // animator1
            // 
            this.animator1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
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
            animation1.TransparencyCoeff = 1F;
            this.animator1.DefaultAnimation = animation1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 636);
            this.Controls.Add(this.Panel_Login);
            this.animator1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Panel_Login.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Eye_Closed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eye_Opend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel Panel_Login;
        private BunifuAnimatorNS.Animator animator1;
        private Bunifu.Framework.UI.BunifuGradientPanel loginPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label errorMsg;
        private Bunifu.Framework.UI.BunifuFlatButton Close_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox LogintextBox;
        private System.Windows.Forms.PictureBox Eye_Opend;
        private System.Windows.Forms.PictureBox Eye_Closed;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuFlatButton acceuilButton;
        private Bunifu.Framework.UI.BunifuFlatButton fermerButton;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        public Bunifu.Framework.UI.BunifuCustomLabel LabelBienvenue;
        public Bunifu.Framework.UI.BunifuCustomLabel message;
    }
}