using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace DownSizer
{
    public partial class Downsizer : Form
    {
        private Image selectedImage;

        public Downsizer()
        {
            InitializeComponent();
        }

        private void ChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (.bmp; *.jpg; *.png)|.bmp;*.jpg;*.png|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                selectedImage = Image.FromFile(selectedFile);
                pictureBox.ClientSize = new Size(selectedImage.Width, selectedImage.Height);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Image = selectedImage;
            }
        }

        private void DownsizeImage_Click(object sender, EventArgs e)
        {
            if (selectedImage == null)
            {
                MessageBox.Show("Please select an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double scaleFactor;
            if (!double.TryParse(procenti.Text, out scaleFactor) || scaleFactor <= 0 || scaleFactor > 100)
            {
                MessageBox.Show("Invalid percentage value. Please enter a value between 0 and 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pictureBox.Enabled = false;
            pictureBox.Image = null;

            Bitmap downscaledImage = DownscaleImage(selectedImage, scaleFactor);

            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = downscaledImage;
            pictureBox.ClientSize = new Size(downscaledImage.Width, downscaledImage.Height);

            pictureBox.Enabled = true;

            SaveImageToFile(downscaledImage);
        }

        private Bitmap DownscaleImage(Image originalImage, double scaleFactor)
        {
            int newWidth = (int)(originalImage.Width * scaleFactor / 100.0);
            int newHeight = (int)(originalImage.Height * scaleFactor / 100.0);

            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
            BitmapData sourceData = ((Bitmap)originalImage).LockBits(new Rectangle(0, 0, originalImage.Width, originalImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            BitmapData targetData = resizedImage.LockBits(new Rectangle(0, 0, newWidth, newHeight), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            unsafe
            {
                byte* sourcePointer = (byte*)sourceData.Scan0;
                byte* targetPointer = (byte*)targetData.Scan0;

                for (int y = 0; y < newHeight; y++)
                {
                    for (int x = 0; x < newWidth; x++)
                    {
                        int sourceX = (int)(x * (originalImage.Width / (float)newWidth));
                        int sourceY = (int)(y * (originalImage.Height / (float)newHeight));

                        byte* currentSourcePixel = sourcePointer + (sourceY * sourceData.Stride) + (sourceX * 4);
                        byte* currentTargetPixel = targetPointer + (y * targetData.Stride) + (x * 4);

                        for (int i = 0; i < 4; i++)
                        {
                            currentTargetPixel[i] = currentSourcePixel[i];
                        }
                    }
                }
            }

            resizedImage.UnlockBits(targetData);
            ((Bitmap)originalImage).UnlockBits(sourceData);

            return resizedImage;
        }

        private void SaveImageToFile(Bitmap image)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
            saveFileDialog.Title = "Save Image";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                ImageFormat format = ImageFormat.Png;

                string ext = System.IO.Path.GetExtension(saveFileDialog.FileName);
                switch (ext.ToLower())
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }

                image.Save(saveFileDialog.FileName, format);
            }
        }
    }
}
