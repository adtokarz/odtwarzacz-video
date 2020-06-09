namespace ProjektOdtwarzacz
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTytul = new System.Windows.Forms.Label();
            this.btnOdtworz = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnZatrzymaj = new System.Windows.Forms.Button();
            this.wmpOdtwarzacz = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnOtworz = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpOdtwarzacz)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTytul);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 82);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOtworz);
            this.panel2.Controls.Add(this.btnZatrzymaj);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnOdtworz);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 632);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1212, 83);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.wmpOdtwarzacz);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1212, 550);
            this.panel3.TabIndex = 2;
            // 
            // labelTytul
            // 
            this.labelTytul.AutoSize = true;
            this.labelTytul.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTytul.Location = new System.Drawing.Point(553, 13);
            this.labelTytul.Name = "labelTytul";
            this.labelTytul.Size = new System.Drawing.Size(107, 39);
            this.labelTytul.TabIndex = 0;
            this.labelTytul.Text = "Tytuł";
            // 
            // btnOdtworz
            // 
            this.btnOdtworz.Location = new System.Drawing.Point(334, 19);
            this.btnOdtworz.Name = "btnOdtworz";
            this.btnOdtworz.Size = new System.Drawing.Size(146, 52);
            this.btnOdtworz.TabIndex = 0;
            this.btnOdtworz.Text = "Odtwórz";
            this.btnOdtworz.UseVisualStyleBackColor = true;
            this.btnOdtworz.Click += new System.EventHandler(this.btnOdtworz_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(508, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(146, 52);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnZatrzymaj
            // 
            this.btnZatrzymaj.Location = new System.Drawing.Point(679, 19);
            this.btnZatrzymaj.Name = "btnZatrzymaj";
            this.btnZatrzymaj.Size = new System.Drawing.Size(146, 52);
            this.btnZatrzymaj.TabIndex = 2;
            this.btnZatrzymaj.Text = "Zatrzymaj";
            this.btnZatrzymaj.UseVisualStyleBackColor = true;
            this.btnZatrzymaj.Click += new System.EventHandler(this.btnZatrzymaj_Click);
            // 
            // wmpOdtwarzacz
            // 
            this.wmpOdtwarzacz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpOdtwarzacz.Enabled = true;
            this.wmpOdtwarzacz.Location = new System.Drawing.Point(0, 0);
            this.wmpOdtwarzacz.Name = "wmpOdtwarzacz";
            this.wmpOdtwarzacz.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpOdtwarzacz.OcxState")));
            this.wmpOdtwarzacz.Size = new System.Drawing.Size(1212, 550);
            this.wmpOdtwarzacz.TabIndex = 0;
            // 
            // btnOtworz
            // 
            this.btnOtworz.Location = new System.Drawing.Point(1034, 19);
            this.btnOtworz.Name = "btnOtworz";
            this.btnOtworz.Size = new System.Drawing.Size(146, 52);
            this.btnOtworz.TabIndex = 3;
            this.btnOtworz.Text = "Otwórz ";
            this.btnOtworz.UseVisualStyleBackColor = true;
            this.btnOtworz.Click += new System.EventHandler(this.btnOtworz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1212, 715);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odtwarzacz";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpOdtwarzacz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTytul;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnZatrzymaj;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnOdtworz;
        private System.Windows.Forms.Panel panel3;
        private AxWMPLib.AxWindowsMediaPlayer wmpOdtwarzacz;
        private System.Windows.Forms.Button btnOtworz;
    }
}

