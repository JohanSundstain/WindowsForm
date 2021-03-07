using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work3
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        private List<FileInfo> _imagelist;
        private int _imageIndex = 0;
        public Form1()
        {
            InitializeComponent();
       
            _imagelist = new List<FileInfo>();
        }



        private void BtnLeft_Click(object sender, EventArgs e)
        {
           
        }
        
        private void ImageSelector_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            switch(button.Name)
            {
                case "BtnLeft":
                    _imageIndex--;

                    break;
                case "BtnRight":
                    _imageIndex++;
                    break;
                default:
                    break;
            }
            if (_imageIndex < 0)
            {
                _imageIndex = 0;
                return;
            }

            if (_imageIndex > _imagelist.Count() - 1)
            {
                _imageIndex = _imagelist.Count() - 1;
                return;
            }
            ViewImage();
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {

        }

        private void SelectedFolder_Click(object sender, EventArgs e)
        {
            var fd = new FolderBrowserDialog();
            _imagelist.Clear();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                var dInfo = new DirectoryInfo(fd.SelectedPath);
                _imagelist.AddRange(dInfo.GetFiles()
                    .Where(c => c.Extension == ".png" || c.Extension == ".jpg"));
                var fileNames = _imagelist.Select(c => c.FullName).ToList();
                listBox1.Items.Clear();
                foreach (var f in fileNames)
                {
                    listBox1.Items.Add(f);
                }
                ViewImage();
            }
        }

        private void ViewImage()
        {
            var file = _imagelist.ElementAt(_imageIndex);
            var image = Image.FromFile(_imagelist.ElementAt(_imageIndex).FullName);
            bitmap = new Bitmap(_imagelist.ElementAt(_imageIndex).FullName);
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = image;

            //listBox2.Items.Clear();
            //listBox2.Items.Add($"{nameof(file.Name)} - {file.Name}");
            //listBox2.Items.Add($"{nameof(file.FullName)} - {file.FullName}");
            //listBox2.Items.Add($"{nameof(file.Length)} - {file.Length}");
            //listBox2.Items.Add($"{nameof(file.LastAccessTime)} - {file.LastAccessTime}");
            //listBox2.Items.Add($"{nameof(file.LastWriteTime)} - {file.LastWriteTime}");

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lbox = sender as ListBox;
            _imageIndex = lbox.SelectedIndex;
            ViewImage();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return;
            }
            brightness.Text = tbBrightness.Value.ToString();
            if (tbBrightness.Value == 0)
            {
                ViewImage();
                return;
            }
            ViewImage();
            var image = new Bitmap(pictureBox1.Image);

            ImageAttributes imageAttributes = new ImageAttributes();
            int width = image.Width;
            int height = image.Height;
            float[][] colorMatrixElements = {
                                                new float[] {tbBrightness.Value/100.0f, 0, 0, 0, 0},
                                                new float[] {0, tbBrightness.Value / 100.0f, 0, 0, 0},
                                                new float[] {0, 0, tbBrightness.Value / 100.0f, 0, 0},
                                                new float[] {0, 0, 0, 1, 0},
                                                new float[] { 0, 0, 0, 0, 1}
                                            };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

            imageAttributes.SetColorMatrix(
                colorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);
            Graphics graphics = Graphics.FromImage(image);
            graphics.DrawImage(image, new Rectangle(0, 0, width, height), 0, 0, width,
                               height,
                               GraphicsUnit.Pixel,
                               imageAttributes);

            pictureBox1.Image = image;
        }

        private void tbTransparensy_Scroll(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return;
            }
            transparency.Text = tbTransparensy.Value.ToString();
            int v = tbTransparensy.Value;
            if (tbTransparensy.Value ==0)
            {
                ViewImage();
                return;
            }
            ViewImage();
            var image = new Bitmap(pictureBox1.Image);

            ImageAttributes imageAttributes = new ImageAttributes();
            int width = image.Width;
            int height = image.Height;
            float[][] colorMatrixElements = {
                                                new float[] { 1, 0, 0, 0, 0},
                                                new float[] {0, 1, 0, 0, 0},
                                                new float[] {0, 0, 1, 0, 0},
                                                new float[] { 0+tbTransparensy.Value / 100.0f, 0 + tbTransparensy.Value / 100.0f, 0 + tbTransparensy.Value / 100.0f, 1, 0},
                                                new float[] {0, 0, 0, 0, 1 }
                                            };

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

            imageAttributes.SetColorMatrix(
                colorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);
            Graphics graphics = Graphics.FromImage(image);
            graphics.DrawImage(image, new Rectangle(0, 0, width, height), 0, 0, width,
                               height,
                               GraphicsUnit.Pixel,
                               imageAttributes);

            pictureBox1.Image = image;

        }

  


        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return;
            }
            if (checkBox1.Checked)
            {
                bit();
            }
            else
            {
                ViewImage();
                return;
            }
            
        }

        private void bit()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);    
            Random rand = new Random();
                for (int x = 0; x < bmp.Width; ++x)
                {
                    for (int y = 0; y < bmp.Height; ++y)
                    {
                        if (rand.Next(0,5) == 0)
                        {
                            Color curr = Color.FromArgb(rand.Next(0,255), rand.Next(0, 255), rand.Next(0, 255));
                            bmp.SetPixel(x, y, curr);
                        }
                    }
                }     
            pictureBox1.Image = bmp;       
        }

        private void _grey()
        {
            if (pictureBox1.Image != null) //Код функции стырил, сраузу говорю, но зато разобрался как переводить пиксели в серый диапазон 
            {     
                Bitmap input = new Bitmap(pictureBox1.Image);
                
                Bitmap output = new Bitmap(input.Width, input.Height);
                
                for (int j = 0; j < input.Height; j++)
                    for (int i = 0; i < input.Width; i++)
                    {
                      
                        UInt32 pixel = (UInt32)(input.GetPixel(i, j).ToArgb());
                        
                        float R = (float)((pixel & 0x00FF0000) >> 16); // красный
                        float G = (float)((pixel & 0x0000FF00) >> 8); // зеленый
                        float B = (float)(pixel & 0x000000FF); // синий
                                                               
                        R = G = B = (R + G + B) / 3.0f;
                       
                        UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                        
                        output.SetPixel(i, j, Color.FromArgb((int)newPixel));
                    }
                
                pictureBox1.Image = output;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (pictureBox1.Image == null)
            {
                return;
            }
            if (checkBox2.Checked)
            {
                _grey();
            }
            else
            {
                ViewImage();
                return;
            }
        }
    }
}
