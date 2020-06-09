using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektOdtwarzacz
{
    public partial class Form1 : Form
    {
        string videoPath, videoTytul;
        public Form1()
        {
            InitializeComponent();
            wmpOdtwarzacz.uiMode = "none";
        }

        private void btnOdtworz_Click(object sender, EventArgs e)
        {
            wmpOdtwarzacz.Ctlcontrols.play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            wmpOdtwarzacz.Ctlcontrols.stop();
        }

        private void btnZatrzymaj_Click(object sender, EventArgs e)
        {
            wmpOdtwarzacz.Ctlcontrols.pause();
        }

        private void btnOtworz_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect=false, Filter="MP4 File|*.mp4|All File|*.*" };
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoPath = openFileDialog.FileName;
                videoTytul = openFileDialog.SafeFileName;
                wmpOdtwarzacz.URL = videoPath;
                labelTytul.Text = videoTytul;


            }
        }
    }
}
