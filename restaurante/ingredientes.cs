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
    public partial class ingredientes : Form
    {
        public ingredientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ingredientes_Shown(object sender, EventArgs e)
        {
            //apagar
        }

        public void SelectCombobox(string s ) {
            comboBox1.Text = s;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Jardim Encantado da Moranguinho")
            {
                pictureBox1.Image = Properties.Resources.infB1;
                pictureBox2.Image = Properties.Resources.IngB1;

            } else if (comboBox1.Text == "Brisa Cítrica do Limão")
            {
                pictureBox1.Image = Properties.Resources.infB2;
                pictureBox2.Image = Properties.Resources.IngB2;
            }else if (comboBox1.Text == "Bosque Azul de Mirtilos")
            {
                pictureBox1.Image = Properties.Resources.infB3;
                pictureBox2.Image = Properties.Resources.IngB3;
            }
            else if (comboBox1.Text == "Raio de Sol da Laranjinha")
            {
                pictureBox1.Image = Properties.Resources.infB4;
                pictureBox2.Image = Properties.Resources.IngB4;
            }
            else if (comboBox1.Text == "Sonho Rubi da Framboesa")
            {
                pictureBox1.Image = Properties.Resources.infB5;
                pictureBox2.Image = Properties.Resources.IngB5;
            }
            else if (comboBox1.Text == "Noite Violeta da Amorinha")
            {
                pictureBox1.Image = Properties.Resources.infB6;
                pictureBox2.Image = Properties.Resources.IngB6;
            }
            else if (comboBox1.Text == "Chá de Primavera")
            {
                pictureBox1.Image = Properties.Resources.infB7;
                pictureBox2.Image = Properties.Resources.IngB7;
            }
            else if (comboBox1.Text == "Casinha de Mel do Campo")
            {
                pictureBox1.Image = Properties.Resources.infB8;
                pictureBox2.Image = Properties.Resources.IngB8;
            }else if (comboBox1.Text == "Pink Berry Dream")
            {
                pictureBox1.Image = Properties.Resources.infM1;
                pictureBox2.Image = Properties.Resources.IngM1;
            }
            else if (comboBox1.Text == "Névoa de Limão Siciliano")
            {
                pictureBox1.Image = Properties.Resources.infM2;
                pictureBox2.Image = Properties.Resources.IngM2;
            }
            else if (comboBox1.Text == "Blueberry Cloud")
            {
                pictureBox1.Image = Properties.Resources.infM3;
                pictureBox2.Image = Properties.Resources.IngM3;
            }
            else if (comboBox1.Text == "Sunset de Laranja")
            {
                pictureBox1.Image = Properties.Resources.infM4;
                pictureBox2.Image = Properties.Resources.IngM4;
            }
            else if (comboBox1.Text == "Ruby Berry Swirl")
            {
                pictureBox1.Image = Properties.Resources.infM5;
                pictureBox2.Image = Properties.Resources.IngM5;
            }
            else if (comboBox1.Text == "Blackberry Midnight")
            {
                pictureBox1.Image = Properties.Resources.infM6;
                pictureBox2.Image = Properties.Resources.IngM6;
            }
            else if (comboBox1.Text == "Green Grape Fizz")
            {
                pictureBox1.Image = Properties.Resources.infM7;
                pictureBox2.Image = Properties.Resources.IngM7;
            }
            else if (comboBox1.Text == "Honey Spice Shake")
            {
                pictureBox1.Image = Properties.Resources.infM8;
                pictureBox2.Image = Properties.Resources.IngM8;
            }
            else if (comboBox1.Text == "Coração de Morango")
            {
                pictureBox1.Image = Properties.Resources.infT1;
                pictureBox2.Image = Properties.Resources.IngT1;
            }
            else if (comboBox1.Text == "Luar de Limão")
            {
                pictureBox1.Image = Properties.Resources.infT2;
                pictureBox2.Image = Properties.Resources.IngT2;
            }
            else if (comboBox1.Text == "Tesouro Azul de Mirtilo")
            {
                pictureBox1.Image = Properties.Resources.infT3;
                pictureBox2.Image = Properties.Resources.IngT3;
            }
            else if (comboBox1.Text == "Chocolate ao Sol")
            {
                pictureBox1.Image = Properties.Resources.infT4;
                pictureBox2.Image = Properties.Resources.IngT4;
            }
            else if (comboBox1.Text == "Jardim Rubro de Framboesa")
            {
                pictureBox1.Image = Properties.Resources.infT5;
                pictureBox2.Image = Properties.Resources.IngT5;
            }
            else if (comboBox1.Text == "Segredo da Lua Violeta")
            {
                pictureBox1.Image = Properties.Resources.infT6;
                pictureBox2.Image = Properties.Resources.IngT6;
            }
            else if (comboBox1.Text == "Tarde no Jardim Verde")
            {
                pictureBox1.Image = Properties.Resources.infT7;
                pictureBox2.Image = Properties.Resources.IngT7;
            }
            else if (comboBox1.Text == "Colmeia Dourada")
            {
                pictureBox1.Image = Properties.Resources.infT8;
                pictureBox2.Image = Properties.Resources.IngT8;
            }else if (comboBox1.Text == "Poção Rosa da Moranguinho")
            {
                pictureBox1.Image = Properties.Resources.infBe1;
                pictureBox2.Image = Properties.Resources.IngBe1;
            }
            else if (comboBox1.Text == "Brisa Amarela")
            {
                pictureBox1.Image = Properties.Resources.infBe2;
                pictureBox2.Image = Properties.Resources.IngBe2;
            }
            else if (comboBox1.Text == "Céu Estrelado de Mirtilo")
            {
                pictureBox1.Image = Properties.Resources.infBe3;
                pictureBox2.Image = Properties.Resources.IngBe3;
            }
            else if (comboBox1.Text == "Pôr do Sol da Laranjinha")
            {
                pictureBox1.Image = Properties.Resources.infBe4;
                pictureBox2.Image = Properties.Resources.IngBe4;
            }
            else if (comboBox1.Text == "Rubi Tropical")
            {
                pictureBox1.Image = Properties.Resources.infBe5;
                pictureBox2.Image = Properties.Resources.IngBe5;
            }
            else if (comboBox1.Text == "Feitiço de Amora")
            {
                pictureBox1.Image = Properties.Resources.infBe6;
                pictureBox2.Image = Properties.Resources.IngBe6;
            }
            else if (comboBox1.Text == "Orvalho de Uva Verde")
            {
                pictureBox1.Image = Properties.Resources.infBe7;
                pictureBox2.Image = Properties.Resources.IngBe7;
            }
            else if (comboBox1.Text == "Abraço Quentinho de Mel")
            {
                pictureBox1.Image = Properties.Resources.infBe8;
                pictureBox2.Image = Properties.Resources.IngBe8;
            }
            else if (comboBox1.Text == "Crocante do Jardim Vermelho")
            {
                pictureBox1.Image = Properties.Resources.infP1;
                pictureBox2.Image = Properties.Resources.IngP1;
            }
            else if (comboBox1.Text == "Limão na Horta")
            {
                pictureBox1.Image = Properties.Resources.infP2;
                pictureBox2.Image = Properties.Resources.IngP2;
            }
            else if (comboBox1.Text == "Lua Negra de Amora")
            {
                pictureBox1.Image = Properties.Resources.infP3;
                pictureBox2.Image = Properties.Resources.IngP3;
            }
            else if (comboBox1.Text == "Pôr do Sol Crocante")
            {
                pictureBox1.Image = Properties.Resources.infP4;
                pictureBox2.Image = Properties.Resources.IngP4;
            }
            else if (comboBox1.Text == "Rubi & Gorgonzola")
            {
                pictureBox1.Image = Properties.Resources.infP5;
                pictureBox2.Image = Properties.Resources.IngP5;
            }
            else if (comboBox1.Text == "Segredo da Fazenda")
            {
                pictureBox1.Image = Properties.Resources.infP6;
                pictureBox2.Image = Properties.Resources.IngP6;
            }
            else if (comboBox1.Text == "Estrelinha Azul Crocante")
            {
                pictureBox1.Image = Properties.Resources.infP7;
                pictureBox2.Image = Properties.Resources.IngP7;
            }
            else if (comboBox1.Text == "Jardim Verde Cremoso")
            {
                pictureBox1.Image = Properties.Resources.infP8;
                pictureBox2.Image = Properties.Resources.IngP8;
            }
            else if (comboBox1.Text == "Coxinha Jardim de Morangos")
            {
                pictureBox1.Image = Properties.Resources.infS1;
                pictureBox2.Image = Properties.Resources.IngS1;
            }
            else if (comboBox1.Text == "Empadinha Brisa de Limão")
            {
                pictureBox1.Image = Properties.Resources.infS2;
                pictureBox2.Image = Properties.Resources.IngS2;
            }
            else if (comboBox1.Text == "Kibe Dourado da Laranjeira")
            {
                pictureBox1.Image = Properties.Resources.infS3;
                pictureBox2.Image = Properties.Resources.IngS3;
            }
            else if (comboBox1.Text == "Trouxinha da Floresta Violeta")
            {
                pictureBox1.Image = Properties.Resources.infS4;
                pictureBox2.Image = Properties.Resources.IngS4;
            }
            else if (comboBox1.Text == "Quiche Rubi Crocante")
            {
                pictureBox1.Image = Properties.Resources.infS5;
                pictureBox2.Image = Properties.Resources.IngS5;
            }
            else if (comboBox1.Text == "Bolinho da Fazenda Encantada")
            {
                pictureBox1.Image = Properties.Resources.infS6;
                pictureBox2.Image = Properties.Resources.IngS6;
            }
            else if (comboBox1.Text == "Pastelzinho Jardim de Chazinho")
            {
                pictureBox1.Image = Properties.Resources.infS7;
                pictureBox2.Image = Properties.Resources.IngS7;
            }
            else if (comboBox1.Text == "Croissant Céu Azul")
            {
                pictureBox1.Image = Properties.Resources.infS8;
                pictureBox2.Image = Properties.Resources.IngS8;
            }
            else if (comboBox1.Text == "Estrela Rosa do Jardim")
            {
                pictureBox1.Image = Properties.Resources.infD1;
                pictureBox2.Image = Properties.Resources.IngD1;
            }
            else if (comboBox1.Text == "Gotinha de Limão")
            {
                pictureBox1.Image = Properties.Resources.infD2;
                pictureBox2.Image = Properties.Resources.IngD2;
            }
            else if (comboBox1.Text == "Raiozinho de Laranja")
            {
                pictureBox1.Image = Properties.Resources.infD3;
                pictureBox2.Image = Properties.Resources.IngD3;
            }
            else if (comboBox1.Text == "Joia Azul de Mirtilo")
            {
                pictureBox1.Image = Properties.Resources.infD4;
                pictureBox2.Image = Properties.Resources.IngD4;
            }
            else if (comboBox1.Text == "Lua de Chocolate & Amora")
            {
                pictureBox1.Image = Properties.Resources.infD5;
                pictureBox2.Image = Properties.Resources.IngD5;
            }
            else if (comboBox1.Text == "Rubizinho de Framboesa")
            {
                pictureBox1.Image = Properties.Resources.infD6;
                pictureBox2.Image = Properties.Resources.IngD6;
            }
            else if (comboBox1.Text == "Pérola Verde de Uva")
            {
                pictureBox1.Image = Properties.Resources.infD7;
                pictureBox2.Image = Properties.Resources.IngD7;
            }
            else if (comboBox1.Text == "Pedra Preciosa de Mel")
            {
                pictureBox1.Image = Properties.Resources.infD8;
                pictureBox2.Image = Properties.Resources.IngD8;
            }



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "Bolos")
            {
                comboBox1.Items.Clear();
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                comboBox1.Items.Add("Jardim Encantado da Moranguinho");
                comboBox1.Items.Add("Brisa Cítrica do Limão ");
                comboBox1.Items.Add("Bosque Azul de Mirtilos");
                comboBox1.Items.Add("Raio de Sol da Laranjinha");
                comboBox1.Items.Add("Sonho Rubi da Framboesa");
                comboBox1.Items.Add("Noite Violeta da Amorinha");
                comboBox1.Items.Add("Chá de Primavera");
                comboBox1.Items.Add("Casinha de Mel do Campo");
            } 
            else if (listBox1.Text == "Milkshakes")
            {
                comboBox1.Items.Clear();
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                comboBox1.Items.Add("Pink Berry Dream");
                comboBox1.Items.Add("Névoa de Limão Siciliano");
                comboBox1.Items.Add("Blueberry Cloud");
                comboBox1.Items.Add("Sunset de Laranja");
                comboBox1.Items.Add("Ruby Berry Swirl");
                comboBox1.Items.Add("Blackberry Midnight");
                comboBox1.Items.Add("Green Grape Fizz");
                comboBox1.Items.Add("Honey Spice Shake");
            }
            else if (listBox1.Text == "Tortas")
            {
                comboBox1.Items.Clear();
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                comboBox1.Items.Add("Coração de Morango");
                comboBox1.Items.Add("Luar de Limão");
                comboBox1.Items.Add("Tesouro Azul de Mirtilo");
                comboBox1.Items.Add("Chocolate ao Sol");
                comboBox1.Items.Add("Jardim Rubro de Framboesa");
                comboBox1.Items.Add("Segredo da Lua Violeta");
                comboBox1.Items.Add("Tarde no Jardim Verde");
                comboBox1.Items.Add("Colmeia Dourada");
            }
            else if (listBox1.Text == "Bebidas")
            {
                comboBox1.Items.Clear();
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                comboBox1.Items.Add("Poção Rosa da Moranguinho");
                comboBox1.Items.Add("Brisa Amarela");
                comboBox1.Items.Add("Céu Estrelado de Mirtilo");
                comboBox1.Items.Add("Pôr do Sol da Laranjinha");
                comboBox1.Items.Add("Rubi Tropical");
                comboBox1.Items.Add("Feitiço de Amora");
                comboBox1.Items.Add("Orvalho de Uva Verde");
                comboBox1.Items.Add("Abraço Quentinho de Mel");
            }
            else if (listBox1.Text == "Pásteis")
            {
                comboBox1.Items.Clear();
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                comboBox1.Items.Add("Crocante do Jardim Vermelho");
                comboBox1.Items.Add("Limão na Horta");
                comboBox1.Items.Add("Lua Negra de Amora");
                comboBox1.Items.Add("Pôr do Sol Crocante");
                comboBox1.Items.Add("Rubi & Gorgonzola");
                comboBox1.Items.Add("Segredo da Fazenda");
                comboBox1.Items.Add("Estrelinha Azul Crocante");
                comboBox1.Items.Add("Jardim Verde Cremoso");
            }
            else if (listBox1.Text == "Salgados")
            {
                comboBox1.Items.Clear();
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                comboBox1.Items.Add("Coxinha Jardim de Morangos");
                comboBox1.Items.Add("Empadinha Brisa de Limão");
                comboBox1.Items.Add("Kibe Dourado da Laranjeira");
                comboBox1.Items.Add("Trouxinha da Floresta Violeta");
                comboBox1.Items.Add("Quiche Rubi Crocante");
                comboBox1.Items.Add("Bolinho da Fazenda Encantada");
                comboBox1.Items.Add("Pastelzinho Jardim de Chazinho");
                comboBox1.Items.Add("Croissant Céu Azul");
            }
            else if (listBox1.Text == "Docinhos")
            {
                comboBox1.Items.Clear();
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                comboBox1.Items.Add("Estrela Rosa do Jardim");
                comboBox1.Items.Add("Gotinha de Limão");
                comboBox1.Items.Add("Raiozinho de Laranja");
                comboBox1.Items.Add("Joia Azul de Mirtilo");
                comboBox1.Items.Add("Lua de Chocolate & Amora");
                comboBox1.Items.Add("Rubizinho de Framboesa");
                comboBox1.Items.Add("Pérola Verde de Uva");
                comboBox1.Items.Add("Pedra Preciosa de Mel");
            }

        }
    }
}
