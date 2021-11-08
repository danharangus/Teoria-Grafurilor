using MySql.Data.MySqlClient;
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
    public partial class frmTestGrila : Form
    {
        public frmTestGrila()
        {
            InitializeComponent();
        }

        public int nrIntrebare = 0;

        public string[] intrebare = new string[1000];
        public string[] var_a = new string[1000];
        public string[] var_b = new string[1000];
        public string[] var_c = new string[1000];
        public string[] lectie = new string[1000];
        public string[] corect = new string[1000];
        public string[] selectat = new string[1000];
        public int[] index = new int[1000]; // iti trebe un vector unde retii intreabrile luate "random" din baza pentru ca trebe sa avem un buton de next si prev
        public bool[] viz = new bool[1000];

        int total = 0;

        void selectIntrebari()
        {

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = @"SERVER=localhost; DATABASE=atestat; UID=root; PASSWORD=; Allow User Variables=true";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM intrebari";

            MySqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                intrebare[total] = r["intrebare"].ToString();
                var_a[total] = r["var_a"].ToString();
                var_b[total] = r["var_b"].ToString();
                var_c[total] = r["var_c"].ToString();
                corect[total] = r["corect"].ToString();
                lectie[total] = r["lectie"].ToString();
                total++;
            }

            con.Close();
        }

        int lim;

        private void frmTestGrila_Load(object sender, EventArgs e)
        {
            selectIntrebari();


            if (total == 0)
            {
                MessageBox.Show("Eroare: Testul nu conţine nicio întrebare!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            if (total == 0)
            {
                btnNext.Enabled = false;
                btnBack.Enabled = false;
                btnCheck.Enabled = false;
            }

            Random r = new Random();
            lim = Math.Min(10, total);

            for (int nrIntrebare = 0; nrIntrebare < lim; nrIntrebare++)
            {


                int a = r.Next(0, total); // luam un numar random



                while (viz[a])
                {
                    a = r.Next(0, total);
                }
                viz[a] = true;
                index[nrIntrebare] = a;
            }

            nrIntrebare = 0;
            lblIntrebare.Text = intrebare[index[nrIntrebare]];
            rb1.Text = var_a[index[nrIntrebare]];
            rb2.Text = var_b[index[nrIntrebare]];
            rb3.Text = var_c[index[nrIntrebare]];

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            if (nrIntrebare <= 0)
            {
                nrIntrebare = total - 1;
            }
            else
            {
                nrIntrebare--;
            }
            if (btnCheck.Enabled == false)
            {
                if (selectat[index[nrIntrebare]] == corect[index[nrIntrebare]])
                    pb.Image = Image.FromFile("icons\\corect.png");
                else
                    pb.Image = Image.FromFile("icons\\wrong.png");
            }
            lblIntrebare.Text = intrebare[index[nrIntrebare]];
            rb1.Text = var_a[index[nrIntrebare]];
            rb2.Text = var_b[index[nrIntrebare]];
            rb3.Text = var_c[index[nrIntrebare]];
            if (selectat[index[nrIntrebare]] == null)
            {
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
            }
            else
            {
                if (selectat[index[nrIntrebare]] == "a")
                {
                    rb1.Checked = true;
                }
                else if (selectat[index[nrIntrebare]] == "b")
                {
                    rb2.Checked = true;
                }
                else
                {
                    rb3.Checked = true;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (nrIntrebare >= total - 1)
            {
                nrIntrebare = 0;
            }
            else
            {
                nrIntrebare++;
            }

            if (btnCheck.Enabled == false)
            {
                if (selectat[index[nrIntrebare]] == corect[index[nrIntrebare]])
                    pb.Image = Image.FromFile("icons\\corect.png");
                else
                    pb.Image = Image.FromFile("icons\\wrong.png");
            }
            lblIntrebare.Text = intrebare[index[nrIntrebare]];
            rb1.Text = var_a[index[nrIntrebare]];
            rb2.Text = var_b[index[nrIntrebare]];
            rb3.Text = var_c[index[nrIntrebare]];

            if (selectat[index[nrIntrebare]] == null)
            {
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
            }
            else
            {
                if (selectat[index[nrIntrebare]] == "a")
                {
                    rb1.Checked = true;
                }
                else if (selectat[index[nrIntrebare]] == "b")
                {
                    rb2.Checked = true;
                }
                else
                {
                    rb3.Checked = true;
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int punctaj = 0;
            if (MessageBox.Show("Atentie! După verificare răspunsurile nu mai pot fi modificate! Sunteţi sigur?", "Verificare", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                for (int nrI = 0; nrI < lim; nrI++)
                {
                    if (selectat[index[nrI]] == corect[index[nrI]])
                    {
                        punctaj++;
                    }
                }
                MessageBox.Show("Aţi obţinut " + punctaj + " puncte!", "", MessageBoxButtons.OK);
                btnCheck.Enabled = false;
                rb1.Enabled = false;
                rb2.Enabled = false;
                rb3.Enabled = false;


                if (selectat[index[nrIntrebare]] == corect[index[nrIntrebare]])
                {
                    pb.Image = Image.FromFile("icons\\corect.png");
                }
                else
                {
                    pb.Image = Image.FromFile("icons\\wrong.png");
                }

            }
        }

        private void frmTestGrila_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.testGrila = null;
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1.Checked)
                selectat[index[nrIntrebare]] = "a";
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2.Checked)
                selectat[index[nrIntrebare]] = "b";
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb3.Checked)
                selectat[index[nrIntrebare]] = "c";
        }
    }
}
