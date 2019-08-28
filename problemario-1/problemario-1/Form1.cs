using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problemario_1
{
    
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Number_1_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "1";
        }

        private void Number_2_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "2";
        }

        private void Number_3_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "3";
        }

        private void Number_4_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "4";
        }

        private void Number_5_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "5";
        }

        private void Number_6_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "6";
        }

        private void Number_7_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "7";
        }

        private void Number_8_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "8";
        }

       

        private void Number_9_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "9";
        }

        private void C_Click(object sender, EventArgs e)
        {

        }

        private void CE_Click(object sender, EventArgs e)
        {

        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(Screen.Text);
            Screen.Clear();
        }

        private void Restar_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(Screen.Text);
            Screen.Clear();
        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            operador = "x";
            primero = double.Parse(Screen.Text);
            Screen.Clear();
        }

        private void Screen_TextChanged(object sender, EventArgs e)
        {

        }

        private void Number_0_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "0";
        }

        private void Sumar_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(Screen.Text);
            Screen.Clear();
        }

        private void Porcentaje_Click(object sender, EventArgs e)
        {
            operador = "%";
            primero = double.Parse(Screen.Text);
            Screen.Clear();
        }
    }
}
