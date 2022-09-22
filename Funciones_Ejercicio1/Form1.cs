using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funciones_Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = sumar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
        }

        private double sumar(double numero1, double numero2)
        {
            double suma = numero1 + numero2;
            return suma;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = restar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
        }

        private double restar(double numero1, double numero2)
        {
            double resta = numero1 - numero2;
            return resta;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = multiplicar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
        }

        private double multiplicar(double numero1, double numero2)
        {
            double multiplicacion = numero1 * numero2;
            return multiplicacion;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = dividir(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
        }

        private double dividir(double numero1, double numero2)
        {
            double division = numero1 / numero2;
            return division;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
