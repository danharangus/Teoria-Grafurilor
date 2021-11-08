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
    public partial class frmAddIntrebare : Form
    {
        public frmAddIntrebare()
        {
            InitializeComponent();
        }

        public string[] titlu = new string[1000];
        int cntLectii = 0;

        bool insertIntrebare(string intrebare, string var_a, string var_b, string var_c, string corect, string lectie)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = @"SERVER=localhost; DATABASE=atestat; UID=root; PASSWORD=; Allow User Variables=true";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO intrebari(intrebare, var_a, var_b, var_c, corect, lectie) VALUES(@intrebare, @var_a, @var_b, @var_c, @corect, @lectie);";
            cmd.Parameters.AddWithValue("intrebare", intrebare);
            cmd.Parameters.AddWithValue("var_a", var_a);
            cmd.Parameters.AddWithValue("var_b", var_b);
            cmd.Parameters.AddWithValue("var_c", var_c);
            cmd.Parameters.AddWithValue("corect", corect);
            cmd.Parameters.AddWithValue("lectie", lectie);


            if (cmd.ExecuteNonQuery() != 0)
            {
                tbIntrebare.Text = "";
                tbVarA.Text = "";
                tbVarB.Text = "";
                tbVarC.Text = "";
                cbLectii.SelectedIndex = -1;
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                MessageBox.Show("Intrebarea a fost adaugata cu succes!");
                (Tag as frmAdmin).listBoxIntrebari.Items.Add(intrebare);
                con.Close();
                return true;

            }
            else
            {
                MessageBox.Show("Eroare");
            }
            con.Close();
            return false;
        }

        bool available(string intrebare)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = @"SERVER=localhost; DATABASE=atestat; UID=root; PASSWORD=; Allow User Variables=true";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM intrebari WHERE intrebare = @intrebare";
            cmd.Parameters.AddWithValue("intrebare", intrebare);
            MySqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                con.Close();
                return false;
            }
            con.Close();
            return true;

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
                titlu[cntLectii++] = r["titlu"].ToString();
            }
            con.Close();
        }

        private void frmAddIntrebare_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAdmin.adaugaIntrebare = null;
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            if (tbIntrebare.Text.Trim() == "" ||
                tbVarA.Text.Trim() == "" ||
                tbVarB.Text.Trim() == "" ||
                tbVarC.Text.Trim() == "" ||
                (!rb1.Checked && !rb2.Checked && !rb3.Checked))
            {
                MessageBox.Show("Toate câmpurile sunt obligatorii!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string corect = "";

            if (rb1.Checked)
            {
                corect = "a";
            }
            else if (rb2.Checked)
            {
                corect = "b";
            }
            else if (rb3.Checked)
            {
                corect = "c";
            }

            if (available(tbIntrebare.Text))
            {
                if (insertIntrebare(tbIntrebare.Text, tbVarA.Text, tbVarB.Text, tbVarC.Text, corect, (cbLectii.SelectedIndex == -1 ? "" : cbLectii.Items[cbLectii.SelectedIndex].ToString())))
                {
                    (Tag as frmAdmin).continut[(Tag as frmAdmin).cntIntrebari] = tbIntrebare.Text;
                }
            }
            else
            {
                MessageBox.Show("Această întrebare există deja!");
            }
        }

        private void frmAddIntrebare_Load(object sender, EventArgs e)
        {
            load_lectii();

            for (int i = 0; i < cntLectii; i++)
            {
                cbLectii.Items.Add(titlu[i]);
            }
        }
    }
}
