using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {

        public string JogadorAtual = "X";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string InverterJogador()
        {
            if (JogadorAtual == "X")
            {
                return "O";
            }
            else
            {
                return "X";
            }
            return "X";
        }

        public void Limpar()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            JogadorAtual = "X";
        }

        public void Ganhar()
        {
            MessageBox.Show("O Jogador " + JogadorAtual + " ganhou!!!");
            Limpar();
        }

        public bool Verificar (string jogadorAt)
        {
            if (button1.Text == jogadorAt && button4.Text == jogadorAt && button7.Text == jogadorAt)
            {
                Ganhar();
                return true;
            }

            if (button2.Text == jogadorAt && button5.Text == jogadorAt && button8.Text == jogadorAt)
            {
                Ganhar();
                return true;
            }

            if (button3.Text == jogadorAt && button6.Text == jogadorAt && button9.Text == jogadorAt)
            {
                Ganhar();
                return true;
            }

            if (button1.Text == jogadorAt && button2.Text == jogadorAt && button3.Text == jogadorAt)
            {
                Ganhar();
                return true;
            }

            if (button4.Text == jogadorAt && button5.Text == jogadorAt && button6.Text == jogadorAt)
            {
                Ganhar();
                return true;
            }

            if (button7.Text == jogadorAt && button8.Text == jogadorAt && button9.Text == jogadorAt)
            {
                Ganhar();
                return true;
            }

            if (button1.Text == jogadorAt && button5.Text == jogadorAt && button9.Text == jogadorAt)
            {
                Ganhar();
                return true;
            }

            if (button3.Text == jogadorAt && button5.Text == jogadorAt && button7.Text == jogadorAt)
            {
                Ganhar();
                return true;
            }

            if (button1.Text.Length != 0 && button2.Text.Length != 0 && button3.Text.Length != 0 && button4.Text.Length != 0 && button5.Text.Length != 0 && button6.Text.Length != 0 && button7.Text.Length != 0 && button8.Text.Length != 0 && button9.Text.Length != 0)
                {
                MessageBox.Show("Deu velha!!!");
                Limpar();
                return true;
                }

            JogadorAtual = InverterJogador();
            label1.Text = "Jogador Atual: " + JogadorAtual;
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = JogadorAtual;
                Verificar(JogadorAtual);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = JogadorAtual;
                Verificar(JogadorAtual);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = JogadorAtual;
                Verificar(JogadorAtual);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = JogadorAtual;
                Verificar(JogadorAtual);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = JogadorAtual;
                Verificar(JogadorAtual);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = JogadorAtual;
                Verificar(JogadorAtual);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = JogadorAtual;
                Verificar(JogadorAtual);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                button8.Text = JogadorAtual;
                Verificar(JogadorAtual);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                button9.Text = JogadorAtual;
                Verificar(JogadorAtual);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Limpar();
        }

    }
}
