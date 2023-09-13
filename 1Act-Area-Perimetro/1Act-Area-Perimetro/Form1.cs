using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1Act_Area_Perimetro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
  
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SeleccionarFigura(object sender, EventArgs e)
        {
        }

        private void AceptarOperacion(object sender, EventArgs e)
        {

        }

        public void valor_text(object sender, EventArgs e)
        {
            calcularPerimetro();
            calcularArea();
        }

        private void valor_text2(object sender, EventArgs e)
        {
            calcularPerimetro();
            calcularArea();
        }

        private void text(object sender, EventArgs e)
        {
            calcularArea();
        }

        private void text2(object sender, EventArgs e)
        {
            calcularArea();
        }

        private void CalcularOperacion(object sender, EventArgs e)
        {

        }

        private void text_total(object sender, EventArgs e)
        {

        }

        private void respuesta_numero(object sender, EventArgs e)
        {
            calcularPerimetro();
            calcularArea();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            volver.Visible = true;
            rectangulo.Enabled = false;
            cuadrado.Enabled = false;
            triangulo.Enabled = false;
            texto_2.Text = "Radio";
            texto_1.Visible= false; 
            texto_3.Visible= false;
            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            volver.Visible= true;
            triangulo.Enabled= false;
            cuadrado.Enabled= false;
            circulo.Enabled= false;
            texto_1.Text = "Base";
            texto_3.Text = "Altura";
            texto_2.Visible= false;
            texto_1.Visible = true;
            texto_3.Visible = true;
            textBox1.Visible = false;
            textBox2.Visible= true;
            textBox3.Visible= true;    
        }

        private void button6_Click(object sender, EventArgs e)
        {
            volver.Visible = true;
            triangulo.Enabled = false;
            cuadrado.Enabled = true;
            circulo.Enabled = false;
            rectangulo.Enabled = false;
            texto_2.Text = "Lado";
            texto_1.Visible = false;
            texto_3.Visible = false;
            texto_2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            perimetro.Enabled = false;
            volver_Operacion.Visible = true;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            area.Enabled = false;
            volver_Operacion.Visible = true;

        }

        private void triangulo_figura(object sender, EventArgs e)
        {
            volver.Visible = true;
            circulo.Enabled = false; 
            rectangulo.Enabled = false;
            cuadrado.Enabled = false;

        }

        private void volver_Click(object sender, EventArgs e)
        {
            volver.Visible = false;
            circulo.Enabled = true;
            rectangulo.Enabled = true; 
            cuadrado.Enabled = true;    
            triangulo.Enabled = true;
            texto_1.Visible = true;
            texto_3.Visible = true;
            texto_2.Visible = true; 
            texto_1.Text = "Lado";
            texto_2.Text = "Lado";
            texto_3.Text = "Lado";
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calcularPerimetro();
            calcularArea();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            volver_Operacion.Visible = false;
            area.Enabled = true;
            perimetro.Enabled = true;
        }

        private void calcularArea()
        {
            double valor_1, valor_2, valor_3;
            if (double.TryParse(textBox1.Text, out valor_2) &&
                double.TryParse(textBox2.Text, out valor_1) &&
                double.TryParse(textBox3.Text, out valor_3))
            {
                if (triangulo.Enabled == true && volver.Visible == true
                        && area.Enabled == true && volver_Operacion.Visible == true)
                {
                    texto_1.Text = "Base";
                    texto_2.Visible = false;
                    textBox1.Visible = false;
                    texto_3.Text = "Altura";
                    //area de un triangulo
                    double respuesta;
                    respuesta = (valor_1 * valor_3) / 2;

                    total_numero.Text = respuesta.ToString();
                } 
                else if(circulo.Enabled == true && volver.Visible == true
                        && area.Enabled == true && volver_Operacion.Visible == true)
                {
                    //area de un circulo
                    double respuesta;
                    respuesta = Math.PI * Math.Pow(valor_2,2);
                    total_numero.Text = respuesta.ToString();

                }
                else if(rectangulo.Enabled == true && volver.Visible == true
                        && area.Enabled == true && volver_Operacion.Visible == true)
                {
                    //area de un rectangulo
                    double respuesta;
                    respuesta = (valor_1 * valor_3) / 2;
                    total_numero.Text = respuesta.ToString();
                }
                else if(cuadrado.Enabled == true && volver.Visible == true
                        && area.Enabled == true && volver_Operacion.Visible == true)
                {
                    //area de un cuadrado 
                    double respuesta; 
                    respuesta = Math.Pow(valor_2,2);
                    total_numero.Text = respuesta.ToString();

                }

            }
            else
            {
                MessageBox.Show("Ingresa valores numéricos válidos");

            }
        }

        private void calcularPerimetro()
        {
            double valor_1, valor_2, valor_3;
                // textBox2 es el 1, textbox1 es el 2 y textBox3 es el 3
            if (double.TryParse(textBox1.Text, out valor_1) &&
                double.TryParse(textBox2.Text, out valor_2) &&
                double.TryParse(textBox3.Text, out valor_3))
            {
                {
                    if (triangulo.Enabled == true && volver.Visible == true 
                        && perimetro.Enabled == true && volver_Operacion.Visible == true)
                    {
                        //Perimetro de un Triangulo
                        double respuesta;
                        respuesta = valor_1 + valor_2 + valor_3;

                        total_numero.Text = respuesta.ToString();
                    }
                    else if (circulo.Enabled == true && volver.Visible == true 
                        && perimetro.Enabled == true && volver_Operacion.Visible == true)
                    {
                        // perimetro de un circulo 
                        double respuesta;
                        respuesta = (2* Math.PI) * valor_1;
                        total_numero.Text = respuesta.ToString();
                    }
                    else if(rectangulo.Enabled == true && volver.Visible == true
                        && perimetro.Enabled == true && volver_Operacion.Visible == true)
                    {
                        //perimetro de un rectangulo
                        double respuesta;
                        respuesta = 2 * (valor_2 + valor_3);

                        total_numero.Text = respuesta.ToString();
                    }
                    else if(cuadrado.Enabled == true && volver.Visible == true
                        && perimetro.Enabled == true && volver_Operacion.Visible == true)
                    {
                        //perimetro de un cuadrado
                        double respuesta;
                        respuesta = 4 * valor_1;
                        total_numero.Text = respuesta.ToString();

                    }
                }

            }
            else 
            {
                MessageBox.Show("Ingresa valores numéricos válidos");
            }

        }

        private void texto_2_Click(object sender, EventArgs e)
        {
            calcularArea();
        }
    }
}
