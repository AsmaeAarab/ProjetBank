namespace Projet
{
    partial class principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdrAgence = new System.Windows.Forms.Label();
            this.nom_agence = new System.Windows.Forms.Label();
            this.telAgence = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.Ncompte = new System.Windows.Forms.Label();
            this.lblSolde = new System.Windows.Forms.Label();
            this.NomComplet = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.NomComplet);
            this.panel1.Controls.Add(this.lblTel);
            this.panel1.Location = new System.Drawing.Point(30, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 533);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Image = global::Projet.Properties.Resources.phone2;
            this.label4.Location = new System.Drawing.Point(105, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 26);
            this.label4.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.AdrAgence);
            this.groupBox2.Controls.Add(this.nom_agence);
            this.groupBox2.Controls.Add(this.telAgence);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(27, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 134);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agence";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Image = global::Projet.Properties.Resources.address_24px;
            this.label2.Location = new System.Drawing.Point(45, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 38);
            this.label2.TabIndex = 23;
            // 
            // AdrAgence
            // 
            this.AdrAgence.AutoSize = true;
            this.AdrAgence.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdrAgence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.AdrAgence.Location = new System.Drawing.Point(87, 98);
            this.AdrAgence.Name = "AdrAgence";
            this.AdrAgence.Size = new System.Drawing.Size(67, 20);
            this.AdrAgence.TabIndex = 22;
            this.AdrAgence.Text = "Adresse";
            // 
            // nom_agence
            // 
            this.nom_agence.AutoSize = true;
            this.nom_agence.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.nom_agence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.nom_agence.Location = new System.Drawing.Point(45, 36);
            this.nom_agence.Name = "nom_agence";
            this.nom_agence.Size = new System.Drawing.Size(113, 19);
            this.nom_agence.TabIndex = 21;
            this.nom_agence.Text = "Nom agence";
            // 
            // telAgence
            // 
            this.telAgence.AutoSize = true;
            this.telAgence.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.telAgence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.telAgence.Location = new System.Drawing.Point(87, 70);
            this.telAgence.Name = "telAgence";
            this.telAgence.Size = new System.Drawing.Size(27, 20);
            this.telAgence.TabIndex = 20;
            this.telAgence.Text = "Tel";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Image = global::Projet.Properties.Resources.phone2;
            this.label1.Location = new System.Drawing.Point(45, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 26);
            this.label1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.Ncompte);
            this.groupBox1.Controls.Add(this.lblSolde);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(27, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mes Comptes";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.lblName.Location = new System.Drawing.Point(55, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 19);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Nom complet1";
            // 
            // Ncompte
            // 
            this.Ncompte.AutoSize = true;
            this.Ncompte.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Ncompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.Ncompte.Location = new System.Drawing.Point(55, 65);
            this.Ncompte.Name = "Ncompte";
            this.Ncompte.Size = new System.Drawing.Size(102, 20);
            this.Ncompte.TabIndex = 20;
            this.Ncompte.Text = "NumCompte";
            // 
            // lblSolde
            // 
            this.lblSolde.AutoSize = true;
            this.lblSolde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolde.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSolde.Location = new System.Drawing.Point(445, 66);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new System.Drawing.Size(46, 18);
            this.lblSolde.TabIndex = 19;
            this.lblSolde.Text = "Solde";
            // 
            // NomComplet
            // 
            this.NomComplet.AutoSize = true;
            this.NomComplet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomComplet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.NomComplet.Location = new System.Drawing.Point(105, 44);
            this.NomComplet.Name = "NomComplet";
            this.NomComplet.Size = new System.Drawing.Size(116, 19);
            this.NomComplet.TabIndex = 14;
            this.NomComplet.Text = "Nom complet";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.lblTel.Location = new System.Drawing.Point(147, 75);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(43, 20);
            this.lblTel.TabIndex = 15;
            this.lblTel.Text = "lblTel";
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(836, 592);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "principal";
            this.Text = "principal";
            this.Load += new System.EventHandler(this.principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NomComplet;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label nom_agence;
        private System.Windows.Forms.Label telAgence;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label Ncompte;
        private System.Windows.Forms.Label lblSolde;
        private System.Windows.Forms.Label AdrAgence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}