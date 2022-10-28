using System;
using System.Collections;
using System.Security.Cryptography.Pkcs;
using System.Security.Principal;
using System.Windows.Forms;

namespace quebra_cabeca
{
    public partial class Form1 : Form
    {
        int num_images = 9;

        List<Bitmap> imageList = new List<Bitmap>()
        {
            Properties.Resources.sw1,
            Properties.Resources.sw2,
            Properties.Resources.sw3,
            Properties.Resources.sw4,
            Properties.Resources.sw5,
            Properties.Resources.sw6,
            Properties.Resources.sw7,
            Properties.Resources.sw8,
            Properties.Resources.sw9
        };

        PictureBox source;
        PictureBox final;

        public Form1()
        {
            InitializeComponent();
        }

        void Shuffle()
        {
            int j;
            List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 });
            Random r = new Random();
            for (int i = 0; i < this.num_images; i++)
            {
                Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                ((PictureBox)groupBox2.Controls[i]).Image = this.imageList[j];
            }

            for (int i = 0; i < this.num_images; i++)
            {
                ((PictureBox)groupBox1.Controls[i]).Image = null;
            }

            tentativas.Text = "0";

        }

        void setDragDropEvents()
        {
            for (int i = 0; i < this.num_images; i++)
            {
                ((PictureBox)groupBox2.Controls[i]).MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_MouseDown);
                ((PictureBox)groupBox1.Controls[i]).MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_MouseDown);
                ((PictureBox)groupBox1.Controls[i]).DragDrop += new System.Windows.Forms.DragEventHandler(this.qc_DragDrop);
                ((PictureBox)groupBox1.Controls[i]).DragEnter += new System.Windows.Forms.DragEventHandler(this.qc_DragEnter);
                ((PictureBox)groupBox1.Controls[i]).MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.qc_DoubleClick);
            }
        }

        void checkWin()
        {
            bool won = true;

            for (int i = 0; i < this.num_images; i++)
            {
                if (((PictureBox)groupBox1.Controls[i]).Image != this.imageList[i]) { won = false; }
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
                if (((PictureBox)groupBox2.Controls[i]).Name == this.source.Name)
                {
                    ((PictureBox)groupBox2.Controls[i]).Image = this.final.Image;
                }
                
                if (((PictureBox)groupBox1.Controls[i]).Name == this.source.Name)
                {
                    ((PictureBox)groupBox1.Controls[i]).Image = this.final.Image;
                }
            }
        }

        void removeSourceImage()
        {
            for (int i = 0; i < this.num_images; i++)
            {
                if (((PictureBox)groupBox2.Controls[i]).Name == this.source.Name)
                {
                    ((PictureBox)groupBox2.Controls[i]).Image = null;
                }
                
                if (((PictureBox)groupBox1.Controls[i]).Name == this.source.Name)
                {
                    ((PictureBox)groupBox1.Controls[i]).Image = null;
                }
            }
        }

        void SetAllowDrop()
        {
            for (int i = 0; i < this.num_images; i++)
            {
                ((PictureBox)groupBox1.Controls[i]).AllowDrop = true;
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
            this.createPictureBoxes(groupBox1);
            this.createPictureBoxes(groupBox2);
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
            PictureBox obj = (PictureBox)sender;

            if (obj.Image == null)
            {
                return;
            }

            this.source = obj;

            obj.DoDragDrop(obj.Image, DragDropEffects.Copy | DragDropEffects.Move);
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
            tentativas.Text = (Convert.ToInt32(tentativas.Text.ToString()) + 1).ToString();
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
                if (((PictureBox)groupBox2.Controls[i]).Image == null)
                {
                    ((PictureBox)groupBox2.Controls[i]).Image = obj.Image;
                    obj.Image = null;
                }
            }
        }
        private void theWitcherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)theWitcherToolStripMenuItem).Checked = true;
            ((ToolStripMenuItem)starWarsToolStripMenuItem).Checked = false;
            ((ToolStripMenuItem)godOfWarToolStripMenuItem).Checked = false;

            this.imageList = new List<Bitmap>()
        {
            Properties.Resources.sd1,
            Properties.Resources.sd2,
            Properties.Resources.sd3,
            Properties.Resources.sd4,
            Properties.Resources.sd5,
            Properties.Resources.sd6,
            Properties.Resources.sd7,
            Properties.Resources.sd8,
            Properties.Resources.sd9,
        };

            this.Shuffle();
        }

        private void godOfWarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)godOfWarToolStripMenuItem).Checked = true;
            ((ToolStripMenuItem)starWarsToolStripMenuItem).Checked = false;
            ((ToolStripMenuItem)theWitcherToolStripMenuItem).Checked = false;

            this.imageList = new List<Bitmap>()
        {
            Properties.Resources._1,
            Properties.Resources._2,
            Properties.Resources._3,
            Properties.Resources._4,
            Properties.Resources._5,
            Properties.Resources._6,
            Properties.Resources._7,
            Properties.Resources._8,
            Properties.Resources._9,
        };

            this.Shuffle();
        }

        private void starWarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)starWarsToolStripMenuItem).Checked = true;
            ((ToolStripMenuItem)godOfWarToolStripMenuItem).Checked = false;
            ((ToolStripMenuItem)theWitcherToolStripMenuItem).Checked = false;

            this.imageList = new List<Bitmap>()
        {
            Properties.Resources.sw1,
            Properties.Resources.sw2,
            Properties.Resources.sw3,
            Properties.Resources.sw4,
            Properties.Resources.sw5,
            Properties.Resources.sw6,
            Properties.Resources.sw7,
            Properties.Resources.sw8,
            Properties.Resources.sw9,
        };

            this.Shuffle();
        }

        void createPictureBoxes(GroupBox groupBox)
        {
            groupBox.Controls.Clear();

            int breakpoint = Convert.ToInt32(Math.Sqrt(this.num_images));
            int spacing = 45;
            int x = spacing / breakpoint;
            int y = 30;

            int size = ((groupBox.Width - (spacing + (spacing / breakpoint))) / breakpoint);

            for (int i = 0; i < this.num_images; i++)
            {
                if (i == breakpoint || i == (breakpoint * 2) || i == (breakpoint * 3) || i == (breakpoint * 4))
                {
                    x = spacing / breakpoint;
                    y += size + ((spacing + (30 / breakpoint)) / breakpoint);
                }

                PictureBox p = new PictureBox();
                p.Location = new Point(x, y);
                p.Name = "pb" + i;
                p.Size = new Size(size, size);
                p.BorderStyle = BorderStyle.FixedSingle;
                groupBox.Controls.Add(p);

                x += size + (spacing / breakpoint);
            }
        }

        private void médioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.num_images = 16;
            this.createPictureBoxes(groupBox1);
            this.createPictureBoxes(groupBox2);
            this.SetAllowDrop();
            this.setDragDropEvents();
        }

        private void difícilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.num_images = 25;
            this.createPictureBoxes(groupBox1);
            this.createPictureBoxes(groupBox2);
            this.SetAllowDrop();
            this.setDragDropEvents();
        }

        private void fácilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.num_images = 9;
            this.createPictureBoxes(groupBox1);
            this.createPictureBoxes(groupBox2);
            this.SetAllowDrop();
            this.setDragDropEvents();
        }
    }
}