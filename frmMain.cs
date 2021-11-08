///Copyright 2021 Dan-Ioan Haranguș
///All rights reserved
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teoria_Grafurilor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static frmLogin login;
        public static frmRegister register;
        public static frmAdmin admin;
        public static frmDraw draw;
        public static frmCuprins cuprins;
        public static frmTestGrila testGrila;
        public static frmEvalPrac evaluarePractica;

        private void lblLogin_Click(object sender, EventArgs e)
        {
            if(login == null)
            {
                login = new frmLogin();
                login.Tag = this;
                login.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "";
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            if(register == null)
            {
                register = new frmRegister();
                register.Tag = this;
                register.Show();
            }
        }

        private void lblDisconnect_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Sigur doriți să vă deconectați?", "Deconectare" ,MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                variabile.nume = "";
                lblWelcome.Text = "";
                variabile.tip = -1;
                lblDisconnect.Visible = false;
                lblDisconnect.Enabled = false;
                lblLogin.Visible = true;
                lblRegister.Visible = true;
                lblAdmin.Visible = false;
            }
            else
            {
                return;
            }
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            if(admin == null)
            {
                admin = new frmAdmin();
                admin.Tag = this;
                admin.Show();
            }
        }

        private void lblDraw_Click(object sender, EventArgs e)
        {
            if(draw == null)
            {
                draw = new frmDraw();
                draw.Show();
            }

        }

        private void lblLectii_Click(object sender, EventArgs e)
        {
            if(cuprins == null)
            {
                cuprins = new frmCuprins();
                cuprins.Show();
            }
        }
        public void drawEdge(Point n1, Point n2, Graphics g, Color clr, int diffx1, int diffy1, int diffx2, int diffy2)
        {
            Pen pen = new Pen(clr, 4);
            double vx = (n1.X - n2.X);
            double vy = (n1.Y - n2.Y);
            double ux = (vx) / (Math.Sqrt(vx * vx + vy * vy));
            double uy = (vy) / (Math.Sqrt(vx * vx + vy * vy));  
            float xf1 = (float)(n1.X - diffx1 * ux);
            float xf2 = (float)(n2.X + diffx2 * ux);
            float yf1 = (float)(n1.Y - diffy1 * uy);
            float yf2 = (float)(n2.Y + diffy2 * uy);
            g.DrawLine(pen, xf1, yf1, xf2, yf2);

        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen pen = new Pen(Color.White, 5);
            Rectangle rect1 = new Rectangle(lblLectii.Location.X - 50, lblLectii.Location.Y - 77, 190, 190);
            e.Graphics.DrawEllipse(pen, rect1);

            Rectangle rect2 = new Rectangle(lblDraw.Location.X - 8, lblDraw.Location.Y - 77, 190, 190);
            e.Graphics.DrawEllipse(pen, rect2);

            if (variabile.tip == -1)
            {
                Rectangle rect3 = new Rectangle(lblLogin.Location.X - 25, lblLogin.Location.Y - 77, 190, 190);
                e.Graphics.DrawEllipse(pen, rect3);
                drawEdge(lblLogin.Location, lblRegister.Location, e.Graphics, Color.White, 170, 77, 20, 77);
                Rectangle rect4 = new Rectangle(lblRegister.Location.X - 24, lblRegister.Location.Y - 77, 190, 190);
                e.Graphics.DrawEllipse(pen, rect4);
            }
            else
            {
                Rectangle rect5 = new Rectangle(lblDisconnect.Location.X - 18, lblDisconnect.Location.Y - 77, 190, 190);
                e.Graphics.DrawEllipse(pen, rect5);
            }

            Rectangle rect6 = new Rectangle(lblTestGrila.Location.X - 30, lblTestGrila.Location.Y - 77, 190, 190);
            e.Graphics.DrawEllipse(pen, rect6);

            Rectangle rect7 = new Rectangle(lblEvaluarePractica.Location.X - 20, lblEvaluarePractica.Location.Y - 70, 190, 190);
            e.Graphics.DrawEllipse(pen, rect7);

            drawEdge(lblTestGrila.Location, lblLectii.Location, e.Graphics, Color.White, 30, 77, 136, 77);
            drawEdge(lblEvaluarePractica.Location, lblLectii.Location, e.Graphics, Color.White, 700, 70, -400, 112);


        }

        private void lblDisconnect_EnabledChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void lblTestGrila_Click(object sender, EventArgs e)
        {
            if(testGrila == null)
            {
                testGrila = new frmTestGrila();
                testGrila.Show();
            }
        }

        private void lblEvaluarePractica_Click(object sender, EventArgs e)
        {
            if(evaluarePractica == null)
            {
                evaluarePractica = new frmEvalPrac();
                evaluarePractica.Show();
            }
        }
    }
}
