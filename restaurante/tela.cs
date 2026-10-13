using System;
using System.Windows.Forms;

namespace restaurante
{
    public partial class tela : Form
    {
        public tela()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Esconde a tela de login e abre o menu. Hide() (e nao Close)
        /// porque a tela e o form principal do Application.Run: se ela
        /// fosse fechada, o Run terminaria e o programa acabaria.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.FormClosed += (s, args) => this.Show();
            this.Hide();
            menu.Show();
        }
    }
}
