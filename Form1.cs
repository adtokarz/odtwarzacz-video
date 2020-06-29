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
        /// <<summary>>
        /// kodowanie guzika odpowiadającego za odtwarzanie
        /// </summary>
        private void btnOdtworz_Click(object sender, EventArgs e)
        {
            wmpOdtwarzacz.Ctlcontrols.play();
        }
        /// <<summary>>
        /// kodowanie guzika odpowiadającego za stopowanie
        /// </summary>
        private void btnStop_Click(object sender, EventArgs e)
        {
            wmpOdtwarzacz.Ctlcontrols.stop();
        }
        /// <<summary>>
        /// kodowanie guzika odpowiadającego za pauzowanie
        /// </summary>
        private void btnZatrzymaj_Click(object sender, EventArgs e)
        {
            wmpOdtwarzacz.Ctlcontrols.pause();
        }
        /// <<summary>>
        /// kodowanie guzika pozwalającego na wybranie z dysku pliku
        /// </summary>
        private void btnOtworz_Click(object sender, EventArgs e)
        {
            /// <<summary>>
            /// multiselect=false jest po to, żeby użytkownik mógł wybrać tylko jeden film, i Filter żeby odtwarzane był filmy z rozszerzeniem mp4
            /// OpenFileDialog wyświetla użytkownikowi okno w którym trzeba wybrać plik
            /// Sprawdzenie czy przycisk OK został kliknięty w oknie dialogowym
            /// </summary>
            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false, Filter = "MP4 File|*.mp4|All File|*.*" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoPath = openFileDialog.FileName;
                videoTytul = openFileDialog.SafeFileName;
                wmpOdtwarzacz.URL = videoPath;
                labelTytul.Text = videoTytul;


            }
        }
    }
}
