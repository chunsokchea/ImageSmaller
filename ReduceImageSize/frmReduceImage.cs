using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReduceImageSize
{
    public partial class frmReduceImage : Form
    {
        DataTable dt = new DataTable();
        DataRow dr;
        String[] s1;
        string path1, path2;
        public frmReduceImage()
        {
            InitializeComponent();           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var selectFolder = new FolderBrowserDialog();
            if (selectFolder.ShowDialog() == DialogResult.OK)
            {
                path2 = selectFolder.SelectedPath;
                if (path1 == path2)
                {
                    MessageBox.Show("ទីតាំងទាំងពីរដូចគ្នា, សូមរើសទីតាំងថ្មី!");
                    path2 = "";
                }
                lblSaveTo.Text = path2;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblPercent.Text = (trackBar1.Value * 5).ToString() + "%";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        public static void SaveJpeg(string path, Image img, int quality)
        {
            if (quality < 0 || quality > 100)
                throw new ArgumentOutOfRangeException("quality must be between 0 and 100.");

            // Encoder parameter for image quality 
            var qualityParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            // JPEG image codec 
            var jpegCodec = GetEncoderInfo("image/jpeg");
            //var pngCodec = GetEncoderInfo("image/png");
            var encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;           
            //var codec=img.
            img.Save(path, jpegCodec, encoderParams);         
        }

        public static void SavePng(string path, Image img, int quality)
        {
            if (quality < 0 || quality > 100)
                throw new ArgumentOutOfRangeException("quality must be between 0 and 100.");

            // Encoder parameter for image quality 
            var qualityParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            // JPEG image codec 
            var jpegCodec = GetEncoderInfo("image/jpeg");
           // var pngCodec = GetEncoderInfo("image/png");
            var encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;
            //var codec=img.
            img.Save(path, jpegCodec, encoderParams);
        }
        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            // Get image codecs for all image formats 
            var codecs = ImageCodecInfo.GetImageEncoders();

            // Find the correct image codec 
            for (var i = 0; i < codecs.Length; i++)
                if (codecs[i].MimeType == mimeType)
                    return codecs[i];

            return null;
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            var selectFolder = new FolderBrowserDialog();
            if (selectFolder.ShowDialog() == DialogResult.OK)
            {
                path1 = selectFolder.SelectedPath;
                if (path1 == path2)
                {
                    MessageBox.Show("ទីតាំងទាំងពីរដូចគ្នា, សូមរើសទីតាំងថ្មី!");
                    path1 = "";
                }
                lblSource.Text = path1;
            }
            s1 = Directory.GetFiles(path1);
            for (var i = 0; i <= s1.Length - 1; i++)
            {
                try
                {
                    if (i == 0)
                    {
                        //Add Data Grid Columns with name
                        dt.Columns.Add("File_Name");
                        dt.Columns.Add("File_Type");
                        dt.Columns.Add("File_Size");
                        dt.Columns.Add("Create_Date");
                    }
                }
                catch (Exception)
                {
                    //throw;
                }

                //Get each file information
                var f = new FileInfo(s1[i]);
                FileSystemInfo f1 = new FileInfo(s1[i]);

                dr = dt.NewRow();
                //Get File name of each file name
                dr["File_Name"] = f1.Name;
                //Get File Type/Extension of each file 
                dr["File_Type"] = f1.Extension;
                //Get File Size of each file in KB format
                dr["File_Size"] = (f.Length / 1024).ToString() + "KB";
                //Get file Create Date and Time 
                dr["Create_Date"] = f1.CreationTime.Date.ToString("dd/MM/yyyy");
                //Insert collected file details in Datatable
                if (f1.Extension.ToUpper() == ".jpg".ToUpper() || f1.Extension.ToUpper() == ".jpeg".ToUpper()) 
                    dt.Rows.Add(dr);
                else if(f1.Extension.ToUpper() == ".png".ToUpper())
                    dt.Rows.Add(dr);

                if ((f.Length / 1024) > 20000)
                {
                    MessageBox.Show("" + f1.Name + " ធំជាងទំហំដែលកំណត់!.");                    
                    dt.Clear();
                    return;
                }
                else
                { }


            }
            if (dt.Rows.Count > 0)
            {                
                dataGridView1.DataSource = dt;
            }
            lblTotal.Text = dt.Rows.Count.ToString() + " រូប";            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (path2 == "")
            {
                MessageBox.Show("សូមរើសទីតាំងទុករូបភាពបំលែងរួច!");
                return;
            }
            else if (path1 == "")
            {
                MessageBox.Show("សូមរើសទីតាំងរូបភាពដែលត្រូវបំលែង!");
                return;
            }
            try
            {
                progressBar1.Value = 0;
                progressBar1.Maximum = dataGridView1.Rows.Count;                
                foreach (DataGridViewRow itemRow in this.dataGridView1.Rows)
                {
                    progressBar1.Value += 1;
                    var pathToImage = path1 + $"/{itemRow.Cells["File_Name"].Value.ToString().ToLower()}";
                    var myImage = Image.FromFile(pathToImage, true);
                    var destImagePath = path2 + $"/{itemRow.Cells["File_Name"].Value.ToString().ToLower()}";

                    //MessageBox.Show(itemRow.Cells["File_Type"].Value.ToString().ToLower());
                    if (itemRow.Cells["File_Type"].Value.ToString().ToLower() == ".png")
                    {
                        for (int i = 5; i > 0; i--)
                        {
                            if (myImage.Height < myImage.Width)
                            {
                                if (myImage.Height / i > 1000 && myImage.Height / i < 2000)
                                {
                                    int newWidth = myImage.Width / i;
                                    int newHeight = myImage.Height / i;
                                    var newimg = ResizeImage(myImage, newWidth, newHeight);
                                    SavePng(destImagePath, newimg, trackBar1.Value * 5);
                                    break;
                                }
                                else
                                {
                                    if (i == 1)
                                    {
                                        SavePng(destImagePath, myImage, trackBar1.Value * 5);
                                        //progressBar1.Value += 1;
                                        break;
                                    }

                                }
                            }
                            else
                            {
                                if (myImage.Width / i > 1000 && myImage.Width / i < 2000)
                                {
                                    int newWidth = myImage.Width / i;
                                    int newHeight = myImage.Height / i;
                                    var newimg = ResizeImage(myImage, newWidth, newHeight);
                                    SavePng(destImagePath, newimg, trackBar1.Value * 5);
                                    break;
                                }
                                else
                                {
                                    if (i == 1)
                                    {
                                        SavePng(destImagePath, myImage, trackBar1.Value * 5);
                                        //progressBar1.Value += 1;
                                        break;
                                    }
                                }
                            }                                                      

                        }
                        
                    }
                    else
                    {
                        for (int i = 5; i > 0; i--)
                        {
                            if (myImage.Height < myImage.Width)
                            {
                                if (myImage.Height / i > 1000 && myImage.Height / i < 2000)
                                {
                                    int newWidth = myImage.Width / i;
                                    int newHeight = myImage.Height / i;
                                    var newimg = ResizeImage(myImage, newWidth, newHeight);
                                    SaveJpeg(destImagePath, newimg, trackBar1.Value * 5);
                                    break;
                                }
                                else
                                {
                                    if (i == 1)
                                    {
                                        SaveJpeg(destImagePath, myImage, trackBar1.Value * 5);
                                        //progressBar1.Value += 1;
                                        break;
                                    }

                                }
                            }
                            else
                            {
                                if (myImage.Width / i > 1000 && myImage.Width / i < 2000)
                                {
                                    int newWidth = myImage.Width / i;
                                    int newHeight = myImage.Height / i;
                                    var newimg = ResizeImage(myImage, newWidth, newHeight);
                                    SaveJpeg(destImagePath, newimg, trackBar1.Value * 5);
                                    break;
                                }
                                else
                                {
                                    if (i == 1)
                                    {
                                        SaveJpeg(destImagePath, myImage, trackBar1.Value * 5);
                                        //progressBar1.Value += 1;
                                        break;
                                    }
                                }
                            }

                        }

                    }

                    if (myImage.Height / 1.5 > 1000 && myImage.Height / 2 < 1000)
                    {
                        double newWidth = myImage.Width / 1.6;
                        double newHeight = myImage.Height / 1.6;
                        var newimg = ResizeImage(myImage, (int)newWidth, (int)newHeight);
                        SavePng(destImagePath, newimg, trackBar1.Value * 5);
                        //break;
                    }
                    //Application.DoEvents();
                }
                                
                Process.Start("explorer.exe", $"/open, {path2}");
                
                dataGridView1.DataSource = null;
                lblSaveTo.Text = "";
                lblPercent.Text = "";
                path1 = "";
                path2 = "";
                lblTotal.Text = "";
                lblPercent.Text = trackBar1.Value * 5 + "%";
                progressBar1.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.ToString());                
            }
        }

        private void frmReduceImage_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }
    }
}
