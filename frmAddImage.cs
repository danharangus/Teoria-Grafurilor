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
    public partial class frmAddImage : Form
    {
        public frmAddImage()
        {
            InitializeComponent();
        }

        private void frmAddImage_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach(string file in Directory.EnumerateFiles("icons//temp"))
            {
                File.Delete(file);
            }
            frmLectie.addImage = null;
        }

        private void frmAddImage_Load(object sender, EventArgs e)
        {
            pb1.ImageLocation = "icons//noimage.png";
        }

        private void btnIncarca_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK && File.Exists(ofd.FileName))
            {
                string sourcePath = ofd.FileName;
                string newPath = "icons//temp//" + Path.GetFileNameWithoutExtension(sourcePath) + ".jpg";

                if (!File.Exists(newPath))
                    File.Copy(sourcePath, newPath);

                if (File.Exists(newPath))
                    pb1.ImageLocation = newPath;
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if(tbDescriere.Text.Trim() == "")
            {
                MessageBox.Show("Imaginea trebuie să aibă o descriere!");
                return;
            }

            if (File.Exists(pb1.ImageLocation) && pb1.ImageLocation != "icons//noimage.png")
            {
                string descriere = tbDescriere.Text;
                string titlu = (this.Tag as frmLectie).lblTitlu.Text;
                if (!Directory.Exists(titlu))
                {
                    Directory.CreateDirectory("icons//" + titlu);
                }

                if (!File.Exists("icons//" + titlu + "//" + tbDescriere.Text + ".jpg"))
                {
                    File.Copy(pb1.ImageLocation, "icons//" + titlu + "//" + tbDescriere.Text + ".jpg");
                }
                else
                {
                    MessageBox.Show("Există deja o imagine cu această descriere!");
                    return;
                }
            }
            tbDescriere.Text = "";
            MessageBox.Show("Imaginea a fost adaugata cu succes!");
            pb1.ImageLocation = "icons//noimage.png";
            (this.Tag as frmLectie).load_images();
        }
    }
}
