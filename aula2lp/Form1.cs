using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace aula2lp
{
    public partial class Form1 : Form
    {
        double valor1, valor2, lado1, lado2, lado3, a, b, c, delta, x1, x2, resu;
        double opcao;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox1.Text);
            valor2 = double.Parse(textBox2.Text);

            if (valor1 > valor2)
            {
                MessageBox.Show("O número "+valor1.ToString()+" é o maior","Resultado");
            }
            else
            {
                MessageBox.Show("O número "+valor2+" é o maior","Resultado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lado1 = double.Parse(textBox3.Text);
            lado2 = double.Parse(textBox4.Text);
            lado3 = double.Parse(textBox5.Text);

            if ((lado1 == lado2) && (lado2 == lado3))
            {
                MessageBox.Show("Seu triângulo é equilátero.","RESULTADO");
            }
            if ((lado1 == lado2) && (lado2 != lado3) || (lado1 == lado3) && (lado2 != lado3) || (lado2 == lado3) && (lado1 != lado2))
            {
                MessageBox.Show("Seu triângulo é isósceles.","RESULTADO");
            }
            if ((lado1 != lado2) && (lado2 != lado3) && (lado1 != lado3))
            {
                MessageBox.Show("Seu triângulo é escaleno.","RESULTADO"); 
            }
        }

        //ex4
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        double bas, alt, rai, basma, basme, apo, lad;
        string unmed;

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            opcao = double.Parse(textBox9.Text);
            bas = double.Parse(textBox10.Text);
            alt = double.Parse(textBox11.Text);
            rai = double.Parse(textBox15.Text);
            basma = double.Parse(textBox13.Text);
            basme = double.Parse(textBox12.Text);
            apo = double.Parse(textBox14.Text);
            lad = double.Parse(textBox16.Text);
            unmed = (textBox17.Text);

            if (opcao == 1)
            {
                resu = bas * alt;
                MessageBox.Show("A área do seu retângulo é de " + resu + unmed + ".", "RESULTADO");
            }
            if (opcao == 2)
            {
                resu = (Math.Pow(rai, 2)) * 3.14;
                MessageBox.Show("A área do seu círculo é de " + resu + unmed + ".", "RESULTADO");
            }
            if (opcao == 3)
            {
                resu = ((basma + basme) * alt) / 2;
                MessageBox.Show("A área do seu trapézio é de " + resu + unmed + ".", "RESULTADO");
            } 
            if (opcao == 4)
            {
                resu = 5 * lad * apo;
                MessageBox.Show("A área do seu pentágono é de " + resu + unmed + ".", "RESULTADO");
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox6.Text);
            b = double.Parse(textBox7.Text);
            c = double.Parse(textBox8.Text);
            delta = Math.Pow(b, 2) - 4*a*c;
            if (delta <= 0)
            {
                MessageBox.Show("Calculo Inválido (Delta Negativo)");
            }
            else
            {
                x1 = (-b + (Math.Sqrt(delta))) / 2 * a;
                x2 = (-b - (Math.Sqrt(delta))) / 2 * a;
                MessageBox.Show("S = { "+x1.ToString()+", "+x2.ToString()+" }","RESULTADO");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
