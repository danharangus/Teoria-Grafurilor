namespace Teoria_Grafurilor
{
    partial class frmAddImage
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
            this.btnIncarca = new System.Windows.Forms.Button();
            this.tbDescriere = new System.Windows.Forms.TextBox();
            this.lblDescriere = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncarca
            // 
            this.btnIncarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncarca.Location = new System.Drawing.Point(1051, 388);
            this.btnIncarca.Name = "btnIncarca";
            this.btnIncarca.Size = new System.Drawing.Size(131, 60);
            this.btnIncarca.TabIndex = 10;
            this.btnIncarca.Text = "Incarca";
            this.btnIncarca.UseVisualStyleBackColor = true;
            this.btnIncarca.Click += new System.EventHandler(this.btnIncarca_Click);
            // 
            // tbDescriere
            // 
            this.tbDescriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescriere.Location = new System.Drawing.Point(283, 248);
            this.tbDescriere.Name = "tbDescriere";
            this.tbDescriere.Size = new System.Drawing.Size(573, 30);
            this.tbDescriere.TabIndex = 12;
            // 
            // lblDescriere
            // 
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriere.ForeColor = System.Drawing.Color.White;
            this.lblDescriere.Location = new System.Drawing.Point(101, 242);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(159, 36);
            this.lblDescriere.TabIndex = 11;
            this.lblDescriere.Text = "Descriere:";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(659, 496);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(131, 60);
            this.btnAdauga.TabIndex = 13;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(925, 78);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(324, 293);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 9;
            this.pb1.TabStop = false;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // frmAddImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1340, 591);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.tbDescriere);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(this.btnIncarca);
            this.Controls.Add(this.pb1);
            this.Name = "frmAddImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adaugare Imagine";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddImage_FormClosed);
            this.Load += new System.EventHandler(this.frmAddImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncarca;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.TextBox tbDescriere;
        private System.Windows.Forms.Label lblDescriere;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}