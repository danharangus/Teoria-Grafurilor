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
    public partial class frmLectie : Form
    {
        public frmLectie()
        {
            InitializeComponent();
        }

        public static frmAddImage addImage;

        public string[] path = new string[1000];
        public string[] desc = new string[1000];
        int imageCount = 0;
        int click = 0;

        public void load_images()
        {
            path = new string[1000];
            desc = new string[1000];
            imageCount = 0;
            string titlu = lblTitlu.Text;
            string folder = "icons//" + titlu;
            if (Directory.Exists(folder))
                foreach (string p in Directory.EnumerateFiles("icons//" + titlu, "*.jpg"))
                {
                    string nume = Path.GetFileNameWithoutExtension(p);
                    if (nume != "thumbnail")
                    {
                        path[imageCount] = p;
                        desc[imageCount++] = nume;
                    }
                }
            if (pbImg.ImageLocation == "icons//noimage.png" && imageCount != 0)
            {
                pbImg.ImageLocation = path[0];
                lblDesc.Text = desc[0];
            }
        }

        private void frmLectie_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmCuprins.lectie = null;
        }

        private void frmLectie_Load(object sender, EventArgs e)
        {
            if (variabile.tip == 1)
            {
                pbAdd.Visible = true;
                pbDel.Visible = true;
            }
            else
            {
                pbAdd.Visible = false;
                pbDel.Visible = false;
            }

            load_images();
            if (imageCount == 0)
            {
                pbImg.ImageLocation = "icons//noimage.png";
            }
            else
            {
                pbImg.ImageLocation = path[0];
                lblDesc.Text = desc[0];
            }

            tb1.SelectionStart = tb1.Text.Length + 1;
            tb1.Select();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            if (addImage == null)
            {
                addImage = new frmAddImage();
                addImage.Tag = this;
                addImage.Show();
            }
        }

        private void pbDel_Click(object sender, EventArgs e)
        {
            if (imageCount == 0)
                return;
            File.Delete(path[click]);
            for(int i = click; i < imageCount; i++)
            {
                desc[i] = desc[i + 1];
                path[i] = path[i + 1];
            }
            imageCount--;
            pbNext_Click(null, null); 
            if(imageCount == 0)
            {
                pbImg.ImageLocation = "icons//noimage.png";
                lblDesc.Text = "";
            }
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            if (imageCount == 0)
                return;
            click++;
            click %= imageCount;
            pbImg.ImageLocation = path[click];
            lblDesc.Text = desc[click];
        }

        private void pbPrev_Click(object sender, EventArgs e)
        {
            if (imageCount == 0)
                return;
            click--;
            click = click < 0 ? imageCount - 1 : click;
            pbImg.ImageLocation = path[click];
            lblDesc.Text = desc[click];
        }
    }
}
