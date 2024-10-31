using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static Processing.Form1;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;
using Font = System.Drawing.Font;
using Image = System.Drawing.Image;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Processing
{
    public partial class Form1 : Form
    {
     
        Image originalImage;
        Image newImage;
        Image n_newImage;
        public Form1()
        {
            InitializeComponent();
            
        }

        Boolean opened = false;

        public PrintPageEventHandler printDocument_PrintPage { get; private set; }
        void open()
        {
            OpenFileDialog open = new OpenFileDialog();
            this.AutoScroll = true;
            double zoomFactor = 1.0;
          /*  this.AutoScrollMinSize = new Size(Convert.ToInt32(currentImgHandler.CurrentBitmap.Width * zoomFactor), Convert.ToInt32(currentImgHandler.CurrentBitmap.Width * zoomFactor));*/
            this.Invalidate();
            open.Filter = "Image Files(*.jpg; *jpeg; *.gif; *.bmp)| *.jpg; *jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(open.FileName);
                pictureBox1.Image = originalImage;
                opened = true;
            }
        }
        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message, "Image Processing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ProcessBitmap(ColorMatrix colorMatrix)
        {
            if (originalImage != null)
            {
                Bitmap bmap = new Bitmap(originalImage.Width, originalImage.Height);
                using (Graphics g = Graphics.FromImage(bmap))
                {
                    ImageAttributes imageAttributes = new ImageAttributes();
                    imageAttributes.SetColorMatrix(colorMatrix);
                    g.DrawImage(originalImage, new Rectangle(0, 0, bmap.Width, bmap.Height), 0, 0, bmap.Width, bmap.Height, GraphicsUnit.Pixel, imageAttributes);
                }
                pictureBox1.Image = bmap;
            }
        }
        void saveImage()
        {
            if (opened)
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "Images|*.png;*.bmp;*jpg";
                ImageFormat format = ImageFormat.Png;

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".png":
                            format = ImageFormat.Png;
                            break;
                    }
                    pictureBox1.Image.Save(sfd.FileName, format);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message, "Image Processing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Print()
        {
            PrintDocument printDocument = new PrintDocument();
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.PrintPage += printDocument_PrintPage;
                printDocument.Print();
            }
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void SetBrightness(int brightness)
        {
            if (brightness < -255) brightness = -255; // Corrected condition
            if (brightness > 255) brightness = 255;
            ColorMatrix newMatrix = new ColorMatrix(CurrentColorMatrix.Array); 
            newMatrix.Matrix40 = newMatrix.Matrix41 = newMatrix.Matrix42 = brightness / 255.0F;
            ProcessBitmap(newMatrix);
        }
        private void UndoChanges()
        {
            if (originalImage != null)
            {
                pictureBox1.Image = (Image)originalImage.Clone();
            }
        }
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoChanges();
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar3.Value = 0;
        }
        private void clearImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
        public void Zoom(double size)
        {
            double zoomFactor = (double)size;
            Size newSize = new Size((int)(pictureBox1.Image.Width * zoomFactor), (int)(pictureBox1.Image.Height * zoomFactor));
            Bitmap bmp = new Bitmap(pictureBox1.Image, newSize);
            pictureBox1.Image = bmp;
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UndoChanges();
            Zoom(0.25);
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            UndoChanges();
            Zoom(0.50);
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            UndoChanges();
            Zoom(1.00);
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            UndoChanges();
            Zoom(1.5);
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            UndoChanges();
            Zoom(2.00);
        }
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            UndoChanges();
            Zoom(3.00);
        }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            UndoChanges();
            Zoom(4.00);
        }
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            UndoChanges();
            Zoom(5.0);
        }
        private class CurrentColorMatrix
        {
            public static float[][] Array =
            {
                                    new float[]{1,0,0,0,0},
                                    new float[]{0,1,0,0,0},
                                    new float[]{0,0,1,0,0},
                                    new float[]{0,0,0,1,0},
                                    new float[]{0,0,0,0,1},
            };
        }
        void Red()
        {
            UndoChanges();
            Image img = pictureBox1.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

            ColorMatrix cmPicture = new ColorMatrix(new float[][]
            {
                       new float[] {2,  0,  0,  0, 0},        // red scaling factor of 2
                       new float[] {0,  1,  0,  0, 0},        // green scaling factor of 1
                       new float[] {0,  0,  1,  0, 0},        // blue scaling factor of 1
                       new float[] {0,  0,  0,  1, 0},        // alpha scaling factor of 1
                       new float[] {0,  0,  0,  0, 1}
            });
            ImageAttributes ia = new ImageAttributes();
            ia.SetColorMatrix(cmPicture);
            Graphics g = Graphics.FromImage(bmpInverted);

            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            pictureBox1.Image = bmpInverted;
        }
        private void redFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Red();
        }
        void greyScale()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                UndoChanges();
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                     new float[] {.3f, .3f, .3f, 0, 0},         //red
                     new float[] {.59f, .59f, .59f, 0, 0},      //green
                     new float[] {.11f, .11f, .11f, 0, 0},      //blue
                     new float[] {0, 0, 0, 1, 0},               //alpha
                     new float[] {0, 0, 0, 0, 1}                //three translations 
                });
                ImageAttributes ia = new ImageAttributes();
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }
        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            greyScale();
        }
        private void AdjustContrast(Bitmap bitmap, float contrast)
        {
            UndoChanges();
            Image img = pictureBox1.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            if (contrast < -100) contrast = -100;
            if (contrast > 100) contrast = 100;

            contrast = (100.0F + contrast) / 100.0F;

            ColorMatrix cmPicture = new ColorMatrix(new float[][]
            {
                                    new float[] { contrast, 0, 0, 0, 0 },
                                    new float[] { 0, contrast, 0, 0, 0 },
                                    new float[] { 0, 0, contrast, 0, 0 },
                                    new float[] { 0, 0, 0, 1, 0 },
                                    new float[] { 0, 0, 0, 0, 1 }
            });
            ImageAttributes ia = new ImageAttributes();
            ia.SetColorMatrix(cmPicture);
            Graphics g = Graphics.FromImage(bmpInverted);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            pictureBox1.Image = bmpInverted;
        }

        public void contrastToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void ApplyColorMatrix(Bitmap bitmap, float[][] matrix)
        {
            if (bitmap != null)
            {
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(new ColorMatrix(matrix));

                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.DrawImage(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                        0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel, attributes);
                }
            }
        }

        private void NegativeImage()
        {
            UndoChanges();
            Image img = pictureBox1.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
                    {
               new float[] {-1, 0, 0, 0, 0},
               new float[] {0, -1, 0, 0, 0},
               new float[] {0, 0, -1, 0, 0},
               new float[] {0, 0, 0,  1, 0},
               new float[] {1, 1, 1,  0, 1}
                    });
            ia.SetColorMatrix(cmPicture);
            Graphics g = Graphics.FromImage(bmpInverted);

            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            pictureBox1.Image = bmpInverted;
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NegativeImage();
        }

        void Green()
        {
            UndoChanges();
            Image img = pictureBox1.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
                    {
               new float[] {1, 0, 0, 0, 0},
               new float[] {0, 2, 0, 0, 0},
               new float[] {0, 0, 1, 0, 0},
               new float[] {0, 0, 0, 1, 0},
               new float[] {0, 0, 0, 0, 1}
                    });

            ia.SetColorMatrix(cmPicture);
            Graphics g = Graphics.FromImage(bmpInverted);

            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            pictureBox1.Image = bmpInverted;
        }
        private void greenFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Green();
        }
        void Blue()
        {
            UndoChanges();
            Image img = pictureBox1.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
                    {
               new float[] {0.25f, 0, 0, 0, 0},
               new float[] {0, 1, 0, 0, 0},
               new float[] {0, 0, 2, 0, 0},
               new float[] {0, 0, 0, 1, 0},
               new float[] {0, 0, 0, 0, 1}
                   });

            ia.SetColorMatrix(cmPicture);
            Graphics g = Graphics.FromImage(bmpInverted);

            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            pictureBox1.Image = bmpInverted;
        }
        private void blueFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blue();
        }
        void Sepia()
        {
            UndoChanges();
            Image img = pictureBox1.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
                    {
               new float[] {0.393f, 0.349f, 0.272f, 0, 0},
               new float[] {0.769f, 0.686f, 0.534f, 0, 0},
               new float[] {0.189f, 0.168f, 0.131f, 0, 0},
               new float[] {0, 0, 0, 1, 0},
               new float[] {0, 0, 0, 0, 1}
                    });
            ia.SetColorMatrix(cmPicture);
            Graphics g = Graphics.FromImage(bmpInverted);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            pictureBox1.Image = bmpInverted;
        }
        private void sepiaToneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sepia();
        }
        private void InsertText(string text, Font font, Color color, PointF position)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bitmap = (Bitmap)pictureBox1.Image.Clone();
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Brush brush = new SolidBrush(color))
                    {
                        graphics.DrawString(text, font, brush, position);
                    }
                }
                pictureBox1.Image = bitmap;
            }
        }
        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = Microsoft.VisualBasic.Interaction.InputBox("Enter text:", "Text Insertion");

            if (!string.IsNullOrEmpty(text))
            {
                FontDialog fontDialog = new FontDialog();

                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    Font font = fontDialog.Font;

                    ColorDialog colorDialog = new ColorDialog();
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        Color color = colorDialog.Color;
                        PointF position = new PointF(10, 10); // Starts inserting text at this position
                        InsertText(text, font, color, position);
                    }
                }
            }
        }
        public static Bitmap HorizontalFlip(Bitmap bitmap)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;

            Bitmap flippedBitmap = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = bitmap.GetPixel(x, y);
                    flippedBitmap.SetPixel(width - 1 - x, y, originalColor);
                }
            }
            return flippedBitmap;
        }
        private void flipHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            pictureBox1.Image = HorizontalFlip(bitmap);
        }
        void Alpha(float alpha)
        {
            UndoChanges();
            Image img = pictureBox1.Image;

            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            if (alpha < -100) alpha = -100;
            if (alpha > 100) alpha = 100;

            alpha = (100.0F + alpha) / 100.0F;

            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
                    {
               new float[] {1, 0, 0, 0, 0},
               new float[] {0, 1, 0, 0, 0},
               new float[] {0, 0, 1, 0, 0},
               new float[] {0, 0, 0, alpha, 0},
               new float[] {0, 0, 0, 0, 1}
                    });

            ia.SetColorMatrix(cmPicture);
            Graphics g = Graphics.FromImage(bmpInverted);

            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            pictureBox1.Image = bmpInverted;
        }
        private void alphaFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void textToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string text = Microsoft.VisualBasic.Interaction.InputBox("Enter text:", "Text Insertion");

            if (!string.IsNullOrEmpty(text))
            {
                using (FontDialog fontDialog = new FontDialog())
                {
                    if (fontDialog.ShowDialog() == DialogResult.OK)
                    {
                        Font font = fontDialog.Font;

                        using (ColorDialog colorDialog = new ColorDialog())
                        {
                            if (colorDialog.ShowDialog() == DialogResult.OK)
                            {
                                Color color = colorDialog.Color;
                                PointF position = new PointF(10, 10);
                                InsertText(text, font, color, position);
                            }
                        }
                    }
                }
            }
        }
        private static double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        private Bitmap RotateBitmap(Bitmap bitmap, float angle)
        {
            float angleRad = angle * (float)Math.PI / 180.0f;
            float cosTheta = (float)Math.Cos(angleRad);
            float sinTheta = (float)Math.Sin(angleRad);

            float centerX = bitmap.Width / 2.0f;
            float centerY = bitmap.Height / 2.0f;

            Bitmap rotatedBitmap = new Bitmap(bitmap.Width, bitmap.Height);

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    float offsetX = x - centerX;
                    float offsetY = y - centerY;

                    int newX = (int)(offsetX * cosTheta - offsetY * sinTheta + centerX);
                    int newY = (int)(offsetX * sinTheta + offsetY * cosTheta + centerY);

                    if (newX >= 0 && newX < rotatedBitmap.Width && newY >= 0 && newY < rotatedBitmap.Height)
                    {
                        rotatedBitmap.SetPixel(newX, newY, bitmap.GetPixel(x, y));
                    }
                }
            }
            return rotatedBitmap;
        }
        private void rotateBitmapByAngle(float angle)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap originalBitmap = (Bitmap)pictureBox1.Image;
                Bitmap rotatedBitmap = RotateBitmap(originalBitmap, angle);
                pictureBox1.Image = rotatedBitmap;
            }
        }
        private void rotate90DegreesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UndoChanges();
            rotateBitmapByAngle(90);
        }
        private void rotate180DegreesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoChanges();
            rotateBitmapByAngle(180);
        }

        private void rotate270DegreesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rotateBitmapByAngle(270);
        }

        private void InsertBitmapAtPosition()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmapToInsert = new Bitmap(openFileDialog.FileName);
                    string inputX = Microsoft.VisualBasic.Interaction.InputBox("Enter X coordinate:", "Position Input", "0");
                    string inputY = Microsoft.VisualBasic.Interaction.InputBox("Enter Y coordinate:", "Position Input", "0");
                    int x, y;
                    if (int.TryParse(inputX, out x) && int.TryParse(inputY, out y))
                    {
                        Point position = new Point(x, y);
                        InsertImageAtPosition((Bitmap)pictureBox1.Image, bitmapToInsert, position);
                    }
                    else
                    {
                        MessageBox.Show("Invalid input for position. Please enter valid integer coordinates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while inserting the bitmap: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertImageAtPosition(Bitmap originalBitmap, Bitmap bitmapToInsert, Point position)
        {
            try
            {
                using (Graphics g = Graphics.FromImage(originalBitmap))
                {
                    g.DrawImage(bitmapToInsert, position);
                }
                pictureBox1.Image = originalBitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while inserting the bitmap: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void imageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InsertBitmapAtPosition();
        }
        private void bitmapViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void thumbnailViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            Thumbnail_View thumbnailViewForm = new Thumbnail_View();
            thumbnailViewForm.SetBitmap(bitmap); // Pass the bitmap to the thumbnail view form
            thumbnailViewForm.ShowDialog(); 
        }
        private Bitmap ResizeImage(Bitmap image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }
        
       
        public static Bitmap Resize(Bitmap bitmap, int maxWidth, int maxHeight)
        {
            int originalWidth = bitmap.Width;
            int originalHeight = bitmap.Height;

            
            double widthFactor = (double)maxWidth / originalWidth;
            double heightFactor = (double)maxHeight / originalHeight;

            double factor = Math.Min(widthFactor, heightFactor);

            int newWidth = (int)(originalWidth * factor);
            int newHeight = (int)(originalHeight * factor);

            Bitmap resizedBitmap = new Bitmap(newWidth, newHeight);

            
            for (int y = 0; y < newHeight; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    // Calculate the corresponding position in the original image
                    int originalX = (int)(x / factor);
                    int originalY = (int)(y / factor);

                    // Ensure the coordinates are within the bounds of the original image
                    originalX = Math.Min(originalX, originalWidth - 1);
                    originalY = Math.Min(originalY, originalHeight - 1);

                
                    Color pixelColor = bitmap.GetPixel(originalX, originalY);

                    resizedBitmap.SetPixel(x, y, pixelColor);
                }
            }
            return resizedBitmap;
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = pictureBox1.Image as Bitmap; // Cast to Bitmap
            if (bitmap == null)
            {
                MessageBox.Show("No valid image found in the PictureBox.");
                return;
            }

            using (Resize resizeForm = new Resize())
            {
                if (resizeForm.ShowDialog() == DialogResult.OK)
                {
                    int height = resizeForm.HeightValue;
                    int width = resizeForm.WidthValue;
                    pictureBox1.Image = Resize(bitmap, width, height);
                }
            }
        }


        public static Bitmap VerticalFlip(Bitmap bitmap)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;

            Bitmap flippedBitmap = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color originalColor = bitmap.GetPixel(x, y);
                    flippedBitmap.SetPixel(x, height - 1 - y, originalColor);
                }
            }
            return flippedBitmap;
        }
        private void flipVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            pictureBox1.Image = VerticalFlip(bitmap);
        }
        private void shapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void cropToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int brightness;
            brightness = trackBar1.Value;
            SetBrightness(brightness);
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            int brightness = trackBar3.Value;
            SetBrightness(brightness);
        }
        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            float contrast = (float)trackBar1.Value;
            AdjustContrast(bitmap, contrast);
        }
        private void trackBar2_Scroll_1(object sender, EventArgs e)
        {
            float alpha = (float)trackBar2.Value;
            Alpha(alpha);
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            CurrentImageHandler currentImgHandler;
            Graphics g = e.Graphics;
        }
        private void customRotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = (Bitmap)pictureBox1.Image;

            string angleInput = Microsoft.VisualBasic.Interaction.InputBox("Enter angle of rotation:", "Angle Input", "0");

            if (float.TryParse(angleInput, out float angle))
            {
                float angleRad = angle * (float)Math.PI / 180.0f;

                int width = originalImage.Width;
                int height = originalImage.Height;          //finding dimensions of binding box to accommodate full rotation
                int rotatedWidth = (int)(Math.Abs(Math.Cos(angleRad)) * width + Math.Abs(Math.Sin(angleRad)) * height);
                int rotatedHeight = (int)(Math.Abs(Math.Sin(angleRad)) * width + Math.Abs(Math.Cos(angleRad)) * height);

                Bitmap rotatedImage = new Bitmap(rotatedWidth, rotatedHeight);

                for (int x = 0; x < rotatedWidth; x++)
                {
                    for (int y = 0; y < rotatedHeight; y++)
                    {                     //apply rotation    after          //bring to center                         //re-shift by adding/ get into original co-ordinate system

                        float originalX = (float)(Math.Cos(angleRad) * (x - rotatedWidth / 2) - Math.Sin(angleRad) * (y - rotatedHeight / 2) + width / 2);
                        float originalY = (float)(Math.Sin(angleRad) * (x - rotatedWidth / 2) + Math.Cos(angleRad) * (y - rotatedHeight / 2) + height / 2);

                        if (originalX >= 0 && originalX < width && originalY >= 0 && originalY < height)
                        {
                            Color pixelColor = originalImage.GetPixel((int)originalX, (int)originalY);
                            rotatedImage.SetPixel(x, y, pixelColor);
                        }
                    }
                }

                Form form = new Form();
                form.Text = "Rotated Image";

                form.ClientSize = new Size(rotatedWidth, rotatedHeight);

                form.Paint += (sender, pe) =>
                {
                    pe.Graphics.DrawImage(rotatedImage, 0, 0);
                };
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid angle input. Please enter a valid numeric angle.");
            }
        }

        private void checkersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            this.AutoScroll = true;
            //   this.AutoScrollMinSize = new Size(Convert.ToInt32(currentImgHandler.CurrentBitmap.Width * zoomFactor), Convert.ToInt32(currentImgHandler.CurrentBitmap.Width * zoomFactor));
            this.Invalidate();
            open.Filter = "Image Files(*.jpg; *jpeg; *.gif; *.bmp)| *.jpg; *jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                newImage = new Bitmap(open.FileName);

                opened = true;
            }

            Bitmap image1 = new Bitmap(originalImage);
            Bitmap image2 = new Bitmap(newImage);
            int hf_width = (image1.Width) / 2;
            int hf_height = (image1.Height) / 2;
            int fl_width = image1.Width;
            int fl_height = image1.Width;
            for (int x = 0; x < hf_width; x++)
            {
                for (int y = 0; y < hf_height; y++)
                {
                    Color clr = image2.GetPixel(x, y);
                    Color newclr = Color.FromArgb(255, clr.R, clr.G, clr.B);
                    image1.SetPixel(x, y, newclr);
                }
            }

            for (int x = hf_width; x < fl_width; x++)
            {
                for (int y = hf_height; y < fl_height; y++)
                {
                    Color clr = image2.GetPixel(x, y);
                    Color newclr = Color.FromArgb(255, clr.R, clr.G, clr.B);
                    image1.SetPixel(x, y, newclr);
                }
            }

            pictureBox1.Image = image1;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            if (opened)
            {
                Bitmap image1 = new Bitmap(originalImage);
                Bitmap image2 = new Bitmap(newImage);
                int width = image1.Width;
                int height = image1.Width;
                Bitmap image3 = new Bitmap(width, height);
                int now = trackBar1.Value;

                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {

                        Color clr1 = image1.GetPixel(i, j);
                        Color clr2 = image2.GetPixel(i, j);
                        Color newclr = Color.FromArgb(255, (clr1.R * (100 - now) + (clr2.R * now)) / 100, (clr1.G * (100 - now) + (clr2.G * now)) / 100, (clr1.B * (100 - now) + (clr2.B * now)) / 100);
                        image3.SetPixel(i, j, newclr);
                    }
                }
                pictureBox1.Image = image3;
            }
            else
            {

                MessageBox.Show("Load a second Image...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            this.AutoScroll = true;
            this.Invalidate();
            open.Filter = "Image Files(*.jpg; *jpeg; *.gif; *.bmp)| *.jpg; *jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                newImage = new Bitmap(open.FileName);

                opened = true;
            }

            originalImage = pictureBox1.Image;

        }

        private void mergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Merge merge = new Merge())
            {
                if (merge.ShowDialog() == DialogResult.OK)
                {
                   
                }
            }
        }
    }
}
 


