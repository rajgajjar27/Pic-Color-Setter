//Prepared By: RAJ GAJJAR & BHARGAV PATEL
//I.D : 18BSIT012 : RAJ GAJJAR
//    : 18BSIT050 : BHARGAV PATEL

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace PicColorSetter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RedSelection.Value = 128;
            GreenSelection.Value = 128;
            BlueSelection.Value = 128;
            BrightnessSelection.Value = 128;
            SelectedColor.BackColor = Color.FromArgb(RedSelection.Value, GreenSelection.Value, BlueSelection.Value);
            ColorPicture();
        }
        private void scrColorComponent_Scroll(object sender, ScrollEventArgs e)
        {
            SelectedColor.BackColor = Color.FromArgb(RedSelection.Value, GreenSelection.Value, BlueSelection.Value);
            ColorPicture();
        }
        private void ColorPicture()
        {
            picToned.Image = ToColorTone(picOriginal.Image, SelectedColor.BackColor);
        }
        private Bitmap ToColorTone(Image image, Color color)
        {
            float scale = BrightnessSelection.Value / 128f;
            float r = color.R / 255f * scale;
            float g = color.G / 255f * scale;
            float b = color.B / 255f * scale;

            // Color Matrix
            ColorMatrix cm = new ColorMatrix(new float[][]
            {
                new float[] {r, 0, 0, 0, 0},
                new float[] {0, g, 0, 0, 0},
                new float[] {0, 0, b, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
            });
            ImageAttributes ImAttribute = new ImageAttributes();
            ImAttribute.SetColorMatrix(cm);

            //Color Matrix on new image
            Point[] points =
            {
                new Point(0, 0),
                new Point(image.Width - 1, 0),
                new Point(0, image.Height - 1),
            };
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

            Bitmap myBitmap = new Bitmap(image.Width, image.Height);
            using (Graphics graphics = Graphics.FromImage(myBitmap))
            {
                graphics.DrawImage(image, points, rect, GraphicsUnit.Pixel, ImAttribute);
            }
            return myBitmap;
        }

        private void SavePicBtn_Click(object sender, EventArgs e)
        {
            //saving image file
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";

            sfd.ShowDialog();
            string filename = sfd.FileName;
            picToned.Image.Save(filename);        
        }
    }
}
