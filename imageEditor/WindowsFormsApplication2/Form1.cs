using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap image = null;

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int X = e.X;
            int Y = e.Y;

            try
            {
                this.textBox1.Text = (image).GetPixel(X, Y).ToString();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFDialog = new OpenFileDialog();

            if (oFDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = oFDialog.FileName;
                image = new Bitmap(fileName);
                this.pictureBox1.Image = image;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap saveImage = new Bitmap(image);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < saveImage.Height; j++)
                {
                    if (saveImage.GetPixel(i, j) == Color.FromArgb(255, 0, 0, 0))
                    {
                        saveImage.SetPixel(i, j, Color.FromArgb(0, 0, 0, 0));
                    }
                }
            }

            SaveFileDialog sFDialog = new SaveFileDialog();

            if (sFDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = sFDialog.FileName;

                saveImage.Save(fileName);
            }
        }
    }
}
