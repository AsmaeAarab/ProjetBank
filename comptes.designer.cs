namespace Projet
{
    partial class comptes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(comptes));
            this.panel_histo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Ncompte = new System.Windows.Forms.Label();
            this.solde = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.compteN = new System.Windows.Forms.Label();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.panel_histo.SuspendLayout();
            this.panel_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_histo
            // 
            this.panel_histo.AutoScroll = true;
            this.panel_histo.Controls.Add(this.label5);
            this.panel_histo.Location = new System.Drawing.Point(35, 127);
            this.panel_histo.Name = "panel_histo";
            this.panel_histo.Size = new System.Drawing.Size(550, 293);
            this.panel_histo.TabIndex = 0;
            this.panel_histo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_histo_Paint);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(550, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Opérations";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Ncompte
            // 
            this.Ncompte.AutoSize = true;
            this.Ncompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ncompte.ForeColor = System.Drawing.Color.Purple;
            this.Ncompte.Location = new System.Drawing.Point(193, 28);
            this.Ncompte.Name = "Ncompte";
            this.Ncompte.Size = new System.Drawing.Size(0, 18);
            this.Ncompte.TabIndex = 5;
            // 
            // solde
            // 
            this.solde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.solde.Location = new System.Drawing.Point(212, 67);
            this.solde.Name = "solde";
            this.solde.Size = new System.Drawing.Size(99, 27);
            this.solde.TabIndex = 6;
            this.solde.Text = "solde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "N° Compte :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.label7.Location = new System.Drawing.Point(35, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Solde actualisé :";
            // 
            // compteN
            // 
            this.compteN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compteN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.compteN.Location = new System.Drawing.Point(212, 19);
            this.compteN.Name = "compteN";
            this.compteN.Size = new System.Drawing.Size(99, 27);
            this.compteN.TabIndex = 12;
            this.compteN.Text = "compteN";
            // 
            // panel_principal
            // 
            this.panel_principal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_principal.BackColor = System.Drawing.Color.Thistle;
            this.panel_principal.Controls.Add(this.Ncompte);
            this.panel_principal.Controls.Add(this.compteN);
            this.panel_principal.Controls.Add(this.panel_histo);
            this.panel_principal.Controls.Add(this.solde);
            this.panel_principal.Controls.Add(this.label7);
            this.panel_principal.Controls.Add(this.label1);
            this.panel_principal.Location = new System.Drawing.Point(29, 74);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(791, 533);
            this.panel_principal.TabIndex = 1;
            this.panel_principal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_principal_Paint);
            // 
            // comptes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(852, 631);
            this.Controls.Add(this.panel_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "comptes";
            this.Text = "comptes";
            this.Load += new System.EventHandler(this.comptes_Load);
            this.panel_histo.ResumeLayout(false);
            this.panel_principal.ResumeLayout(false);
            this.panel_principal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_histo;
        private System.Windows.Forms.Label Ncompte;
        private System.Windows.Forms.Label solde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label compteN;
        private System.Windows.Forms.Panel panel_principal;
    }
}