using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teoria_Grafurilor
{
    public partial class frmCuprins : Form
    {
        public frmCuprins()
        {
            InitializeComponent();
        }

        public string[] titlu = new string[1000];
        public string[] continut = new string[1000];
        int cntLectii;
        int lwCount = 0;

        public static frmLectie lectie;

        class LessonView
        {
            public Panel pnl;
            PictureBox pb;
            Label lblTitlu;
            Label lblContinut;
            string continut;

            public LessonView(Panel pnlLec, Point pos, int width, int height, string location, string titlu, string content)
            {
                pnl = new Panel();
                pnl.BackColor = Color.White;
                pnl.Width = width;
                pnl.Height = height;
                pnl.Location = pos;
                pnl.BackColor = Color.White;


                pb = new PictureBox();
                pb.Location = new Point(10, 10);
                pb.Width = 9 * height / 10;
                pb.Height = 8 * height / 10;
                pb.ImageLocation = location;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;


                lblTitlu = new Label();
                lblTitlu.Text = titlu;
                lblTitlu.AutoSize = true;

                int size = 23;

                if (titlu.Length > 46)
                {
                    size = 11;
                }
                else if (titlu.Length > 40)
                {
                    size = 13;
                }
                else if (titlu.Length > 35)
                {
                    size = 16;
                }
                else if (titlu.Length > 28)
                {
                    size = 18;
                }

                Font font = new Font(FontFamily.GenericMonospace, size, FontStyle.Bold);
                lblTitlu.Font = font;
                lblTitlu.Location = new Point(2 * width / 10, 4 * height / 10);


                pnl.Controls.Add(lblTitlu);
                pnl.Controls.Add(pb);

                pnlLec.Controls.Add(pnl);

                continut = content;

                pnl.Click += (object sender, EventArgs e) =>
                {
                    if (lectie == null)
                    {
                        lectie = new frmLectie();
                        lectie.Text = titlu;
                        lectie.lblTitlu.Text = titlu;
                        lectie.tb1.Text = continut;
                        lectie.tb1.ReadOnly = true;
                        lectie.Show();
                    }
                };

                lblTitlu.Click += (object sender, EventArgs e) =>
                {
                    if (lectie == null)
                    {
                        lectie = new frmLectie();
                        lectie.Text = titlu;
                        lectie.lblTitlu.Text = titlu;
                        lectie.tb1.Text = continut;
                        lectie.tb1.ReadOnly = true;
                        lectie.Show();
                    }
                };

                pb.Click += (object sender, EventArgs e) =>
                {
                    if (lectie == null)
                    {
                        lectie = new frmLectie();
                        lectie.Text = titlu;
                        lectie.lblTitlu.Text = titlu;
                        lectie.tb1.Text = continut;
                        lectie.tb1.ReadOnly = true;
                        lectie.Show();
                    }
                };

                pnl.MouseEnter += (object sender, EventArgs e) =>
                {
                    pnl.BackColor = Color.Gray;
                };

                pnl.MouseLeave += (object sender, EventArgs e) =>
                {
                    pnl.BackColor = Color.White;
                };

                lblTitlu.MouseEnter += (object sender, EventArgs e) =>
                {
                    pnl.BackColor = Color.Gray;
                };

                lblTitlu.MouseLeave += (object sender, EventArgs e) =>
                {
                    pnl.BackColor = Color.White;
                };

                pb.MouseEnter += (object sender, EventArgs e) =>
                {
                    pnl.BackColor = Color.Gray;
                };

                pb.MouseLeave += (object sender, EventArgs e) =>
                {
                    pnl.BackColor = Color.White;
                };

            }
        }

        private void load_lectii()
        {

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = @"SERVER=localhost; DATABASE=atestat; UID=root; PASSWORD=; Allow User Variables=true";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM lectii";

            MySqlDataReader r = cmd.ExecuteReader();


            while (r.Read())
            {
                titlu[cntLectii] = r["titlu"].ToString();
                continut[cntLectii++] = r["continut"].ToString();
            }
            con.Close();
        }

        private void frmCuprins_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.cuprins = null;
        }

        LessonView[] lwList = new LessonView[1000];


        private void frmCuprins_Load(object sender, EventArgs e)
        {
            try
            {
                load_lectii();
            }
            catch
            {
                MessageBox.Show("Eroare la baza de date", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            LessonView lw0 = new LessonView(pnlLectii, new Point(20, 20), 8 * Width / 10, 2 * Height / 10, (File.Exists("icons//" + titlu[0] + "//thumbnail.jpg") ? ("icons//" + titlu[0] + "//thumbnail.jpg") : ("icons\\noimage.png")), titlu[0], continut[0]);
            lwList[lwCount++] = lw0;
            for (int i = 1; i < cntLectii; i++)
            {
                LessonView lw = new LessonView(pnlLectii, new Point(20, lwList[i - 1].pnl.Location.Y + 2 * Height / 10 + 10), 8 * Width / 10, 2 * Height / 10, (File.Exists("icons//" + titlu[i] + "//thumbnail.jpg") ? ("icons//" + titlu[i] + "//thumbnail.jpg") : ("icons\\noimage.png")), titlu[i], continut[i]);


                lwList[lwCount++] = lw;
            }

        }

    }
}
