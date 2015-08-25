using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.OCR;
using Emgu.CV.Structure;

namespace CharacterRecognition
{
    public partial class MainWnd : Form
    {
        string path;
        public MainWnd()
        {
            InitializeComponent();
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbOcrResult.Clear();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image";
            ofd.Filter = "Image Files(*.png; *.jpg; *.bmp; *.gif)|*.png; *.jpg; *.bmp; *.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = System.IO.Path.GetFullPath(ofd.FileName);
                picBox.Image = new Bitmap(path);
                picBox.SizeMode = PictureBoxSizeMode.Zoom;
                statusLabelOCR.Text = path + " loaded.";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnalyzeImage_Click(object sender, EventArgs e)
        {
            if(picBox.Image == null)
            {
                MessageBox.Show("Load an image first!");
            }
            else
            {
                statusLabelOCR.Text = "Analyzing invoice image...";
                Task.Run(() =>
                {
                    using (var img = new Image<Bgr, byte>(path))
                    {
                        string tessdata = Environment.GetEnvironmentVariable("EMGU_ROOT") + @"\bin\tessdata";
                        using (var ocrProvider = new Tesseract(tessdata, "eng", OcrEngineMode.TesseractCubeCombined))
                        {
                            ocrProvider.Recognize(img);
                            string text = ocrProvider.GetText().TrimEnd();
                            rtbOcrResult.Invoke((MethodInvoker)delegate
                                               {
                                                   statusLabelOCR.Text = "Analysis completed.";
                                                   rtbOcrResult.AppendText(text);
                                               });
                            
                        }
                    }
                });
                
            }
        }
    }
}
