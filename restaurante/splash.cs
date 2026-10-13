using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurante
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
            } else
            {
                timer1.Stop();
                timer2.Stop();
                this.Close();
            }
                label1.Text = "Carregando... " + progressBar1.Value + " %";
        }

        private void splash_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            timer2.Start();
        }
    }
}
