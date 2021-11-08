namespace Teoria_Grafurilor
{
    partial class frmAdmin
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
            this.pnlConturi = new System.Windows.Forms.Panel();
            this.lb = new System.Windows.Forms.ListBox();
            this.lblTip2 = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.btnElev = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.pnlLectii = new System.Windows.Forms.Panel();
            this.listBoxLectii = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdaugareLectie = new System.Windows.Forms.Button();
            this.btnStergereLectie = new System.Windows.Forms.Button();
            this.btnConturi = new System.Windows.Forms.Button();
            this.btnLectii = new System.Windows.Forms.Button();
            this.pnlIntrebari = new System.Windows.Forms.Panel();
            this.listBoxIntrebari = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdaugaIntrebare = new System.Windows.Forms.Button();
            this.btnStergeIntrebare = new System.Windows.Forms.Button();
            this.btnIntrebari = new System.Windows.Forms.Button();
            this.pnlConturi.SuspendLayout();
            this.pnlLectii.SuspendLayout();
            this.pnlIntrebari.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConturi
            // 
            this.pnlConturi.Controls.Add(this.lb);
            this.pnlConturi.Controls.Add(this.lblTip2);
            this.pnlConturi.Controls.Add(this.lblTip);
            this.pnlConturi.Controls.Add(this.btnElev);
            this.pnlConturi.Controls.Add(this.btnAdmin);
            this.pnlConturi.Location = new System.Drawing.Point(1213, 693);
            this.pnlConturi.Name = "pnlConturi";
            this.pnlConturi.Size = new System.Drawing.Size(1093, 582);
            this.pnlConturi.TabIndex = 0;
            this.pnlConturi.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlConturi_Paint);
            // 
            // lb
            // 
            this.lb.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.FormattingEnabled = true;
            this.lb.HorizontalScrollbar = true;
            this.lb.ItemHeight = 29;
            this.lb.Location = new System.Drawing.Point(13, 11);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(362, 555);
            this.lb.TabIndex = 5;
            this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
            // 
            // lblTip2
            // 
            this.lblTip2.AutoSize = true;
            this.lblTip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip2.ForeColor = System.Drawing.Color.White;
            this.lblTip2.Location = new System.Drawing.Point(476, 187);
            this.lblTip2.Name = "lblTip2";
            this.lblTip2.Size = new System.Drawing.Size(0, 32);
            this.lblTip2.TabIndex = 4;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.ForeColor = System.Drawing.Color.White;
            this.lblTip.Location = new System.Drawing.Point(403, 187);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(67, 32);
            this.lblTip.TabIndex = 3;
            this.lblTip.Text = "Tip:";
            // 
            // btnElev
            // 
            this.btnElev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElev.Location = new System.Drawing.Point(681, 282);
            this.btnElev.Name = "btnElev";
            this.btnElev.Size = new System.Drawing.Size(154, 62);
            this.btnElev.TabIndex = 2;
            this.btnElev.Text = "Elev";
            this.btnElev.UseVisualStyleBackColor = true;
            this.btnElev.Click += new System.EventHandler(this.btnElev_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.AutoSize = true;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(395, 282);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(154, 62);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Administrator";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // pnlLectii
            // 
            this.pnlLectii.Controls.Add(this.listBoxLectii);
            this.pnlLectii.Controls.Add(this.label1);
            this.pnlLectii.Controls.Add(this.btnAdaugareLectie);
            this.pnlLectii.Controls.Add(this.btnStergereLectie);
            this.pnlLectii.Location = new System.Drawing.Point(70, 86);
            this.pnlLectii.Name = "pnlLectii";
            this.pnlLectii.Size = new System.Drawing.Size(1093, 582);
            this.pnlLectii.TabIndex = 1;
            // 
            // listBoxLectii
            // 
            this.listBoxLectii.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLectii.FormattingEnabled = true;
            this.listBoxLectii.HorizontalScrollbar = true;
            this.listBoxLectii.ItemHeight = 29;
            this.listBoxLectii.Location = new System.Drawing.Point(13, 11);
            this.listBoxLectii.Name = "listBoxLectii";
            this.listBoxLectii.ScrollAlwaysVisible = true;
            this.listBoxLectii.Size = new System.Drawing.Size(812, 526);
            this.listBoxLectii.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 4;
            // 
            // btnAdaugareLectie
            // 
            this.btnAdaugareLectie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugareLectie.Location = new System.Drawing.Point(855, 115);
            this.btnAdaugareLectie.Name = "btnAdaugareLectie";
            this.btnAdaugareLectie.Size = new System.Drawing.Size(178, 62);
            this.btnAdaugareLectie.TabIndex = 2;
            this.btnAdaugareLectie.Text = "Adaugare lectie";
            this.btnAdaugareLectie.UseVisualStyleBackColor = true;
            this.btnAdaugareLectie.Click += new System.EventHandler(this.btnAdaugareLectie_Click);
            // 
            // btnStergereLectie
            // 
            this.btnStergereLectie.AutoSize = true;
            this.btnStergereLectie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergereLectie.Location = new System.Drawing.Point(855, 269);
            this.btnStergereLectie.Name = "btnStergereLectie";
            this.btnStergereLectie.Size = new System.Drawing.Size(162, 62);
            this.btnStergereLectie.TabIndex = 1;
            this.btnStergereLectie.Text = "Stergere";
            this.btnStergereLectie.UseVisualStyleBackColor = true;
            this.btnStergereLectie.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnConturi
            // 
            this.btnConturi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConturi.Location = new System.Drawing.Point(70, 12);
            this.btnConturi.Name = "btnConturi";
            this.btnConturi.Size = new System.Drawing.Size(178, 62);
            this.btnConturi.TabIndex = 6;
            this.btnConturi.Text = "Conturi";
            this.btnConturi.UseVisualStyleBackColor = true;
            this.btnConturi.Click += new System.EventHandler(this.btnConturi_Click);
            // 
            // btnLectii
            // 
            this.btnLectii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLectii.Location = new System.Drawing.Point(267, 12);
            this.btnLectii.Name = "btnLectii";
            this.btnLectii.Size = new System.Drawing.Size(178, 62);
            this.btnLectii.TabIndex = 7;
            this.btnLectii.Text = "Lectii";
            this.btnLectii.UseVisualStyleBackColor = true;
            this.btnLectii.Click += new System.EventHandler(this.btnLectii_Click);
            // 
            // pnlIntrebari
            // 
            this.pnlIntrebari.Controls.Add(this.listBoxIntrebari);
            this.pnlIntrebari.Controls.Add(this.label2);
            this.pnlIntrebari.Controls.Add(this.btnAdaugaIntrebare);
            this.pnlIntrebari.Controls.Add(this.btnStergeIntrebare);
            this.pnlIntrebari.Location = new System.Drawing.Point(38, 86);
            this.pnlIntrebari.Name = "pnlIntrebari";
            this.pnlIntrebari.Size = new System.Drawing.Size(1093, 582);
            this.pnlIntrebari.TabIndex = 6;
            this.pnlIntrebari.Visible = false;
            this.pnlIntrebari.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlIntrebari_Paint);
            // 
            // listBoxIntrebari
            // 
            this.listBoxIntrebari.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxIntrebari.FormattingEnabled = true;
            this.listBoxIntrebari.HorizontalScrollbar = true;
            this.listBoxIntrebari.ItemHeight = 25;
            this.listBoxIntrebari.Location = new System.Drawing.Point(16, 11);
            this.listBoxIntrebari.Name = "listBoxIntrebari";
            this.listBoxIntrebari.Size = new System.Drawing.Size(812, 554);
            this.listBoxIntrebari.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(476, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 4;
            // 
            // btnAdaugaIntrebare
            // 
            this.btnAdaugaIntrebare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaIntrebare.Location = new System.Drawing.Point(855, 115);
            this.btnAdaugaIntrebare.Name = "btnAdaugaIntrebare";
            this.btnAdaugaIntrebare.Size = new System.Drawing.Size(178, 62);
            this.btnAdaugaIntrebare.TabIndex = 2;
            this.btnAdaugaIntrebare.Text = "Adaugare intrebare";
            this.btnAdaugaIntrebare.UseVisualStyleBackColor = true;
            this.btnAdaugaIntrebare.Click += new System.EventHandler(this.btnAdaugaIntrebare_Click);
            // 
            // btnStergeIntrebare
            // 
            this.btnStergeIntrebare.AutoSize = true;
            this.btnStergeIntrebare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergeIntrebare.Location = new System.Drawing.Point(855, 269);
            this.btnStergeIntrebare.Name = "btnStergeIntrebare";
            this.btnStergeIntrebare.Size = new System.Drawing.Size(162, 62);
            this.btnStergeIntrebare.TabIndex = 1;
            this.btnStergeIntrebare.Text = "Stergere";
            this.btnStergeIntrebare.UseVisualStyleBackColor = true;
            this.btnStergeIntrebare.Click += new System.EventHandler(this.btnStergeIntrebare_Click);
            // 
            // btnIntrebari
            // 
            this.btnIntrebari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntrebari.Location = new System.Drawing.Point(466, 12);
            this.btnIntrebari.Name = "btnIntrebari";
            this.btnIntrebari.Size = new System.Drawing.Size(178, 62);
            this.btnIntrebari.TabIndex = 8;
            this.btnIntrebari.Text = "Intrebari";
            this.btnIntrebari.UseVisualStyleBackColor = true;
            this.btnIntrebari.Click += new System.EventHandler(this.btnIntrebari_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1235, 709);
            this.Controls.Add(this.btnIntrebari);
            this.Controls.Add(this.pnlIntrebari);
            this.Controls.Add(this.btnLectii);
            this.Controls.Add(this.btnConturi);
            this.Controls.Add(this.pnlLectii);
            this.Controls.Add(this.pnlConturi);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrare";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdmin_FormClosed);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.pnlConturi.ResumeLayout(false);
            this.pnlConturi.PerformLayout();
            this.pnlLectii.ResumeLayout(false);
            this.pnlLectii.PerformLayout();
            this.pnlIntrebari.ResumeLayout(false);
            this.pnlIntrebari.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConturi;
        private System.Windows.Forms.Button btnElev;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lblTip2;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Panel pnlLectii;
        public System.Windows.Forms.ListBox listBoxLectii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdaugareLectie;
        private System.Windows.Forms.Button btnStergereLectie;
        private System.Windows.Forms.Button btnConturi;
        private System.Windows.Forms.Button btnLectii;
        private System.Windows.Forms.Panel pnlIntrebari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdaugaIntrebare;
        private System.Windows.Forms.Button btnStergeIntrebare;
        private System.Windows.Forms.Button btnIntrebari;
        public System.Windows.Forms.ListBox listBoxIntrebari;
    }
}