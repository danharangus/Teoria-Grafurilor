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
using System.IO;

namespace Teoria_Grafurilor
{
    public partial class frmAdaugaLectie : Form
    {
        public frmAdaugaLectie()
        {
            InitializeComponent();
        }

        bool insertLectie(string titlu, string continut)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = @"SERVER=localhost; DATABASE=atestat; UID=root; PASSWORD=; Allow User Variables=true";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO lectii(titlu, continut) VALUES(@titlu, @continut);";
            cmd.Parameters.AddWithValue("titlu", titlu);
            cmd.Parameters.AddWithValue("continut", continut);


            if (cmd.ExecuteNonQuery() != 0)
            {
                (Tag as frmAdmin).listBoxLectii.Items.Add(titlu);
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

        bool available(string titlu)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = @"SERVER=localhost; DATABASE=atestat; UID=root; PASSWORD=; Allow User Variables=true";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM lectii WHERE titlu = @titlu";
            cmd.Parameters.AddWithValue("titlu", titlu);
            MySqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                con.Close();
                return false;
            }
            con.Close();
            return true;

        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            if(tbTitlu.Text == "" || tbContinut.Text == "")
            {
                MessageBox.Show("Ambele campuri sunt obligatorii!");
                return;
            }
            if (available(tbTitlu.Text))
            {
                if (insertLectie(tbTitlu.Text, tbContinut.Text))
                {
                    (Tag as frmAdmin).continut[(Tag as frmAdmin).cntLectii] = tbContinut.Text;
                    (Tag as frmAdmin).titlu[(Tag as frmAdmin).cntLectii++] = tbTitlu.Text;
                }
            }
            else
            {
                MessageBox.Show("Există deja o lecție cu acest titlu!");
                return;
            }

            if (File.Exists(pb1.ImageLocation) && pb1.ImageLocation != "icons//noimage.png")
            {
                string titlu = tbTitlu.Text;
                if(!Directory.Exists(titlu))
                {
                    Directory.CreateDirectory("icons//" + titlu);
                }

                File.Copy(pb1.ImageLocation, "icons//" + titlu + "//" + "thumbnail" + ".jpg");
            }
            tbTitlu.Text = "";
            tbContinut.Text = "";
            MessageBox.Show("Lectia a fost adaugata cu succes!");
            pb1.ImageLocation = "icons//noimage.png";
        }

        private void frmAdaugaLectie_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (string file in Directory.EnumerateFiles("icons//temp"))
            {
                File.Delete(file);
            }
            frmAdmin.adaugaLectie = null;
        }

        private void btnIncarca_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK && File.Exists(ofd.FileName))
            {
                string sourcePath = ofd.FileName;
                string newPath = "icons//temp//" + Path.GetFileNameWithoutExtension(sourcePath) + ".jpg";

                if(!File.Exists(newPath))
                    File.Copy(sourcePath, newPath);

                if(File.Exists(newPath))
                    pb1.ImageLocation = newPath;
            }
        }

        private void frmAdaugaLectie_Load(object sender, EventArgs e)
        {
            pb1.ImageLocation = "icons//noimage.png";
        }
    }
}
