namespace Teoria_Grafurilor
{
    partial class frmCuprins
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
            this.pnlLectii = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlLectii
            // 
            this.pnlLectii.AutoScroll = true;
            this.pnlLectii.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLectii.Location = new System.Drawing.Point(12, 12);
            this.pnlLectii.Name = "pnlLectii";
            this.pnlLectii.Size = new System.Drawing.Size(1079, 684);
            this.pnlLectii.TabIndex = 9;
            // 
            // frmCuprins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1103, 698);
            this.Controls.Add(this.pnlLectii);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCuprins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuprins";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCuprins_FormClosed);
            this.Load += new System.EventHandler(this.frmCuprins_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLectii;
    }
}