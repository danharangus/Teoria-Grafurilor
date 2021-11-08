using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Teoria_Grafurilor
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

                
        }

        bool available(string user, string mail)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = @"SERVER=localhost; DATABASE=atestat; UID=root; PASSWORD=; Allow User Variables=true";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM conturi WHERE utilizator = @user OR mail = @mail";
            cmd.Parameters.AddWithValue("user", user);
            cmd.Parameters.AddWithValue("mail", mail);
            MySqlDataReader r = cmd.ExecuteReader();
            if(r.Read())
            {
                con.Close();
                return false;
            }
            con.Close();
            return true;

        }


        void register(string user, string parola, string mail)
        {         
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = @"SERVER=localhost; DATABASE=atestat; UID=root; PASSWORD=; Allow User Variables=true";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO conturi(utilizator, parola, mail, tip) VALUES(@user, @parola, @mail, @tip);";
            cmd.Parameters.AddWithValue("user", user);
            cmd.Parameters.AddWithValue("parola", parola);
            cmd.Parameters.AddWithValue("mail", mail);
            cmd.Parameters.AddWithValue("tip", "elev");


            if (cmd.ExecuteNonQuery() != 0)
            {
                variabile.nume = user;
                variabile.tip = 0;
                (this.Tag as frmMain).lblWelcome.Text = "Bun venit, " + variabile.nume + "!";
                MessageBox.Show("Inregistrarea a fost realizată cu succes!");
                (this.Tag as frmMain).lblDisconnect.Visible = true;
                (this.Tag as frmMain).lblDisconnect.Enabled = true;
                (this.Tag as frmMain).Invalidate();
                (this.Tag as frmMain).lblLogin.Visible = false;
                (this.Tag as frmMain).lblRegister.Visible = false;
            }
            else
            {
                MessageBox.Show("Eroare");
            }
            con.Close();
        }  

        private void pbHide_Click(object sender, EventArgs e)
        {
            pbHide.Visible = false;
            pbShow.Visible = true;
            tbParola.UseSystemPasswordChar = true;
        }

        private void pbShow_Click(object sender, EventArgs e)
        {
            pbShow.Visible = false;
            pbHide.Visible = true;
            tbParola.UseSystemPasswordChar = false;
        }

        private void tbNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNume_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (available(tbNume.Text, tbMail.Text))
                {
                    register(tbNume.Text, tbParola.Text, tbMail.Text);
                    this.Close();
                }
                else
                {
                    tbMail.Text = "";
                    tbNume.Text = "";
                    tbParola.Text = "";
                    MessageBox.Show("Numele de utilizator sau adresa de mail au fost deja folosite!");

                }
            }
            catch(Exception ex)
            {

                // MessageBox.Show(ex.ToString());
                MessageBox.Show("Database error");
            }

        }

        private void frmRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.register = null;
        }
    }
}
