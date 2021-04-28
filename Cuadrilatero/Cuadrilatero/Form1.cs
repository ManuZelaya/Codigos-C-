using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuadrilatero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            picbox_cuadrado.Visible = false;
            picbox_rectan.Visible = false;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tex_LadoA.Clear();
            tex_LadoB.Clear();
            tex_Area.Clear();
            tex_Peri.Clear();
            picbox_cuadrado.Visible = false;
            picbox_rectan.Visible = false;
        }

        private void btn_calculo_Click(object sender, EventArgs e)
        {
            //DECLARACIÓN DE VARIABLES

           
            try
            {
                double ladoA, ladoB;
                double area, perimetro;

                ladoA = int.Parse(tex_LadoA.Text);
                ladoB = int.Parse(tex_LadoB.Text);

                //CONDICIONAL 
                if (ladoA == ladoB)
                {
                    picbox_cuadrado.Visible = true;

                }
                else
                {
                    picbox_cuadrado.Visible = false;
                }

                if (ladoA != ladoB)
                {
                    picbox_rectan.Visible = true;
                }
                else
                {
                    picbox_rectan.Visible = false;
                }

                //CALCULO DE AREA Y PERIMETRO
                area = ladoA * ladoB;
                perimetro = 2 * (ladoA + ladoB);

                //SALIDA DE DATOS 
                tex_Area.Text = Convert.ToString(area);
                tex_Peri.Text = Convert.ToString(perimetro);
            }
            catch
                     {

                MessageBox.Show("Por favor, ingrese números solamente.", 
                    "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
            {

            }
        }
    }
}
