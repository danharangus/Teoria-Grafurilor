namespace Teoria_Grafurilor
{
    partial class frmAdaugaLectie
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
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblContinut = new System.Windows.Forms.Label();
            this.tbTitlu = new System.Windows.Forms.TextBox();
            this.tbContinut = new System.Windows.Forms.TextBox();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.lblImagine = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.btnIncarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.Color.White;
            this.lblTitlu.Location = new System.Drawing.Point(113, 37);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(86, 36);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Titlu:";
            // 
            // lblContinut
            // 
            this.lblContinut.AutoSize = true;
            this.lblContinut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinut.ForeColor = System.Drawing.Color.White;
            this.lblContinut.Location = new System.Drawing.Point(24, 160);
            this.lblContinut.Name = "lblContinut";
            this.lblContinut.Size = new System.Drawing.Size(144, 36);
            this.lblContinut.TabIndex = 1;
            this.lblContinut.Text = "Continut:";
            // 
            // tbTitlu
            // 
            this.tbTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitlu.Location = new System.Drawing.Point(205, 43);
            this.tbTitlu.Name = "tbTitlu";
            this.tbTitlu.Size = new System.Drawing.Size(573, 30);
            this.tbTitlu.TabIndex = 2;
            // 
            // tbContinut
            // 
            this.tbContinut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContinut.Location = new System.Drawing.Point(185, 166);
            this.tbContinut.Multiline = true;
            this.tbContinut.Name = "tbContinut";
            this.tbContinut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbContinut.Size = new System.Drawing.Size(562, 443);
            this.tbContinut.TabIndex = 3;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.Location = new System.Drawing.Point(625, 702);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(143, 62);
            this.btnAdaugare.TabIndex = 4;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // lblImagine
            // 
            this.lblImagine.AutoSize = true;
            this.lblImagine.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagine.ForeColor = System.Drawing.Color.White;
            this.lblImagine.Location = new System.Drawing.Point(790, 166);
            this.lblImagine.Name = "lblImagine";
            this.lblImagine.Size = new System.Drawing.Size(135, 36);
            this.lblImagine.TabIndex = 5;
            this.lblImagine.Text = "Imagine:";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(942, 177);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(324, 293);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 6;
            this.pb1.TabStop = false;
            // 
            // btnIncarca
            // 
            this.btnIncarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncarca.Location = new System.Drawing.Point(1135, 498);
            this.btnIncarca.Name = "btnIncarca";
            this.btnIncarca.Size = new System.Drawing.Size(131, 60);
            this.btnIncarca.TabIndex = 7;
            this.btnIncarca.Text = "Incarca";
            this.btnIncarca.UseVisualStyleBackColor = true;
            this.btnIncarca.Click += new System.EventHandler(this.btnIncarca_Click);
            // 
            // frmAdaugaLectie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1334, 776);
            this.Controls.Add(this.btnIncarca);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lblImagine);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.tbContinut);
            this.Controls.Add(this.tbTitlu);
            this.Controls.Add(this.lblContinut);
            this.Controls.Add(this.lblTitlu);
            this.Name = "frmAdaugaLectie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adaugare Lectie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdaugaLectie_FormClosed);
            this.Load += new System.EventHandler(this.frmAdaugaLectie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblContinut;
        private System.Windows.Forms.TextBox tbTitlu;
        private System.Windows.Forms.TextBox tbContinut;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Label lblImagine;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Button btnIncarca;
    }
}