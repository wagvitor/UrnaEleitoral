using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urna_Eleitoral
{
    public partial class Form1 : Form
    {
        int contDirceu=0, contDilma=0, contLula=0, contBranco=0, contNulo;
        int op = 0;
        int num = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            //num = Convert.ToInt32(txt1.Text);

   

            if (num == 123)
            { 
                contDilma += 1;
                txt1.Clear();
                txtNome.Clear();
                pictureBox1.Image = Properties.Resources.Branco;
            }
            else if (num == 456)
            {
                contDirceu += 1;
                txt1.Clear();
                txtNome.Clear();
                pictureBox1.Image = Properties.Resources.Branco;
            }
            else if (num == 789)
            {
                contLula += 1;
                txt1.Clear();
                txtNome.Clear();
                pictureBox1.Image = Properties.Resources.Branco;
            }
            else if (op == 1)
            {
                contBranco += 1;
                txt1.Clear();
                txtNome.Clear();
                pictureBox1.Image = Properties.Resources.Branco;

            }
            else
            {
                //MessageBox.Show("Número inválido! Con seu voto!");
                pictureBox1.Image = Properties.Resources.Branco;
                txtNome.Text = "Voto Nulo";
                contNulo += 1;
            }



        }

        private void button10_Click(object sender, EventArgs e)
        {
            txt1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt1.Text += "7";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txtNome.Clear();
            pictureBox1.Image = Properties.Resources.Branco;
            txtDilma.Clear();
            txtDirceu.Clear();
            txtLula.Clear();
        }

        private void btnDilma_Click(object sender, EventArgs e)
        {
            txtDilma.Text = contDilma.ToString();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLula_Click(object sender, EventArgs e)
        {
            txtLula.Text = contLula.ToString();
        }

        private void btnDirceu_Click(object sender, EventArgs e)
        {
            txtDirceu.Text = contDirceu.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            txtLula.Text = contLula.ToString();
            txtDirceu.Text = contDirceu.ToString();
            txtDilma.Text = contDilma.ToString();
            txtBranco.Text = contBranco.ToString();
            txtNulo.Text = contNulo.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnBranco1_Click(object sender, EventArgs e)
        {
            //Converter para String
            txtBranco.Text = contBranco.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtNulo.Text = contNulo.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

                if (txt1.Text == "123")
                {
                    num = 123;
                    pictureBox1.Image = Properties.Resources.Dilma;
                    txtNome.Text = "Dilma";
                }
                else if (txt1.Text == "456")
                {
                    num = 456;
                    pictureBox1.Image = Properties.Resources.Dirceu;
                    txtNome.Text = "Dirceu";
                }
                else if (txt1.Text == "789")
                {
                    num = 789;
                    pictureBox1.Image = Properties.Resources.Lula;
                    txtNome.Text = "Lula";
                }
                else if (txt1.Text == "")
                {
                    num = 000;
                    pictureBox1.Image = Properties.Resources.Branco;
                    txtNome.Text = "Branco";

                }
     
            }
            

        private void btnBranco1_Click_1(object sender, EventArgs e)
        {
            txtBranco.Text = contBranco.ToString();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Branco;
            txtNome.Text = "Voto em Branco";
            op = 1;
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txtNome.Clear();
            pictureBox1.Image = Properties.Resources.Branco;
            txtDilma.Clear();
            txtDirceu.Clear();
            txtLula.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt1.Text += "9";
        }
    }
}
