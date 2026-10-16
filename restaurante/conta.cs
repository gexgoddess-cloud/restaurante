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
    public partial class conta : Form
    {
        public conta()
        {
            InitializeComponent();
        }

        public void MudarTexto(string texto) {
            label2.Text = texto;
        }

        //Botao "Finalizar": encerra o pedido e fecha o aplicativo inteiro.
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja finalizar o pedido?", "!! Confirmar !!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
