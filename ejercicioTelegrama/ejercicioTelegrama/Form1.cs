﻿using System;
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
            string textoTelegrama;
            char tipoTelegrama;
            int numPalabras = 0;
            double coste;

            // Leer el contenido del telegrama
            textoTelegrama = txtTelegrama.Text;

            // Determinar el tipo de telegrama según el RadioButton seleccionado
            if (rbUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            else
            {
                tipoTelegrama = 'o';
            }

            // Calcular el número de palabras del telegrama
            string[] palabras = textoTelegrama.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            numPalabras = palabras.Length;

            // Calcular el coste según el tipo de telegrama
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {   
                    coste = 3;
                }
                else
                {
                    coste = 3 + 0.5 * (numPalabras - 10);
                }
            }
            else // tipoTelegrama == 'u'
            {
                if (numPalabras <= 10)
                {
                    coste = 6;
                }
                else
                {
                    coste = 6 + 0.75 * (numPalabras - 10);
                }
            }

            // Mostrar el coste en el TextBox correspondiente
            txtPrecio.Text = coste.ToString() + " euros"; // Mostrar sin formato decimal
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
