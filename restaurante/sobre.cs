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
    public partial class sobre : Form
    {
        public sobre()
        {
            InitializeComponent();
        }

        //Botao "Voltar": o Close() dispara o FormClosed registrado em Form1,
        //que por sua vez chama this.Show() no menu. Sem isso o menu fica
        //escondido para sempre (porque o pai foi escondido com Hide()).
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
