using System;
using System.Collections;
using System.Security.Cryptography.Pkcs;
using System.Security.Principal;
using System.Windows.Forms;

namespace quebra_cabeca
{
    public partial class Form1 : Form
    {
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
            Properties.Resources.sw9,
        };

        public Form1()
        {
            InitializeComponent();
        }

        void Shuffle()
        {
            
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 });
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)groupBox2.Controls[i]).Image = imageList[j];
                }
            
                for (int i = 0; i < 9; i++)
                {
                    ((PictureBox)groupBox1.Controls[i]).Image = null;
                }
           
        }

        void SetAllowDrop()
        {
            for (int i = 0; i < 9; i++)
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
            this.Shuffle();
            this.SetAllowDrop();
            this.set_pieces();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Shuffle();
            tentativas.Text = "0";
        }

        private void set_pieces()
        {

        }

        private void p1_MouseDown(object sender, MouseEventArgs e)
        {
            if (p1.Image == null)
            {
                return;
            }

            p1.DoDragDrop(p1.Image, DragDropEffects.Copy | DragDropEffects.Move);

            if (DoDragDrop(p1.Image, DragDropEffects.Move) == DragDropEffects.Move || DoDragDrop(p1.Image, DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                p1.Image = null;
                tentativas.Text = (Convert.ToInt32(tentativas.Text.ToString()) + 1).ToString();
            }
        }

        private void p2_MouseDown(object sender, MouseEventArgs e)
        {
            if (p2.Image == null)
            {
                return;
            }

            p2.DoDragDrop(p2.Image, DragDropEffects.Copy | DragDropEffects.Move);

            if (DoDragDrop(p2.Image, DragDropEffects.Move) == DragDropEffects.Move || DoDragDrop(p2.Image, DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                p2.Image = null;
                tentativas.Text = (Convert.ToInt32(tentativas.Text.ToString()) + 1).ToString();
            }
        }

        private void p3_MouseDown(object sender, MouseEventArgs e)
        {
            if (p3.Image == null)
            {
                return;
            }

            p3.DoDragDrop(p3.Image, DragDropEffects.Copy | DragDropEffects.Move);

            if (DoDragDrop(p3.Image, DragDropEffects.Move) == DragDropEffects.Move || DoDragDrop(p3.Image, DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                p3.Image = null;
                tentativas.Text = (Convert.ToInt32(tentativas.Text.ToString()) + 1).ToString();
            }
        }

        private void p4_MouseDown(object sender, MouseEventArgs e)
        {if (p4.Image == null)
            {
                return;
            }
            p4.DoDragDrop(p4.Image, DragDropEffects.Copy | DragDropEffects.Move);

            if (DoDragDrop(p4.Image, DragDropEffects.Move) == DragDropEffects.Move || DoDragDrop(p4.Image, DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                p4.Image = null;
                tentativas.Text = (Convert.ToInt32(tentativas.Text.ToString()) + 1).ToString();
            }
        }

        private void p5_MouseDown(object sender, MouseEventArgs e)
        {if (p5.Image == null)
            {
                return;
            }
            p5.DoDragDrop(p5.Image, DragDropEffects.Copy | DragDropEffects.Move);

            if (DoDragDrop(p5.Image, DragDropEffects.Move) == DragDropEffects.Move || DoDragDrop(p5.Image, DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                p5.Image = null;
                tentativas.Text = (Convert.ToInt32(tentativas.Text.ToString()) + 1).ToString();
            }
        }

        private void p6_MouseDown(object sender, MouseEventArgs e)
        {if (p6.Image == null)
            {
                return;
            }
            p6.DoDragDrop(p6.Image, DragDropEffects.Copy | DragDropEffects.Move);

            if (DoDragDrop(p6.Image, DragDropEffects.Move) == DragDropEffects.Move || DoDragDrop(p6.Image, DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                p6.Image = null;
                tentativas.Text = (Convert.ToInt32(tentativas.Text.ToString()) + 1).ToString();
            }
        }

        private void p7_MouseDown(object sender, MouseEventArgs e)
        {if (p7.Image == null)
            {
                return;
            }
            p7.DoDragDrop(p7.Image, DragDropEffects.Copy | DragDropEffects.Move);

            if (DoDragDrop(p7.Image, DragDropEffects.Move) == DragDropEffects.Move || DoDragDrop(p7.Image, DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                p7.Image = null;
                tentativas.Text = (Convert.ToInt32(tentativas.Text.ToString()) + 1).ToString();
            }
        }

        private void p8_MouseDown(object sender, MouseEventArgs e)
        {if (p8.Image == null)
            {
                return;
            }
            p8.DoDragDrop(p8.Image, DragDropEffects.Copy | DragDropEffects.Move);

            if (DoDragDrop(p8.Image, DragDropEffects.Move) == DragDropEffects.Move || DoDragDrop(p8.Image, DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                p8.Image = null;
                tentativas.Text = (Convert.ToInt32(tentativas.Text.ToString()) + 1).ToString();
            }
        }

        private void p9_MouseDown(object sender, MouseEventArgs e)
        {if (p9.Image == null)
            {
                return;
            }
            p9.DoDragDrop(p9.Image, DragDropEffects.Copy | DragDropEffects.Move);

            if (DoDragDrop(p9.Image, DragDropEffects.Move) == DragDropEffects.Move || DoDragDrop(p9.Image, DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                p9.Image = null;
                tentativas.Text = (Convert.ToInt32(tentativas.Text.ToString()) + 1).ToString();
            }
        }

        private void qc1_DragDrop(object sender, DragEventArgs e)
        {
            qc1.SizeMode = PictureBoxSizeMode.StretchImage;
            qc1.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void qc1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void qc2_DragDrop(object sender, DragEventArgs e)
        {
            qc2.SizeMode = PictureBoxSizeMode.StretchImage;
            qc2.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void qc2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void qc3_DragDrop(object sender, DragEventArgs e)
        {
            qc3.SizeMode = PictureBoxSizeMode.StretchImage;
            qc3.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void qc3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void qc4_DragDrop(object sender, DragEventArgs e)
        {
            qc4.SizeMode = PictureBoxSizeMode.StretchImage;
            qc4.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void qc4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void qc5_DragDrop(object sender, DragEventArgs e)
        {
            qc5.SizeMode = PictureBoxSizeMode.StretchImage;
            qc5.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void qc5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void qc6_DragDrop(object sender, DragEventArgs e)
        {
            qc6.SizeMode = PictureBoxSizeMode.StretchImage;
            qc6.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void qc6_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void qc7_DragDrop(object sender, DragEventArgs e)
        {
            qc7.SizeMode = PictureBoxSizeMode.StretchImage;
            qc7.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void qc7_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void qc8_DragDrop(object sender, DragEventArgs e)
        {
            qc8.SizeMode = PictureBoxSizeMode.StretchImage;
            qc8.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void qc8_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void qc9_DragDrop(object sender, DragEventArgs e)
        {
            qc9.SizeMode = PictureBoxSizeMode.StretchImage;
            qc9.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void qc9_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void qc1_DoubleClick(object sender, EventArgs e)
        {
            if(qc1.Image == null)
            {
                return;
            }

            for (int i = 0; i < 9; i++)
            {
                if (((PictureBox)groupBox2.Controls[i]).Image == null)
                {
                    ((PictureBox)groupBox2.Controls[i]).Image = qc1.Image;
                    qc1.Image = null;
                }
            }
        }

        private void qc2_DoubleClick(object sender, EventArgs e)
        {
            if (qc2.Image == null)
            {
                return;
            }

            for (int i = 0; i < 9; i++)
            {
                if (((PictureBox)groupBox2.Controls[i]).Image == null)
                {
                    ((PictureBox)groupBox2.Controls[i]).Image = qc2.Image;
                    qc2.Image = null;
                }
            }
        }

        private void qc3_DoubleClick(object sender, EventArgs e)
        {
            if (qc3.Image == null)
            {
                return;
            }

            for (int i = 0; i < 9; i++)
            {
                if (((PictureBox)groupBox2.Controls[i]).Image == null)
                {
                    ((PictureBox)groupBox2.Controls[i]).Image = qc3.Image;
                    qc3.Image = null;
                }
            }
        }

        private void qc4_DoubleClick(object sender, EventArgs e)
        {
            if (qc4.Image == null)
            {
                return;
            }

            for (int i = 0; i < 9; i++)
            {
                if (((PictureBox)groupBox2.Controls[i]).Image == null)
                {
                    ((PictureBox)groupBox2.Controls[i]).Image = qc4.Image;
                    qc4.Image = null;
                }
            }
        }

        private void qc5_DoubleClick(object sender, EventArgs e)
        {
            if (qc5.Image == null)
            {
                return;
            }

            for (int i = 0; i < 9; i++)
            {
                if (((PictureBox)groupBox2.Controls[i]).Image == null)
                {
                    ((PictureBox)groupBox2.Controls[i]).Image = qc5.Image;
                    qc5.Image = null;
                }
            }
        }

        private void qc6_DoubleClick(object sender, EventArgs e)
        {
            if (qc6.Image == null)
            {
                return;
            }

            for (int i = 0; i < 9; i++)
            {
                if (((PictureBox)groupBox2.Controls[i]).Image == null)
                {
                    ((PictureBox)groupBox2.Controls[i]).Image = qc6.Image;
                    qc6.Image = null;
                }
            }
        }

        private void qc7_DoubleClick(object sender, EventArgs e)
        {
            if (qc7.Image == null)
            {
                return;
            }

            for (int i = 0; i < 9; i++)
            {
                if (((PictureBox)groupBox2.Controls[i]).Image == null)
                {
                    ((PictureBox)groupBox2.Controls[i]).Image = qc7.Image;
                    qc7.Image = null;
                }
            }
        }

        private void qc8_DoubleClick(object sender, EventArgs e)
        {
            if (qc8.Image == null)
            {
                return;
            }

            for (int i = 0; i < 9; i++)
            {
                if (((PictureBox)groupBox2.Controls[i]).Image == null)
                {
                    ((PictureBox)groupBox2.Controls[i]).Image = qc8.Image;
                    qc8.Image = null;
                }
            }
        }

        private void qc9_DoubleClick(object sender, EventArgs e)
        {
            if (qc9.Image == null)
            {
                return;
            }

            for (int i = 0; i < 9; i++)
            {
                if (((PictureBox)groupBox2.Controls[i]).Image == null)
                {
                    ((PictureBox)groupBox2.Controls[i]).Image = qc9.Image;
                    qc9.Image = null;
                }
            }
        }

        private void theWitcherToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}