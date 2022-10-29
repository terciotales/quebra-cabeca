using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.Pkcs;
using System.Security.Principal;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace quebra_cabeca
{
    public partial class Form1 : Form
    {
        int num_images = 9;
        string image = "sw";
        string level = "f";
        private bool is_can_draw = false;

        List<Bitmap> imageList = new List<Bitmap>();

        PictureBox source;
        PictureBox final;

        public Form1()
        {
            InitializeComponent();
        }

        void Shuffle()
        {
            int j;

            List<int> Indexes = new List<int>();

            for (int i = 0; i < this.num_images; i++)
            {
                Indexes.Add(i);
            }

            Random r = new Random();
            for (int i = 0; i < this.num_images; i++)
            {
                Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                ((PictureBox)pecas.Controls[i]).Image = this.imageList[j];
            }

            for (int i = 0; i < this.num_images; i++)
            {
                ((PictureBox)quebraCabeca.Controls[i]).Image = null;
            }

            tentativas.Text = "0";
        }

        void setDragDropEvents()
        {
            for (int i = 0; i < (this.num_images); i++)
            {
                ((PictureBox)quebraCabeca.Controls[i]).MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.qc_DoubleClick);
                ((PictureBox)pecas.Controls[i]).MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_MouseDown);
                ((PictureBox)quebraCabeca.Controls[i]).MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_MouseDown);
                ((PictureBox)quebraCabeca.Controls[i]).DragDrop += new System.Windows.Forms.DragEventHandler(this.qc_DragDrop);
                ((PictureBox)quebraCabeca.Controls[i]).DragEnter += new System.Windows.Forms.DragEventHandler(this.qc_DragEnter);
            }
        }

        void checkWin()
        {
            bool won = true;

            List<Bitmap> lista = new List<Bitmap>(this.imageList);
            lista.Reverse();

            for (int i = 0; i < (this.num_images); i++)
            {
                if (((PictureBox)quebraCabeca.Controls[i]).Image == null || ((PictureBox)quebraCabeca.Controls[i]).Image != lista[i])
                {
                    won = false;
                    break;
                }
            }


            if (won == true)
            {
                DialogResult result = MessageBox.Show("Deseja começar um novo jogo?", "Você Venceu!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    this.Shuffle();
                }
            }
        }

        void setBeforeImage()
        {
            for (int i = 0; i < this.num_images; i++)
            {
                if (((PictureBox)pecas.Controls[i]).Name == this.source.Name)
                {
                    ((PictureBox)pecas.Controls[i]).Image = this.final.Image;
                }

                if (((PictureBox)quebraCabeca.Controls[i]).Name == this.source.Name)
                {
                    ((PictureBox)quebraCabeca.Controls[i]).Image = this.final.Image;
                }
            }
        }

        void removeSourceImage()
        {
            for (int i = 0; i < this.num_images; i++)
            {
                if (((PictureBox)pecas.Controls[i]).Name == this.source.Name)
                {
                    ((PictureBox)pecas.Controls[i]).Image = null;
                }

                if (((PictureBox)quebraCabeca.Controls[i]).Name == this.source.Name)
                {
                    ((PictureBox)quebraCabeca.Controls[i]).Image = null;
                }
            }
        }

        void SetAllowDrop()
        {
            for (int i = 0; i < this.num_images; i++)
            {
                ((PictureBox)quebraCabeca.Controls[i]).AllowDrop = true;
            }
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.setListImages();
            this.createPictureBoxes(quebraCabeca);
            this.createPictureBoxes(pecas);
            this.Shuffle();
            this.SetAllowDrop();
            this.setDragDropEvents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Shuffle();
        }

        private void p_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1)
            {

                PictureBox obj = (PictureBox)sender;

                if (obj.Image == null)
                {
                    return;
                }

                this.source = obj;
                obj.DoDragDrop(obj.Image, DragDropEffects.Copy | DragDropEffects.Move);
            }
            else if (e.Clicks == 2) { 
                
            }
        }

        private void qc_DragEnter(object sender, DragEventArgs e)
        {
            PictureBox obj = (PictureBox)sender;

            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void qc_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox obj = (PictureBox)sender;
            this.final = obj;

            if (obj.Image == null)
            {
                this.removeSourceImage();
            }
            else
            {
                this.setBeforeImage();
            }

            obj.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            obj.SizeMode = PictureBoxSizeMode.StretchImage;

            if (this.source != obj)
            {
                tentativas.Text = (Convert.ToInt32(tentativas.Text.ToString()) + 1).ToString();
            }

            this.checkWin();
        }

        private void qc_DoubleClick(object sender, EventArgs e)
        {
            PictureBox obj = (PictureBox)sender;

            if (obj.Image == null)
            {
                return;
            }

            for (int i = 0; i < this.num_images; i++)
            {
                if (((PictureBox)pecas.Controls[i]).Image == null)
                {
                    ((PictureBox)pecas.Controls[i]).Image = obj.Image;
                    obj.Image = null;
                }
            }
        }
        private void theWitcherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.image = "tw";

            ((ToolStripMenuItem)theWitcherToolStripMenuItem).Checked = true;
            ((ToolStripMenuItem)starWarsToolStripMenuItem).Checked = false;
            ((ToolStripMenuItem)godOfWarToolStripMenuItem).Checked = false;


            this.setListImages();
            this.Shuffle();
        }

        private void godOfWarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.image = "gw";

            ((ToolStripMenuItem)godOfWarToolStripMenuItem).Checked = true;
            ((ToolStripMenuItem)starWarsToolStripMenuItem).Checked = false;
            ((ToolStripMenuItem)theWitcherToolStripMenuItem).Checked = false;

            this.setListImages();
            this.Shuffle();
        }

        private void starWarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.image = "sw";

            ((ToolStripMenuItem)starWarsToolStripMenuItem).Checked = true;
            ((ToolStripMenuItem)godOfWarToolStripMenuItem).Checked = false;
            ((ToolStripMenuItem)theWitcherToolStripMenuItem).Checked = false;

            this.setListImages();
            this.Shuffle();
        }

        void createPictureBoxes(GroupBox groupBox)
        {
            groupBox.Controls.Clear();

            string prefix = "pc";

            if (groupBox == quebraCabeca)
            {
                prefix = "qc";
            }

            int breakpoint = Convert.ToInt32(Math.Sqrt(this.num_images));
            int spacing = 30;
            int x = spacing / (breakpoint);
            int y = 30;
            int size = ((groupBox.Width - (spacing + (spacing / breakpoint))) / breakpoint);

            for (int i = 0; i < this.num_images; i++)
            {
                if (i == breakpoint || i == (breakpoint * 2) || i == (breakpoint * 3) || i == (breakpoint * 4) || i == (breakpoint * 5) || i == (breakpoint * 6))
                {
                    x = spacing / breakpoint;
                    y += size + ((spacing + (spacing / breakpoint)) / breakpoint);
                }

                PictureBox p = new PictureBox();
                p.Location = new Point(x, y);
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Name = prefix + "_" + i;
                p.Size = new Size(size, size);
                p.BorderStyle = BorderStyle.FixedSingle;
                groupBox.Controls.Add(p);

                x += size + (spacing / breakpoint);
            }
        }

        private void médioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)fácilToolStripMenuItem).Checked = false;
            ((ToolStripMenuItem)difícilToolStripMenuItem).Checked = false;
            ((ToolStripMenuItem)médioToolStripMenuItem).Checked = true;

            this.num_images = 25;
            this.level = "m";
            this.setListImages();
            this.createPictureBoxes(quebraCabeca);
            this.createPictureBoxes(pecas);
            this.SetAllowDrop();
            this.setDragDropEvents();
            this.Shuffle();
        }

        private void difícilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)fácilToolStripMenuItem).Checked = false;
            ((ToolStripMenuItem)difícilToolStripMenuItem).Checked = true;
            ((ToolStripMenuItem)médioToolStripMenuItem).Checked = false;

            this.num_images = 49;
            this.level = "d";
            this.setListImages();
            this.createPictureBoxes(quebraCabeca);
            this.createPictureBoxes(pecas);
            this.SetAllowDrop();
            this.setDragDropEvents();
            this.Shuffle();
        }

        private void fácilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)fácilToolStripMenuItem).Checked = true;
            ((ToolStripMenuItem)difícilToolStripMenuItem).Checked = false;
            ((ToolStripMenuItem)médioToolStripMenuItem).Checked = false;

            this.num_images = 9;
            this.level = "f";
            this.setListImages();
            this.createPictureBoxes(quebraCabeca);
            this.createPictureBoxes(pecas);
            this.SetAllowDrop();
            this.setDragDropEvents();
            this.Shuffle();
        }

        void setListImages()
        {
            this.imageList.Clear();

            for (int i = 1; i <= this.num_images; i++)
            {
                this.imageList.Add((Bitmap)Properties.Resources.ResourceManager.GetObject(this.image + "_" + this.level + "_" + i));
            }
        }

        private void tip_MouseEnter(object sender, EventArgs e)
        {
            List<Bitmap> lista = new List<Bitmap>(this.imageList);
            lista.Reverse();

            for (int i = 0; i < this.num_images; i++)
            {
                ((PictureBox)quebraCabeca.Controls[i]).BackgroundImage = lista[i];
                ((PictureBox)quebraCabeca.Controls[i]).BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void tip_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i < this.num_images; i++)
            {
                ((PictureBox)quebraCabeca.Controls[i]).BackgroundImage = null;
                ((PictureBox)quebraCabeca.Controls[i]).BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}