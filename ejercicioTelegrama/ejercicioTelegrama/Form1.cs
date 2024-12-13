using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama = txtTelegrama.Text;
            char tipoTelegrama;
            int numPalabras = 0;
            double coste;

            // Determinar el tipo de telegrama
            tipoTelegrama = chkUrgente.Checked ? 'u' : 'o';

            // Obtener el número de palabras de la cadena
            string[] palabras = textoTelegrama.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            numPalabras = palabras.Length;

            // Calcular el coste según el tipo de telegrama
            if (tipoTelegrama == 'o') // Telegrama ordinario
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            else // Telegrama urgente
            {
                if (numPalabras <= 10)
                {
                    coste = 5;
                }
                else
                {
                    coste = 5 + 0.75 * (numPalabras - 10);
                }
            }

            // Mostrar el coste en el TextBox sin formato específico
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
    
}
