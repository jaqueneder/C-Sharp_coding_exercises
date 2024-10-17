using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppExercicio2
{
    public partial class Form1 : Form
    {

        int[] vetorOriginal = new int[10]; // declaração do vetor que vai receber os números como variável global
        int[] vetorDobro = new int[10]; // declaração do vetor que vai guardar os números depois de calculados
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            if (i < 10)
            {
                vetorOriginal[i] = Convert.ToInt32(textBoxNumeros.Text);
                vetorDobro[i] = vetorOriginal[i] * 2; // calcula o dobro de cada elemento do vetor original e gurda no segundo vetor
                i++;
                textBoxNumeros.Clear();
                textBoxNumeros.Focus();
            }

            if (i == 10)
            {
                textBoxNumeros.Enabled = false;
                buttonInserir.Enabled = false;
            }

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            listBoxNumerosOriginal.Items.Clear();
            listBoxNumerosDobro.Items.Clear();

            for (i = 0; i < vetorOriginal.Length; i++)
            {
                listBoxNumerosOriginal.Items.Add(vetorOriginal[i]); // exibe o vetor original na listBoxNumerosOriginal
                listBoxNumerosDobro.Items.Add(vetorDobro[i]); // exibe o segundo vetor na listBoxNumerosDobro
            }

        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            i = 0;
            textBoxNumeros.Enabled = true;
            buttonInserir.Enabled = true;
            textBoxNumeros.Clear();
            listBoxNumerosOriginal.Items.Clear();
            listBoxNumerosDobro.Items.Clear();

        }
    }
}
