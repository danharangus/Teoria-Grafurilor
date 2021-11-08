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
using MySql.Data.MySqlClient;

namespace Teoria_Grafurilor
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        public string[] conturi = new string[1000];
        public string[] tip = new string[1000];
        public string[] titlu = new string[1000];
        public string[] continut = new string[1000];
        public string[] intrebare = new string[1000];
        public string[] var_a = new string[1000];
        public string[] var_b = new string[1000];
        public string[] var_c = new string[1000];
        public string[] corect = new string[1000];

        public static frmAdaugaLectie adaugaLectie;
        public static frmAddIntrebare adaugaIntrebare;

        //pnlconturi loc = 70; 86
        public int cntConturi, cntIntrebari;
        public int cntLectii;

        private void update(string utilizator, string tip)
        {
            if (utilizator == "" || tip == "")
                return;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = @"SERVER=localhost; DATABASE=atestat; UID=root; PASSWORD=; Allow User Variables=true";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE conturi SET tip=@tip WHERE utilizator=@utilizator";
            cmd.Parameters.AddWithValue("tip", tip);
            cmd.Parameters.AddWithValue("utilizator", utilizator);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void delete_lectie(string titlu)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = @"SERVER=localhost; DATABASE=atestat; UID=root; PASSWORD=; Allow User Variables=true";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM lectii WHERE titlu=@titlu";
            cmd.Parameters.AddWithValue("titlu", titlu);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void delete_intrebare(string intrebare)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = @"SERVER=localhost; DATABASE=atestat; UID=root; PASSWORD=; Allow User Variables=true";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM intrebari WHERE intrebare=@intrebare";
            cmd.Parameters.AddWithValue("intrebare", intrebare);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void load_acc()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = @"SERVER=localhost; DATABASE=atestat; UID=root; PASSWORD=; Allow User Variables=true";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM conturi";

            MySqlDataReader r = cmd.ExecuteReader();


            while (r.Read())
            {
                conturi[cntConturi] = r["utilizator"].ToString();
                tip[cntConturi++] = r["tip"].ToString();
            }
            con.Close();
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

        private void load_intrebari()
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
                intrebare[cntIntrebari] = r["intrebare"].ToString();
                var_a[cntIntrebari] = r["var_a"].ToString();
                var_b[cntIntrebari] = r["var_b"].ToString();
                var_c[cntIntrebari] = r["var_c"].ToString();
                corect[cntIntrebari++] = r["corect"].ToString();
            }
            con.Close();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            pnlConturi.Location = new Point(70, 86);
            pnlLectii.Location = new Point(70, 86);
            load_acc();
            for (int i = 0; i < cntConturi; i++)
            {
                lb.Items.Add(conturi[i]);
            }

            load_lectii();
            for (int i = 0; i < cntLectii; i++)
            {
                listBoxLectii.Items.Add(titlu[i]);
            }

            load_intrebari();
            for (int i = 0; i < cntIntrebari; i++)
            {
                listBoxIntrebari.Items.Add(intrebare[i]);
            }
        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.admin = null;
        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTip2.Text = tip[lb.SelectedIndex].ToString();
        }

        private void pnlConturi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if(lb.SelectedIndex == -1)
            {
                MessageBox.Show("Niciun cont selectat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lblTip2.Text == "elev")
            {
                try
                {
                    update(conturi[lb.SelectedIndex], "admin");
                    lblTip2.Text = "admin";
                }
                catch
                {
                    MessageBox.Show("Database error");

                }
            }
        }

        private void btnElev_Click(object sender, EventArgs e)
        {
            if (lb.SelectedIndex == -1)
            {
                MessageBox.Show("Niciun cont selectat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lblTip2.Text == "admin")
            {
                try
                {
                    update(conturi[lb.SelectedIndex], "elev");
                    lblTip2.Text = "elev";
                }
                catch
                {
                    MessageBox.Show("Database error");

                }
            }
        }

        private void btnAdaugareLectie_Click(object sender, EventArgs e)
        {
            if (adaugaLectie == null)
            {
                adaugaLectie = new frmAdaugaLectie();
                adaugaLectie.Tag = this;
                adaugaLectie.Show();
            }
        }

        private void btnConturi_Click(object sender, EventArgs e)
        {
            pnlConturi.Location = new Point(70, 86);
            pnlConturi.Visible = true;
            pnlLectii.Visible = false;
            pnlIntrebari.Visible = false;
        }

        private void btnLectii_Click(object sender, EventArgs e)
        {
            pnlLectii.Location = new Point(70, 86);
            pnlConturi.Visible = false;
            pnlLectii.Visible = true;
            pnlIntrebari.Visible = false;
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            if(listBoxLectii.SelectedIndex < 0)
            {
                MessageBox.Show("Nicio lecție selectată", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(MessageBox.Show("Sigur doriți să ștergeți această lecție?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Directory.Delete("icons//" + listBoxLectii.SelectedItem.ToString(), true);
                delete_lectie(listBoxLectii.SelectedItem.ToString());
                listBoxLectii.Items.RemoveAt(listBoxLectii.SelectedIndex);
            }
            return;
        }

        private void pnlIntrebari_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdaugaIntrebare_Click(object sender, EventArgs e)
        {
            if(adaugaIntrebare == null)
            {
                adaugaIntrebare = new frmAddIntrebare();
                adaugaIntrebare.Tag = this;
                adaugaIntrebare.Show();
            }
        }

        private void btnStergeIntrebare_Click(object sender, EventArgs e)
        {
            if (listBoxIntrebari.SelectedIndex < 0)
            {
                MessageBox.Show("Nicio întrebare selectată", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Sigur doriți să ștergeți această întrebare?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                delete_intrebare(listBoxIntrebari.Items[listBoxIntrebari.SelectedIndex].ToString());
                listBoxIntrebari.Items.RemoveAt(listBoxIntrebari.SelectedIndex);
            }
            return;
        }

        private void btnIntrebari_Click(object sender, EventArgs e)
        {
            pnlIntrebari.Location = new Point(70, 86);
            pnlIntrebari.Visible = true;
            pnlLectii.Visible = false;
            pnlConturi.Visible = false;
        }
    }
}
