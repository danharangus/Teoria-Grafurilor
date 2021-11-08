namespace Teoria_Grafurilor
{
    partial class frmLogin
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
            this.lblNume = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbParola = new System.Windows.Forms.TextBox();
            this.pbHide = new System.Windows.Forms.PictureBox();
            this.pbShow = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(80, 154);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(138, 40);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = " Nume:";
            this.lblNume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblParola
            // 
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParola.Location = new System.Drawing.Point(80, 232);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(138, 40);
            this.lblParola.TabIndex = 2;
            this.lblParola.Text = "Parola:";
            this.lblParola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNume
            // 
            this.tbNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNume.Location = new System.Drawing.Point(243, 162);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(222, 30);
            this.tbNume.TabIndex = 3;
            // 
            // tbParola
            // 
            this.tbParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbParola.Location = new System.Drawing.Point(243, 240);
            this.tbParola.Name = "tbParola";
            this.tbParola.Size = new System.Drawing.Size(222, 30);
            this.tbParola.TabIndex = 4;
            this.tbParola.UseSystemPasswordChar = true;
            // 
            // pbHide
            // 
            this.pbHide.BackColor = System.Drawing.Color.White;
            this.pbHide.Image = global::Teoria_Grafurilor.Properties.Resources.show2___Copy;
            this.pbHide.Location = new System.Drawing.Point(490, 239);
            this.pbHide.Name = "pbHide";
            this.pbHide.Size = new System.Drawing.Size(41, 33);
            this.pbHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHide.TabIndex = 6;
            this.pbHide.TabStop = false;
            this.pbHide.Visible = false;
            this.pbHide.Click += new System.EventHandler(this.pbHide_Click);
            // 
            // pbShow
            // 
            this.pbShow.BackColor = System.Drawing.Color.White;
            this.pbShow.Image = global::Teoria_Grafurilor.Properties.Resources.shown;
            this.pbShow.Location = new System.Drawing.Point(490, 239);
            this.pbShow.Name = "pbShow";
            this.pbShow.Size = new System.Drawing.Size(41, 33);
            this.pbShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShow.TabIndex = 5;
            this.pbShow.TabStop = false;
            this.pbShow.Click += new System.EventHandler(this.pbShow_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(261, 358);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(144, 49);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Conectare";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(773, 547);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pbHide);
            this.Controls.Add(this.pbShow);
            this.Controls.Add(this.tbParola);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblNume);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Conectare";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbParola;
        private System.Windows.Forms.PictureBox pbShow;
        private System.Windows.Forms.PictureBox pbHide;
        private System.Windows.Forms.Button btnLogin;
    }
}