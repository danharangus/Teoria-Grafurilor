namespace Teoria_Grafurilor
{
    partial class frmMain
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblDisconnect = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            this.lblLectii = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblTestGrila = new System.Windows.Forms.Label();
            this.lblEvaluarePractica = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(64, 21);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 36);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(549, 613);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(201, 40);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Conectare";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(1045, 694);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(201, 40);
            this.lblRegister.TabIndex = 4;
            this.lblRegister.Text = "Inregistrare";
            this.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // lblDisconnect
            // 
            this.lblDisconnect.AutoSize = true;
            this.lblDisconnect.BackColor = System.Drawing.Color.Transparent;
            this.lblDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisconnect.ForeColor = System.Drawing.Color.White;
            this.lblDisconnect.Location = new System.Drawing.Point(797, 668);
            this.lblDisconnect.Name = "lblDisconnect";
            this.lblDisconnect.Size = new System.Drawing.Size(193, 36);
            this.lblDisconnect.TabIndex = 5;
            this.lblDisconnect.Text = "Deconectare";
            this.lblDisconnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDisconnect.Visible = false;
            this.lblDisconnect.EnabledChanged += new System.EventHandler(this.lblDisconnect_EnabledChanged);
            this.lblDisconnect.Click += new System.EventHandler(this.lblDisconnect_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(1315, 21);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(194, 36);
            this.lblAdmin.TabIndex = 6;
            this.lblAdmin.Text = "Administrare";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdmin.Visible = false;
            this.lblAdmin.Click += new System.EventHandler(this.lblAdmin_Click);
            // 
            // lblDraw
            // 
            this.lblDraw.BackColor = System.Drawing.Color.Transparent;
            this.lblDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraw.ForeColor = System.Drawing.Color.White;
            this.lblDraw.Location = new System.Drawing.Point(1214, 355);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(237, 83);
            this.lblDraw.TabIndex = 7;
            this.lblDraw.Text = "Desenare graf\r\n";
            this.lblDraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDraw.Click += new System.EventHandler(this.lblDraw_Click);
            // 
            // lblLectii
            // 
            this.lblLectii.AutoSize = true;
            this.lblLectii.BackColor = System.Drawing.Color.Transparent;
            this.lblLectii.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectii.ForeColor = System.Drawing.Color.White;
            this.lblLectii.Location = new System.Drawing.Point(132, 287);
            this.lblLectii.Name = "lblLectii";
            this.lblLectii.Size = new System.Drawing.Size(91, 36);
            this.lblLectii.TabIndex = 8;
            this.lblLectii.Text = "Lectii";
            this.lblLectii.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLectii.Click += new System.EventHandler(this.lblLectii_Click);
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.BackColor = System.Drawing.Color.Transparent;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.Color.White;
            this.lblTitlu.Location = new System.Drawing.Point(455, 67);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(633, 91);
            this.lblTitlu.TabIndex = 9;
            this.lblTitlu.Text = "Teoria Grafurilor";
            this.lblTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTestGrila
            // 
            this.lblTestGrila.AutoSize = true;
            this.lblTestGrila.BackColor = System.Drawing.Color.Transparent;
            this.lblTestGrila.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestGrila.ForeColor = System.Drawing.Color.White;
            this.lblTestGrila.Location = new System.Drawing.Point(750, 287);
            this.lblTestGrila.Name = "lblTestGrila";
            this.lblTestGrila.Size = new System.Drawing.Size(147, 36);
            this.lblTestGrila.TabIndex = 10;
            this.lblTestGrila.Text = "Test grila";
            this.lblTestGrila.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTestGrila.Click += new System.EventHandler(this.lblTestGrila_Click);
            // 
            // lblEvaluarePractica
            // 
            this.lblEvaluarePractica.AutoSize = true;
            this.lblEvaluarePractica.BackColor = System.Drawing.Color.Transparent;
            this.lblEvaluarePractica.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvaluarePractica.ForeColor = System.Drawing.Color.White;
            this.lblEvaluarePractica.Location = new System.Drawing.Point(95, 658);
            this.lblEvaluarePractica.Name = "lblEvaluarePractica";
            this.lblEvaluarePractica.Size = new System.Drawing.Size(172, 72);
            this.lblEvaluarePractica.TabIndex = 11;
            this.lblEvaluarePractica.Text = "Evaluare \r\n     practica";
            this.lblEvaluarePractica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEvaluarePractica.Click += new System.EventHandler(this.lblEvaluarePractica_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Teoria_Grafurilor.Properties.Resources.wp7752176;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1567, 955);
            this.Controls.Add(this.lblEvaluarePractica);
            this.Controls.Add(this.lblTestGrila);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblLectii);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblDisconnect);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblWelcome;
        public System.Windows.Forms.Label lblLogin;
        public System.Windows.Forms.Label lblRegister;
        public System.Windows.Forms.Label lblDisconnect;
        public System.Windows.Forms.Label lblAdmin;
        public System.Windows.Forms.Label lblDraw;
        public System.Windows.Forms.Label lblLectii;
        public System.Windows.Forms.Label lblTitlu;
        public System.Windows.Forms.Label lblTestGrila;
        public System.Windows.Forms.Label lblEvaluarePractica;
    }
}

