using System;
using System.Windows.Forms;

namespace Calculadoraa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean secuencia = true;
        Boolean otra = false;
        string operacion;
        Double numero1, numero2;
        Double resultado;
        int exp;

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void Pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)/// G U A R D A R - A N S 
        {
            if (secuencia)
            {
                Pantalla.Text = resultado.ToString();                
            }
            else
            {
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)/// R  E  T  R  O  C  E  S  O
        {
            if (Pantalla.TextLength > 1)
            {
                Pantalla.Text = Pantalla.Text.Remove(Pantalla.Text.Length - 1);
            }
        }

        private void button12_Click(object sender, EventArgs e)/// L  I  M  P  I  A  R
        {
            Pantalla.Clear();
        }

        private void button16_Click(object sender, EventArgs e) /// M   U  L  T  I  P  L  I  C  A  C  I  O N
        {
            operacion = "*";
            if (otra)
            {
                numero1 = resultado;      
                Pantalla.Clear();
                secuencia = true;
            }
            else
            {
                numero1 = Double.Parse(Pantalla.Text);
                Pantalla.Clear();
                secuencia = true;
            }
           
        }

        private void button15_Click(object sender, EventArgs e) // D  I  V  I  S  I  O  N 
        {
            operacion = "/";
            if (otra)
            {
                numero1 = resultado;
                Pantalla.Clear();
                secuencia = true;
            }
            else
            {          
                numero1 = Double.Parse(Pantalla.Text);
                Pantalla.Clear();
                secuencia = true;
            }
        }

        private void button20_Click(object sender, EventArgs e) /// R A I Z C U A D R A D A 
        {
            operacion = "R";
            if (otra)
            {
                numero1 = resultado;
                Pantalla.Clear();
                secuencia = true;
            }
            else
            {               
                numero1 = Double.Parse(Pantalla.Text);
                Pantalla.Clear();
                secuencia = true;
            }
        }

        private void button17_Click(object sender, EventArgs e) /// R E S T A
        {
            operacion = "-";
            if (otra)
            {
                numero1 = resultado;
                Pantalla.Clear();
                secuencia = true;
            }
            else
            {               
                numero1 = Double.Parse(Pantalla.Text);
                Pantalla.Clear();
                secuencia = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)/// S U M A 
        {
            operacion = "+";
            if (otra)
            {
                numero1 = resultado;
                Pantalla.Clear();
                secuencia = true;
            }
            else
            {              
                numero1 = Double.Parse(Pantalla.Text);
                Pantalla.Clear();
                secuencia = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)/// P O T E N C I A
        {
            operacion = "^";
            if (otra)
            {
                numero1 = resultado;
                Pantalla.Clear();
                secuencia = true;
            }
            else
            {               
                numero1 = Double.Parse(Pantalla.Text);
                Pantalla.Clear();
                secuencia = true;
            }
        }

        ////      O  P  E  R  A  C  I  O  N  E  S   ////

        private void button21_Click(object sender, EventArgs e)
        {            
                 if (operacion == "/")
                 {                                  
                    numero2 = Double.Parse(Pantalla.Text);
                    resultado = numero1 / numero2;
                    Pantalla.Text = "= " + resultado.ToString();
                secuencia = true;
                otra = true;
            }

                if (operacion == "+")
                {
                    numero2 = Double.Parse(Pantalla.Text);
                    resultado = numero1 + numero2;
                    Pantalla.Text = "= " + resultado.ToString();
                secuencia = true;
                otra = true;
            }
                if (operacion == "-")
                {
                    numero2 = Double.Parse(Pantalla.Text);
                    resultado = numero1 - numero2;
                    Pantalla.Text = "= " + resultado.ToString();
                secuencia = true;
                otra = true;
            }
                if (operacion == "*")
                {
                    numero2 = Double.Parse(Pantalla.Text);
                    resultado = numero1 * numero2;
                    Pantalla.Text = "= " + resultado.ToString();              
                secuencia = true;
                otra = true;
            }
                if (operacion == "^")
                {
                    exp = Int16.Parse(Pantalla.Text);
                    resultado = Math.Pow(numero1, exp);
                    Pantalla.Text = "= " + resultado.ToString();
                secuencia = true;
                otra = true;
            }

                if (operacion == "R")
                {
                    resultado = Math.Sqrt(numero1);
                    Pantalla.Text = "= " + resultado.ToString();
                secuencia = true;
                otra = true;
            }                    
           
        }

        ////       N  U  M  E  R  O  S

        private void button6_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                return;
            }
            else { Pantalla.Text = Pantalla.Text + "0"; }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (secuencia)
            {
                Pantalla.Text = "";
                Pantalla.Text = "1";
                secuencia = false;
            }
            else { Pantalla.Text = Pantalla.Text + "1"; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (secuencia)
            {
                Pantalla.Text = "";
                Pantalla.Text = "2";
                secuencia = false;
            }
            else { Pantalla.Text = Pantalla.Text + "2"; }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "3";
                secuencia = false;
            }
            else { Pantalla.Text = Pantalla.Text + "3"; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "4";
                secuencia = false;
            }
            else { Pantalla.Text = Pantalla.Text + "4"; }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "5";
                secuencia = false;
            }
            else { Pantalla.Text = Pantalla.Text + "5"; }


        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "6";
                secuencia = false;
            }
            else { Pantalla.Text = Pantalla.Text + "6"; }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "7";
                secuencia = false;
            }
            else { Pantalla.Text = Pantalla.Text + "7"; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "8";
                secuencia = false;
            }
            else { Pantalla.Text = Pantalla.Text + "8"; }
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "9";
                secuencia = false;
            }
            else { Pantalla.Text = Pantalla.Text + "9"; }

        }
    }
}
