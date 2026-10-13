using restaurante.Properties;
using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace restaurante
{
    public partial class Form1 : Form
    {

       
        private struct Item
        {
            public string Name;
            public int Value;

            public Item(string name, int value)
            {
                Name = name;
                Value = value;
            }
        }


        private List<Item> ItemsNow = new List<Item>();
       

        private List<Item> CakeList = new List<Item>() { 
            new Item("Jardim Encantado da Moranguinho", 35),
            new Item("Brisa Cítrica do Limão", 35),
            new Item("Bosque Azul de Mirtilos", 35),
            new Item("Raio de Sol da Laranjinha", 35),
            new Item("Sonho Rubi da Framboesa", 35),
            new Item("Noite Violeta da Amorinha", 35),
            new Item("Chá de Primavera", 35),
            new Item("Casinha de Mel do Campo", 35),
            
        };

        private List<Item> MilkList = new List<Item>() {
            new Item("Pink Berry Dream", 25),
            new Item("Névoa de Limão Siciliano", 30),
            new Item("Blueberry Cloud", 30),
            new Item("Sunset de Laranja", 30),
            new Item("Ruby Berry Swirl", 30),
            new Item("Blackberry Midnight", 30),
            new Item("Green Grape Fizz", 30),
            new Item("Honey Spice Shake", 30),
        };

        private List<Item> TortaList = new List<Item>() {
            new Item("Coração de Morango", 38),
            new Item("Luar de Limão", 38),
            new Item("Tesouro Azul de Mirtilo", 38),
            new Item("Chocolate ao Sol", 38),
            new Item("Jardim Rubro de Framboesa", 38),
            new Item("Segredo da Lua Violeta", 38),
            new Item("Tarde no Jardim Verde", 38),
            new Item("Colmeia Dourada", 38),
        };

        private List<Item> DrinkList = new List<Item>() {
            new Item("Poção Rosa da Moranguinho", 25),
            new Item("Brisa Amarela", 25),
            new Item("Céu Estrelado de Mirtilo", 25),
            new Item("Pôr do Sol da Laranjinha", 25),
            new Item("Rubi Tropical", 25),
            new Item("Feitiço de Amora", 25),
            new Item("Orvalho de Uva Verde", 25),
            new Item("Abraço Quentinho de Mel", 25),
        };

        private List<Item> PasteList = new List<Item>() {
            new Item("Crocante do Jardim Vermelho", 25),
            new Item("Limão na Horta", 25),
            new Item("Lua Negra de Amora", 25),
            new Item("Pôr do Sol Crocante", 25),
            new Item("Rubi & Gorgonzola", 25),
            new Item("Segredo da Fazenda", 25),
            new Item("Estrelinha Azul Crocante", 28),
            new Item("Jardim Verde Cremoso", 28),
        };

        private List<Item> SalceList = new List<Item>() {
            new Item("Coxinha Jardim de Morangos", 25),
            new Item("Empadinha Brisa de Limão", 15),
            new Item("Kibe Dourado da Laranjeira", 25),
            new Item("Trouxinha da Floresta Violeta", 35),
            new Item("Quiche Rubi Crocante", 22),
            new Item("Bolinho da Fazenda Encantada", 20),
            new Item("Pastelzinho Jardim de Chazinho", 18),
            new Item("Croissant Céu Azul", 20),
        };

        private List<Item> CandyList = new List<Item>() {
            new Item("Estrela Rosa do Jardim", 20),
            new Item("Gotinha de Limão", 20),
            new Item("Raiozinho de Laranja", 20),
            new Item("Joia Azul de Mirtilo", 20),
            new Item("Lua de Chocolate & Amora", 20),
            new Item("Rubizinho de Framboesa", 20),
            new Item("Pérola Verde de Uva", 20),
            new Item("Pedra Preciosa de Mel", 20),
        };




        SoundPlayer player = new SoundPlayer(Resources.music);
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var form = new sobre();
            form.FormClosed += (s, args) => this.Show();
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new ingredientes();
            form.FormClosed += (s, args) => this.Show();
            this.Hide();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new conta();
            form.FormClosed += (s, args) => this.Show();
            this.Hide();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialoResult = MessageBox.Show("Tem certeza que deseja sair??? =(", "!! Atenção !!",
            MessageBoxButtons.YesNo);

            if (dialoResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
            button6.Visible = true;

            player.PlayLooping();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            button7.Visible = true;

            player.Stop();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (listBox1.Text)
            {
                case "Bolos":
                    pictureBox1.Image = Properties.Resources.CBc;
                    ItemsNow = CakeList;

                    button8.Visible = true;
                    button9.Visible = true;
                    button10.Visible = true;
                    button11.Visible = true;
                    button12.Visible = true;
                    button13.Visible = true;
                    button14.Visible = true;
                    button15.Visible = true;

                    button16.Visible = true;
                    button17.Visible = true;
                    button18.Visible = true;
                    button19.Visible = true;
                    button20.Visible = true;
                    button21.Visible = true;
                    button22.Visible = true;
                    button23.Visible = true;
                    button24.Visible = true;
                    button25.Visible = true;
                    button26.Visible = true;
                    button27.Visible = true;
                    button28.Visible = true;
                    button29.Visible = true;
                    button30.Visible = true;
                    button31.Visible = true;

                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;                   
                    break;

                case "Bebidas":
                    pictureBox1.Image = Properties.Resources.CBec;
                    ItemsNow = DrinkList;

                    button8.Visible = true;
                    button9.Visible = true;
                    button10.Visible = true;
                    button11.Visible = true;
                    button12.Visible = true;
                    button13.Visible = true;
                    button14.Visible = true;
                    button15.Visible = true;

                    button16.Visible = true;
                    button17.Visible = true;
                    button18.Visible = true;
                    button19.Visible = true;
                    button20.Visible = true;
                    button21.Visible = true;
                    button22.Visible = true;
                    button23.Visible = true;
                    button24.Visible = true;
                    button25.Visible = true;
                    button26.Visible = true;
                    button27.Visible = true;
                    button28.Visible = true;
                    button29.Visible = true;
                    button30.Visible = true;
                    button31.Visible = true;

                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    break;

                case "Docinhos":
                    pictureBox1.Image = Properties.Resources.CDc;
                    ItemsNow = CandyList;

                    button8.Visible = true;
                    button9.Visible = true;
                    button10.Visible = true;
                    button11.Visible = true;
                    button12.Visible = true;
                    button13.Visible = true;
                    button14.Visible = true;
                    button15.Visible = true;

                    button16.Visible = true;
                    button17.Visible = true;
                    button18.Visible = true;
                    button19.Visible = true;
                    button20.Visible = true;
                    button21.Visible = true;
                    button22.Visible = true;
                    button23.Visible = true;
                    button24.Visible = true;
                    button25.Visible = true;
                    button26.Visible = true;
                    button27.Visible = true;
                    button28.Visible = true;
                    button29.Visible = true;
                    button30.Visible = true;
                    button31.Visible = true;

                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    break;

                case "Milkshakes":
                    pictureBox1.Image = Properties.Resources.CMc;
                    ItemsNow = MilkList;

                    button8.Visible = true;
                    button9.Visible = true;
                    button10.Visible = true;
                    button11.Visible = true;
                    button12.Visible = true;
                    button13.Visible = true;
                    button14.Visible = true;
                    button15.Visible = true;

                    button16.Visible = true;
                    button17.Visible = true;
                    button18.Visible = true;
                    button19.Visible = true;
                    button20.Visible = true;
                    button21.Visible = true;
                    button22.Visible = true;
                    button23.Visible = true;
                    button24.Visible = true;
                    button25.Visible = true;
                    button26.Visible = true;
                    button27.Visible = true;
                    button28.Visible = true;
                    button29.Visible = true;
                    button30.Visible = true;
                    button31.Visible = true;

                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    break;

                case "Pásteis":
                    pictureBox1.Image = Properties.Resources.CPc;
                    ItemsNow = PasteList;

                    button8.Visible = true;
                    button9.Visible = true;
                    button10.Visible = true;
                    button11.Visible = true;
                    button12.Visible = true;
                    button13.Visible = true;
                    button14.Visible = true;
                    button15.Visible = true;

                    button16.Visible = true;
                    button17.Visible = true;
                    button18.Visible = true;
                    button19.Visible = true;
                    button20.Visible = true;
                    button21.Visible = true;
                    button22.Visible = true;
                    button23.Visible = true;
                    button24.Visible = true;
                    button25.Visible = true;
                    button26.Visible = true;
                    button27.Visible = true;
                    button28.Visible = true;
                    button29.Visible = true;
                    button30.Visible = true;
                    button31.Visible = true;

                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    break;

                case "Salgados":
                    pictureBox1.Image = Properties.Resources.CSc;
                    ItemsNow = SalceList;

                    button8.Visible = true;
                    button9.Visible = true;
                    button10.Visible = true;
                    button11.Visible = true;
                    button12.Visible = true;
                    button13.Visible = true;
                    button14.Visible = true;
                    button15.Visible = true;

                    button16.Visible = true;
                    button17.Visible = true;
                    button18.Visible = true;
                    button19.Visible = true;
                    button20.Visible = true;
                    button21.Visible = true;
                    button22.Visible = true;
                    button23.Visible = true;
                    button24.Visible = true;
                    button25.Visible = true;
                    button26.Visible = true;
                    button27.Visible = true;
                    button28.Visible = true;
                    button29.Visible = true;
                    button30.Visible = true;
                    button31.Visible = true;

                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    break;

                case "Tortas":
                    pictureBox1.Image = Properties.Resources.CTc;
                    ItemsNow = TortaList;

                    button8.Visible = true;
                    button9.Visible = true;
                    button10.Visible = true;
                    button11.Visible = true;
                    button12.Visible = true;
                    button13.Visible = true;
                    button14.Visible = true;
                    button15.Visible = true;

                    button16.Visible = true;
                    button17.Visible = true;
                    button18.Visible = true;
                    button19.Visible = true;
                    button20.Visible = true;
                    button21.Visible = true;
                    button22.Visible = true;
                    button23.Visible = true;
                    button24.Visible = true;
                    button25.Visible = true;
                    button26.Visible = true;
                    button27.Visible = true;
                    button28.Visible = true;
                    button29.Visible = true;
                    button30.Visible = true;
                    button31.Visible = true;

                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    break;



            }
        }

        
        private void button8_Click(object sender, EventArgs e)
        {
            
            var i = 0;
            var itm = ItemsNow[i];


            var form = new ingredientes();
            form.FormClosed += (s, args) => this.Show();
            form.SelectCombobox(itm.Name);
            this.Hide();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var i = 1;
            var itm = ItemsNow[i];

            
            var form = new ingredientes();
            form.FormClosed += (s, args) => this.Show();
            form.SelectCombobox(itm.Name);
            this.Hide();
            form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var i = 2;
            var itm = ItemsNow[i];


            var form = new ingredientes();
            form.FormClosed += (s, args) => this.Show();
            form.SelectCombobox(itm.Name);
            this.Hide();
            form.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var i = 3;
            var itm = ItemsNow[i];


            var form = new ingredientes();
            form.FormClosed += (s, args) => this.Show();
            form.SelectCombobox(itm.Name);
            this.Hide();
            form.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var i = 4;
            var itm = ItemsNow[i];

            
            var form = new ingredientes();
            form.FormClosed += (s, args) => this.Show();
            form.SelectCombobox(itm.Name);
            this.Hide();
            form.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var i = 5;
            var itm = ItemsNow[i];


            var form = new ingredientes();
            form.FormClosed += (s, args) => this.Show();
            form.SelectCombobox(itm.Name);
            this.Hide();
            form.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var i = 6;
            var itm = ItemsNow[i];


            var form = new ingredientes();
            form.FormClosed += (s, args) => this.Show();
            form.SelectCombobox(itm.Name);
            this.Hide();
            form.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var i = 7;
            var itm = ItemsNow[i];


            var form = new ingredientes();
            form.FormClosed += (s, args) => this.Show();
            form.SelectCombobox(itm.Name);
            this.Hide();
            form.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var i = 0;
            var itm = ItemsNow[i];
 
           /*  label1.Text = Convert.ToInt32(label1.Text)++.ToString();
            if (label1.Text == "0")
            {
                //nao alterar valor
            }else if ( label1.Text >= "1"){
                
                //valor + 1
            }
            */

            
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }
    }
}
