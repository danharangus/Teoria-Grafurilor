namespace Teoria_Grafurilor
{
    partial class frmLectie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLectie));
            this.lblTitlu = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbDel = new System.Windows.Forms.PictureBox();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.pbPrev = new System.Windows.Forms.PictureBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.Color.White;
            this.lblTitlu.Location = new System.Drawing.Point(121, 68);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(128, 44);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "label1";
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(583, 165);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.ReadOnly = true;
            this.tb1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb1.Size = new System.Drawing.Size(742, 595);
            this.tb1.TabIndex = 1;
            // 
            // pbAdd
            // 
            this.pbAdd.BackColor = System.Drawing.Color.White;
            this.pbAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAdd.BackgroundImage")));
            this.pbAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAdd.Location = new System.Drawing.Point(435, 242);
            this.pbAdd.Margin = new System.Windows.Forms.Padding(4);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(36, 31);
            this.pbAdd.TabIndex = 13;
            this.pbAdd.TabStop = false;
            this.pbAdd.Visible = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbDel
            // 
            this.pbDel.BackColor = System.Drawing.Color.White;
            this.pbDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbDel.BackgroundImage")));
            this.pbDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDel.Location = new System.Drawing.Point(89, 242);
            this.pbDel.Margin = new System.Windows.Forms.Padding(4);
            this.pbDel.Name = "pbDel";
            this.pbDel.Size = new System.Drawing.Size(36, 31);
            this.pbDel.TabIndex = 12;
            this.pbDel.TabStop = false;
            this.pbDel.Visible = false;
            this.pbDel.Click += new System.EventHandler(this.pbDel_Click);
            // 
            // pbImg
            // 
            this.pbImg.BackColor = System.Drawing.Color.Transparent;
            this.pbImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImg.Image = global::Teoria_Grafurilor.Properties.Resources.noimage;
            this.pbImg.Location = new System.Drawing.Point(88, 280);
            this.pbImg.Margin = new System.Windows.Forms.Padding(4);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(383, 257);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 8;
            this.pbImg.TabStop = false;
            // 
            // lblDesc
            // 
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesc.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.White;
            this.lblDesc.Location = new System.Drawing.Point(84, 567);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(383, 38);
            this.lblDesc.TabIndex = 9;
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPrev
            // 
            this.pbPrev.BackColor = System.Drawing.Color.Transparent;
            this.pbPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPrev.BackgroundImage")));
            this.pbPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPrev.Location = new System.Drawing.Point(84, 609);
            this.pbPrev.Margin = new System.Windows.Forms.Padding(4);
            this.pbPrev.Name = "pbPrev";
            this.pbPrev.Size = new System.Drawing.Size(49, 33);
            this.pbPrev.TabIndex = 10;
            this.pbPrev.TabStop = false;
            this.pbPrev.Click += new System.EventHandler(this.pbPrev_Click);
            // 
            // pbNext
            // 
            this.pbNext.BackColor = System.Drawing.Color.Transparent;
            this.pbNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbNext.BackgroundImage")));
            this.pbNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbNext.Location = new System.Drawing.Point(421, 609);
            this.pbNext.Margin = new System.Windows.Forms.Padding(4);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(45, 33);
            this.pbNext.TabIndex = 11;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // frmLectie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Teoria_Grafurilor.Properties.Resources.wp7752176;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1432, 772);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.pbDel);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.pbPrev);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lblTitlu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLectie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLectie_FormClosed);
            this.Load += new System.EventHandler(this.frmLectie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitlu;
        public System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pbDel;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.PictureBox pbPrev;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}