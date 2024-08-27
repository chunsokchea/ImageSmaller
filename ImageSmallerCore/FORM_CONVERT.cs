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

namespace ImageSmallerCore
{
    public partial class FORM_CONVERT : Form
    {
        DataTable dt = new DataTable();
        DataRow dr;
        String[] s1;
        string path1, path2;
        public FORM_CONVERT()
        {
            InitializeComponent();
            listView1.View = View.Details;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
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
                label7.Text = path2;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblPercent.Text = (trackBar1.Value * 5).ToString() + "%";
        }

        private void label3_Click(object sender, EventArgs e)
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

                foreach (ListViewItem itemRow in this.listView1.Items)
                {
                    for (var i = 0; i < itemRow.SubItems.Count; i++)
                    {
                        // MessageBox.Show(itemRow.SubItems[0].Text.ToString());
                        var pathToImage = path1 + $"/{itemRow.SubItems[0].Text.ToString().ToLower()}";
                        var myImage = Image.FromFile(pathToImage, true);
                        var destImagePath = path2 + $"/{itemRow.SubItems[0].Text.ToString().ToLower()}";
                        //SaveJpeg(destImagePath, myImage, trackBar1.Value * 5,comboBox1,Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text));

                        SaveJpeg(destImagePath, myImage, 75, comboBox1, myImage.Width, myImage.Height);
                        Application.DoEvents();
                    }
                    
                }
                
                progressBar1.Value = 100;
                Process.Start("explorer.exe", $"/open, {path2}");
                
                listView1.Clear();
                label5.Text = "";
                label7.Text = "";
                path1 = "";
                path2 = "";
                lblTotal.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" +  ex.ToString());
                
            }
        }
        public static void SaveJpeg(string path, Image img, int quality, ComboBox comboBox, int width, int height)
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
            //width=img.Width;
            //height=img.Height;
            //var nImage = new Image;
            
            //if (comboBox.SelectedIndex == 1)
            //{
            //    if (width > 0 || height>0)
            //    {
            //            ResizeImage(img, width, height).Save(path, jpegCodec, encoderParams);
            //    }
            //    else
            //    {
            //        MessageBox.Show("សូមកំណត់ទំហំរូបភាពម្តងទៀត!");                    
            //        return;
            //    }
            //}
            //else
            //{
            //    img.Save(path, jpegCodec, encoderParams);
            //}
            ResizeImage(img, width, height).Save(path, jpegCodec, encoderParams);
            //nImage.Save(path, jpegCodec, encoderParams);
            //img.Save(path, pngCodec, encoderParams);
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

        private void label8_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemRow in this.listView1.Items)
            {
                for (var i = 0; i < itemRow.SubItems.Count; i++)
                {
                    MessageBox.Show(itemRow.SubItems[0].Text.ToString());
                    // Do something useful here !
                    // e.g 'itemRow.SubItems[count]' <-- Should give you direct access to
                    // the item located at co-ordinates(0,0). Once you got it, do something 
                    // with it.
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            for (int i = 1; i <= 10; i++)
            {
                if ((width / i > 800 && width / i < 1024) && width > height)
                {
                    width = width / i;
                    height = height / i;
                    break;
                }
                else if (height / i > 400 && height / i < 800 && width < height)
                {
                    height = height / i;
                    width = width / i;
                    break ;
                }
            }
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

        private void label5_Click(object sender, EventArgs e)
        {
            var selectFolder = new FolderBrowserDialog();
            if (selectFolder.ShowDialog() == DialogResult.OK)
            {
                path1 = selectFolder.SelectedPath;
                if (path1 == path2)
                {
                    MessageBox.Show("ទីតាំងទាំងពីរដូចគ្នា, សូមរើសទីតាំងថ្មី!");
                    path1 = "";
                }
                label5.Text = path1;
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
                        //dt.Columns.Add("Width");
                        //dt.Columns.Add("Height");
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
                //dr["File_Type"] = f1.Extension;
                //dr["Width"] = f1.;
                //dr["Height"] = "";
                //Get File Size of each file in KB format
                dr["File_Size"] = (f.Length / 1024).ToString() + "KB";
                //Get file Create Date and Time 
                dr["Create_Date"] = f1.CreationTime.Date.ToString("dd/MM/yyyy");
                //Insert collected file details in Datatable
                if (f1.Extension.ToUpper() == ".jpg".ToUpper() || f1.Extension.ToUpper() == ".jpeg".ToUpper()) // || f1.Extension.ToUpper() == ".png".ToUpper() || f1.Extension.ToUpper() == ".gif".ToUpper())
                    dt.Rows.Add(dr);

                if ((f.Length / 1024) > 20000)
                {
                    MessageBox.Show("" + f1.Name + " ធំជាងទំហំដែលកំណត់!.");
                    //listView1.Clear = null;
                    listView1.Clear();
                    dt.Clear();
                    return;
                }
                else
                { }
               

            }
            if (dt.Rows.Count > 0)
            {
                //Finally Add DataTable into DataGridView
                //dataGridView1.DataSource = dt;
                //var data = dt;
                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    var dr = dt.Rows[i];
                    var listitem = new ListViewItem(dr["File_Name"].ToString());
                    listitem.SubItems.Add(dr["File_Type"].ToString());
                    listitem.SubItems.Add(dr["File_Size"].ToString());
                    listitem.SubItems.Add(dr["Create_Date"].ToString());
                    listView1.Items.Add(listitem);
                }                
            }
            lblTotal.Text = dt.Rows.Count.ToString()+" រូប";
            //label4.Text = "សរុប " + (dataGridView1.Rows.Count - 1).ToString();
            //MessageBox.Show(dt.Rows.Count.ToString());
        }
    }
}
