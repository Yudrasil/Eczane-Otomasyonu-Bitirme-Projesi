using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace eczane_otomasyonu_deneme
{
    public partial class brkd : Form
    {
        public brkd()
        {
            InitializeComponent();
        }
        FilterInfoCollection fic;
        VideoCaptureDevice vcd=new VideoCaptureDevice();
        public string barkod = "";
        int i = 0;

        private void brkd_Load(object sender, EventArgs e)
        {
            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            for (int i = 0; i < fic.Count; i++)
            {
                comboBox1.Items.Add(fic[i].Name);
            }
        }
        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcode = new BarcodeReader();
                Result result = barcode.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    barkod = result.ToString();
                    vcd.Stop();
                    timer1.Stop();
                    Close();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                vcd.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            timer1.Stop();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fic[comboBox1.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timer1.Start();
        }
    }
}
