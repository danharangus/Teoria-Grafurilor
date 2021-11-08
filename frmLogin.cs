using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Teoria_Grafurilor
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
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

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.login = null;
        }

        bool login(string user, string parola)
        {

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = @"SERVER=localhost; DATABASE=atestat; UID=root; PASSWORD=; Allow User Variables=true";
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM conturi WHERE utilizator=@user AND parola=@parola";
            cmd.Parameters.AddWithValue("user", user);
            cmd.Parameters.AddWithValue("parola", parola);

            MySqlDataReader r = cmd.ExecuteReader();

            if (r.Read())
            {
                MessageBox.Show("Te-ai conectat cu succes!");
                variabile.nume = r["utilizator"].ToString();
                if(r["tip"].ToString() == "admin")
                {
                    variabile.tip = 1;
                    (this.Tag as frmMain).lblAdmin.Visible = true;
                }
                else
                {
                    variabile.tip = 0;
                }
                (this.Tag as frmMain).lblWelcome.Text = "Bun venit, " + variabile.nume + "!";
                (this.Tag as frmMain).lblDisconnect.Visible = true;
                (this.Tag as frmMain).lblDisconnect.Enabled = true;
                (this.Tag as frmMain).Invalidate();
                (this.Tag as frmMain).lblLogin.Visible = false;
                (this.Tag as frmMain).lblRegister.Visible = false;
            }
            else
            {
                MessageBox.Show("Numele sau parola greșită");
                return false;
            }
            con.Close();
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(login(tbNume.Text, tbParola.Text))
                {
                    this.Close();
                }
                else
                {
                    tbNume.Text = "";
                    tbParola.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Database error");
            }
        }
    }
}
