namespace Teoria_Grafurilor
{
    partial class frmDraw
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
            this.btnOrientat = new System.Windows.Forms.Button();
            this.btnNeorientat = new System.Windows.Forms.Button();
            this.btnHighlight = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.pbHelp = new System.Windows.Forms.PictureBox();
            this.btnSterge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrientat
            // 
            this.btnOrientat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrientat.Location = new System.Drawing.Point(1175, 22);
            this.btnOrientat.Name = "btnOrientat";
            this.btnOrientat.Size = new System.Drawing.Size(146, 53);
            this.btnOrientat.TabIndex = 0;
            this.btnOrientat.Text = "Orientat";
            this.btnOrientat.UseVisualStyleBackColor = true;
            this.btnOrientat.Click += new System.EventHandler(this.btnOrientat_Click);
            // 
            // btnNeorientat
            // 
            this.btnNeorientat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeorientat.Location = new System.Drawing.Point(1009, 22);
            this.btnNeorientat.Name = "btnNeorientat";
            this.btnNeorientat.Size = new System.Drawing.Size(146, 53);
            this.btnNeorientat.TabIndex = 1;
            this.btnNeorientat.Text = "Neorientat";
            this.btnNeorientat.UseVisualStyleBackColor = true;
            this.btnNeorientat.Click += new System.EventHandler(this.btnNeorientat_Click);
            // 
            // btnHighlight
            // 
            this.btnHighlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighlight.Location = new System.Drawing.Point(12, 12);
            this.btnHighlight.Name = "btnHighlight";
            this.btnHighlight.Size = new System.Drawing.Size(146, 53);
            this.btnHighlight.TabIndex = 2;
            this.btnHighlight.Text = "Highlight";
            this.btnHighlight.UseVisualStyleBackColor = true;
            this.btnHighlight.Click += new System.EventHandler(this.btnHighlight_Click);
            // 
            // pbHelp
            // 
            this.pbHelp.Image = global::Teoria_Grafurilor.Properties.Resources.help;
            this.pbHelp.Location = new System.Drawing.Point(696, 22);
            this.pbHelp.Name = "pbHelp";
            this.pbHelp.Size = new System.Drawing.Size(58, 53);
            this.pbHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHelp.TabIndex = 3;
            this.pbHelp.TabStop = false;
            this.pbHelp.Click += new System.EventHandler(this.pbHelp_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSterge.Location = new System.Drawing.Point(806, 22);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(146, 53);
            this.btnSterge.TabIndex = 8;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // frmDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1333, 837);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.pbHelp);
            this.Controls.Add(this.btnHighlight);
            this.Controls.Add(this.btnNeorientat);
            this.Controls.Add(this.btnOrientat);
            this.DoubleBuffered = true;
            this.Name = "frmDraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desenare";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDraw_FormClosed);
            this.Load += new System.EventHandler(this.frmDraw_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmDraw_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmDraw_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDraw_MouseDown);
            this.MouseHover += new System.EventHandler(this.frmDraw_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmDraw_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmDraw_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrientat;
        private System.Windows.Forms.Button btnNeorientat;
        private System.Windows.Forms.Button btnHighlight;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.PictureBox pbHelp;
        private System.Windows.Forms.Button btnSterge;
    }
}