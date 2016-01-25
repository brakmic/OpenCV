using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.Serialization;
using System.Xml.Linq;
using System.Xml.Serialization;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;

namespace CharacterRecognition2
{
    //this is still in development...no real OCR for now.
    //just a few tests with images
    public partial class MainWnd : Form
    {
        private Image<Bgr, Byte> myImage;
        public MainWnd()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath;
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Select an image",
                Filter = "Image Files(*.png; *.jpg; *.bmp; *.gif)|*.png; *.jpg; *.bmp; *.gif"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = System.IO.Path.GetFullPath(ofd.FileName);
                myImage = new Image<Bgr, byte>(filePath);
                
                picBox.SizeMode = PictureBoxSizeMode.Zoom;
                picBox.Image = myImage.ToBitmap();
                toolStripStatusLabel1.Text = ofd.FileName + " loaded.";
            }
        }

        private void btnToGray_Click(object sender, EventArgs e)
        {
            var gray = myImage.Convert<Gray, Byte>().Convert<Gray, double>();
            picBox.Image = gray.ToBitmap();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            if (myImage != null)
            {
                picBox.Image = myImage.ToBitmap();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (myImage == null)
            {
                MessageBox.Show("No image available!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            var sfd = new SaveFileDialog
            {
                Title = "Serialize image to XML",
                Filter = "XML Files(*.xml)|*.xml"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer ser = new XmlSerializer(typeof (Image<Bgr, Byte>));
                
                using (var writer = XmlWriter.Create(sfd.FileName))
                {
                    ser.Serialize(writer, myImage);
                }
                toolStripStatusLabel1.Text = sfd.FileName + " saved.";
            }

        }

        private void openFromXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath;
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Select an XML file",
                Filter = "XML Files(*.xml)|*.xml"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = System.IO.Path.GetFullPath(ofd.FileName);
                XmlSerializer ser = new XmlSerializer(typeof(Image<Bgr, Byte>));

                using (XmlReader newReader = XmlReader.Create(new FileStream(filePath, FileMode.Open)))
                {
                    Image<Bgr, Byte> image = ser.Deserialize(newReader) as Image<Bgr, Byte>;
                    picBox.SizeMode = PictureBoxSizeMode.Zoom;
                    picBox.Image = image.ToBitmap();
                    myImage = image;
                }
                toolStripStatusLabel1.Text = ofd.FileName + " loaded.";
            }
        }
    }
}
