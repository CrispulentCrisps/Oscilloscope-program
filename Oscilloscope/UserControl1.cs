using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using System.Windows.Forms;
//https://www.youtube.com/watch?v=ZnFoVuOVrUQ tutorial
namespace Oscilloscope
{
    public partial class Form1: Form//MUST DERIVE FROM FORM!!!
    {
        long ByteLength = 16777216;
        int SamplingDivider = 4;
        public bool WaveformLoaded = false;
        public Form1()
        {
            InitializeComponent();
        }
        //Need to keep else code fucking dies
        private void UserControl1_Load(object sender, EventArgs e)
        {
            LoadLabel.Visible = true;
            chart1.Series.Clear();
            this.Left = 0;
            this.Top = 0;
            SampRateDrop.SelectedIndex = 0;
            QualityDrop.SelectedIndex = 0;
        }
        //Need to keep else code fucking dies
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
        //Need to keep else code fucking dies
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadLabel.Visible = false;
            LoadingLabel.Visible = true;
            //Opening wave file
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Wave file (*.wav) | *.wav";
            if (open.ShowDialog() != DialogResult.OK) return;
            //Loads file onto wave viewer
            chart1.Series.Clear();
            chart1.Series.Add("wave");
            chart1.Series["wave"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart1.Series["wave"].ChartArea = "ChartArea1";
            NAudio.Wave.WaveChannel32 wave = new NAudio.Wave.WaveChannel32(new NAudio.Wave.WaveFileReader(open.FileName));
            //Sizing wave to Programs width
            int read = 0;
            //Validation check for options
            byte[] buffer = new byte[ByteLength];
            while (wave.Position < wave.Length)
            {
                //Sampling
                read = wave.Read(buffer, 0, buffer.Length);
                for (int i = 0; i < read / SamplingDivider; i++)
                {
                    chart1.Series["wave"].Points.AddY(BitConverter.ToSingle(buffer, i * SamplingDivider));
                }
            }
            WaveformLoaded = true;
            LoadingLabel.Visible = false;
        }
        //Need to keep else code fucking dies
        private void fIleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void brightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPalette(0);
        }

        public void SetPalette(int palletteNum)
        {
            switch (palletteNum)
            {
                default:chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
                    break;
                case 0:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
                    break;
                case 1:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
                    break;
                case 2:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
                    break;
                case 3:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
                    break;
                case 4:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
                    break;
                case 5:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
                    break;
                case 6:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
                    break;
                case 7:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
                    break;
                case 8:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
                    break;
                case 9:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
                    break;
                case 10:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
                    break;
                case 11:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
                    break;
            }
            
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPalette(1);
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPalette(2);
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPalette(3);
        }

        private void pastelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPalette(4);
        }

        private void earthTonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPalette(5);
        }

        private void seaGreendefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPalette(6);
        }

        private void berryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPalette(7);
        }

        private void chocolateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPalette(8);
        }

        private void fireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPalette(9);
        }

        private void seaGreenDefaultToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetPalette(10);
        }

        private void brightPastelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPalette(11);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (QualityDrop.SelectedIndex)
            {
                default:
                    ByteLength = 16777216;
                    break;
                case 0:
                    ByteLength = 65536;
                    break;
                case 1:
                    ByteLength = 16777216;
                    break;
            }
        }

        private void SampRateDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (QualityDrop.SelectedIndex)
            {
                default:
                    SamplingDivider = 4;
                    break;
                case 0:
                    SamplingDivider = 8;
                    break;
                case 1:
                    SamplingDivider = 16;
                    break;
                case 2:
                    SamplingDivider = 32;
                    break;
                case 3:
                    SamplingDivider = 64;
                    break;
                case 4:
                    ByteLength = 65536;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!WaveformLoaded)
            {
                MessageBox.Show("Please load a waveform to play", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("it's not implemented yet :/", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tODOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
