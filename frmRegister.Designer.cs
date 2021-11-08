namespace Teoria_Grafurilor
{
    partial class frmRegister
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.pbHide = new System.Windows.Forms.PictureBox();
            this.pbShow = new System.Windows.Forms.PictureBox();
            this.tbParola = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(334, 359);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(160, 49);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Inregistrare";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pbHide
            // 
            this.pbHide.BackColor = System.Drawing.Color.White;
            this.pbHide.Image = global::Teoria_Grafurilor.Properties.Resources.show2___Copy;
            this.pbHide.Location = new System.Drawing.Point(560, 192);
            this.pbHide.Name = "pbHide";
            this.pbHide.Size = new System.Drawing.Size(38, 31);
            this.pbHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHide.TabIndex = 13;
            this.pbHide.TabStop = false;
            this.pbHide.Visible = false;
            this.pbHide.Click += new System.EventHandler(this.pbHide_Click);
            // 
            // pbShow
            // 
            this.pbShow.BackColor = System.Drawing.Color.White;
            this.pbShow.Image = global::Teoria_Grafurilor.Properties.Resources.shown;
            this.pbShow.Location = new System.Drawing.Point(560, 192);
            this.pbShow.Name = "pbShow";
            this.pbShow.Size = new System.Drawing.Size(38, 30);
            this.pbShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShow.TabIndex = 12;
            this.pbShow.TabStop = false;
            this.pbShow.Click += new System.EventHandler(this.pbShow_Click);
            // 
            // tbParola
            // 
            this.tbParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbParola.Location = new System.Drawing.Point(314, 193);
            this.tbParola.Name = "tbParola";
            this.tbParola.Size = new System.Drawing.Size(222, 30);
            this.tbParola.TabIndex = 11;
            this.tbParola.UseSystemPasswordChar = true;
            // 
            // tbNume
            // 
            this.tbNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNume.Location = new System.Drawing.Point(314, 115);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(222, 30);
            this.tbNume.TabIndex = 10;
            this.tbNume.TextChanged += new System.EventHandler(this.tbNume_TextChanged);
            // 
            // lblParola
            // 
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParola.ForeColor = System.Drawing.Color.White;
            this.lblParola.Location = new System.Drawing.Point(151, 185);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(138, 40);
            this.lblParola.TabIndex = 9;
            this.lblParola.Text = "Parola:";
            this.lblParola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNume
            // 
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.ForeColor = System.Drawing.Color.White;
            this.lblNume.Location = new System.Drawing.Point(151, 107);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(138, 40);
            this.lblNume.TabIndex = 8;
            this.lblNume.Text = " Nume:";
            this.lblNume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNume.Click += new System.EventHandler(this.lblNume_Click);
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMail.Location = new System.Drawing.Point(314, 257);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(222, 30);
            this.tbMail.TabIndex = 16;
            // 
            // lblMail
            // 
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(151, 249);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(138, 40);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "Mail:";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(795, 559);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pbHide);
            this.Controls.Add(this.pbShow);
            this.Controls.Add(this.tbParola);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblNume);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inregistrare";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRegister_FormClosed);
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox pbHide;
        private System.Windows.Forms.PictureBox pbShow;
        private System.Windows.Forms.TextBox tbParola;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lblMail;
    }
}