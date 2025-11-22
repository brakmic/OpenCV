using System;
using System.Drawing;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using System.Windows.Forms;
using OcrApp.Services;

namespace OcrApp.Forms
{
    [SupportedOSPlatform("windows6.1")]
    public partial class MainWnd : Form
    {
        private readonly IOcrService ocrService;
        private string? path;

        public MainWnd(IOcrService ocrService)
        {
            InitializeComponent();
            this.ocrService = ocrService;
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

        private async void btnAnalyzeImage_Click(object sender, EventArgs e)
        {
            if(picBox.Image == null)
            {
                MessageBox.Show("Load an image first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            statusLabelOCR.Text = "Analyzing invoice image...";
            btnAnalyzeImage.Enabled = false;

            try
            {
                string result = await Task.Run(() => ocrService.ExtractText(path!));
                rtbOcrResult.Text = result;
                statusLabelOCR.Text = "Analysis completed.";
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show($"Image file not found: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabelOCR.Text = "Analysis failed.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"OCR processing failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabelOCR.Text = "Analysis failed.";
            }
            finally
            {
                btnAnalyzeImage.Enabled = true;
            }
        }
    }
}
