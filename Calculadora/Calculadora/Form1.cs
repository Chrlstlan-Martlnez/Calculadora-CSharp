using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void clickNum(object sender, EventArgs e)
        {
            Button numBoton = (Button)sender;
            String numero = (String)numBoton.Tag;

            String valAnt = label1.Text;
            label1.Text = valAnt + numero;
        }

        String signo;
        double valor1;
        double valor2;
        double resultado;

        private void clickOper(object sender, EventArgs e)
        {
            Button signoBoton = (Button)sender;
            signo = (String)signoBoton.Tag;
            valor1 = double.Parse(label1.Text);

            label1.Text = "";
            label2.Text = valor1.ToString();
        }

        private void botonIgu_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(label1.Text);
            label1.Text = "";
            label2.Text = "";

            if (signo == "+")
            {
                resultado = valor1 + valor2;
            }
            else if (signo == "-")
            {
                resultado = valor1 - valor2;
            }
            else if (signo == "*")
            {
                resultado = valor1 * valor2;
            }
            else
            {
                resultado = valor1 / valor2;
            }

            if ((signo != "/") || ((signo == "/") && (valor2 != 0)))
            {
                label2.Text = valor1.ToString() + signo + valor2.ToString();
                label1.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("No se puede dividir entre 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                valor1 = valor2 = resultado = 0;
                signo = label1.Text = label2.Text = "";
            }
        }

        private void botonBor_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }
        }

        private void botonLim_Click(object sender, EventArgs e)
        {
            valor1 = valor2 = resultado = 0;
            signo = label1.Text = label2.Text = "";
        }

        private void botonNeg_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(label1.Text);
            double nuevoValor = valor * (-1);

            label1.Text = nuevoValor.ToString();
        }

        private void botonDec_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + ".";
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonClaro_Click(object sender, EventArgs e)
        {
            foreach (Control elemento in this.Controls)
            {
                if (elemento.Name == "boton1" || elemento.Name == "boton2" || elemento.Name == "boton3" ||
                    elemento.Name == "boton4" || elemento.Name == "boton5" || elemento.Name == "boton6" ||
                    elemento.Name == "boton7" || elemento.Name == "boton8" || elemento.Name == "boton9" ||
                    elemento.Name == "boton0" || elemento.Name == "botonDec")
                {
                    elemento.BackColor = System.Drawing.Color.White;
                    elemento.ForeColor = System.Drawing.Color.Black;
                }
                else if (elemento.Name == "botonSum" || elemento.Name == "botonRes" || elemento.Name == "botonMul" ||
                         elemento.Name == "botonDiv" || elemento.Name == "botonIgu")
                {
                    elemento.BackColor = Color.FromArgb(254, 249, 212);
                    elemento.ForeColor = System.Drawing.Color.Black;
                }
                else if (elemento.Name == "botonBor" || elemento.Name == "botonLim" || elemento.Name == "botonNeg")
                {
                    elemento.BackColor = Color.FromArgb(255, 244, 238);
                    elemento.ForeColor = System.Drawing.Color.Black;
                }
                else if (elemento.Name == "label1" || elemento.Name == "label2")
                {
                    elemento.BackColor = System.Drawing.Color.White;
                    elemento.ForeColor = System.Drawing.Color.Black;
                }
            }

            this.BackColor = Color.FromArgb(255, 244, 238);
        }

        private void botonOscuro_Click(object sender, EventArgs e)
        {
            foreach (Control elemento in this.Controls)
            {
                if (elemento.Name == "boton1" || elemento.Name == "boton2" || elemento.Name == "boton3" ||
                    elemento.Name == "boton4" || elemento.Name == "boton5" || elemento.Name == "boton6" ||
                    elemento.Name == "boton7" || elemento.Name == "boton8" || elemento.Name == "boton9" ||
                    elemento.Name == "boton0" || elemento.Name == "botonDec")
                {
                    elemento.BackColor = System.Drawing.Color.Black;
                    elemento.ForeColor = System.Drawing.Color.White;
                }
                else if (elemento.Name == "botonSum" || elemento.Name == "botonRes" || elemento.Name == "botonMul" ||
                         elemento.Name == "botonDiv" || elemento.Name == "botonIgu")
                {
                    elemento.BackColor = Color.FromArgb(7, 133, 172);
                    elemento.ForeColor = System.Drawing.Color.White;
                }
                else if (elemento.Name == "botonBor" || elemento.Name == "botonLim" || elemento.Name == "botonNeg")
                {
                    elemento.BackColor = Color.FromArgb(41, 41, 41);
                    elemento.ForeColor = System.Drawing.Color.White;
                }
                else if (elemento.Name == "label1" || elemento.Name == "label2")
                {
                    elemento.BackColor = System.Drawing.Color.Black;
                    elemento.ForeColor = System.Drawing.Color.White;
                }
            }

            this.BackColor = Color.FromArgb(41, 41, 41);
        }

        private void botonAzul_Click(object sender, EventArgs e)
        {
            foreach (Control elemento in this.Controls)
            {
                if (elemento.Name == "boton1" || elemento.Name == "boton2" || elemento.Name == "boton3" ||
                    elemento.Name == "boton4" || elemento.Name == "boton5" || elemento.Name == "boton6" ||
                    elemento.Name == "boton7" || elemento.Name == "boton8" || elemento.Name == "boton9" ||
                    elemento.Name == "boton0" || elemento.Name == "botonDec")
                {
                    elemento.BackColor = Color.FromArgb(20, 66, 114);
                    elemento.ForeColor = Color.FromArgb(44, 116, 179);
                }
                else if (elemento.Name == "botonSum" || elemento.Name == "botonRes" || elemento.Name == "botonMul" ||
                         elemento.Name == "botonDiv" || elemento.Name == "botonIgu")
                {
                    elemento.BackColor = Color.FromArgb(10, 38, 71);
                    elemento.ForeColor = Color.FromArgb(44, 116, 179);
                }
                else if (elemento.Name == "botonBor" || elemento.Name == "botonLim" || elemento.Name == "botonNeg")
                {
                    elemento.BackColor = Color.FromArgb(32, 82, 149);
                    elemento.ForeColor = Color.FromArgb(44, 116, 179);
                }
                else if (elemento.Name == "label1" || elemento.Name == "label2")
                {
                    elemento.BackColor = Color.FromArgb(20, 66, 114);
                    elemento.ForeColor = Color.FromArgb(44, 116, 179);
                }
            }

            this.BackColor = Color.FromArgb(32, 82, 149);
        }

        private void botonRosado_Click(object sender, EventArgs e)
        {
            foreach (Control elemento in this.Controls)
            {
                if (elemento.Name == "boton1" || elemento.Name == "boton2" || elemento.Name == "boton3" ||
                    elemento.Name == "boton4" || elemento.Name == "boton5" || elemento.Name == "boton6" ||
                    elemento.Name == "boton7" || elemento.Name == "boton8" || elemento.Name == "boton9" ||
                    elemento.Name == "boton0" || elemento.Name == "botonDec")
                {
                    elemento.BackColor = Color.FromArgb(246, 189, 221);
                    elemento.ForeColor = Color.FromArgb(248, 117, 170);
                }
                else if (elemento.Name == "botonSum" || elemento.Name == "botonRes" || elemento.Name == "botonMul" ||
                         elemento.Name == "botonDiv" || elemento.Name == "botonIgu")
                {
                    elemento.BackColor = Color.FromArgb(244, 215, 215);
                    elemento.ForeColor = Color.FromArgb(248, 117, 170);
                }
                else if (elemento.Name == "botonBor" || elemento.Name == "botonLim" || elemento.Name == "botonNeg")
                {
                    elemento.BackColor = Color.FromArgb(251, 172, 204);
                    elemento.ForeColor = Color.FromArgb(248, 117, 170);
                }
                else if (elemento.Name == "label1" || elemento.Name == "label2")
                {
                    elemento.BackColor = Color.FromArgb(246, 189, 221);
                    elemento.ForeColor = Color.FromArgb(248, 117, 170);
                }
            }

            this.BackColor = Color.FromArgb(251, 172, 204);
        }

    }
}
