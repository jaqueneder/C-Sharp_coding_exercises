using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppExercicio1
{
    public partial class Form1 : Form
    {

        int[] numeros = new int[15]; 
        int i = 0; // criação e inicialização do vetor como variável global

        public Form1()
        {
            InitializeComponent();
        }
        private void buttonInserir_Click(object sender, EventArgs e) // link para o botão Inserir
        {
            if (i < 15) // verifica quantos elementos tem no vetor
            {
                numeros[i] = Convert.ToInt32(textBoxNumeros.Text); // converte oque foi recebido do textBoxNumeros para um int e o armazena no vetor
                i++;
                textBoxNumeros.Clear();
                textBoxNumeros.Focus(); // limpa e foca o textBoxNumeros para a próxima entrada
            }

            if (i == 15) // verifica se o vetor está cheio
            {
                textBoxNumeros.Enabled = false;
                buttonInserir.Enabled = false; // bloqueia de escrever e inserir números
            }

        }
        private void buttonDividir_Click(object sender, EventArgs e) // link para o botão Dividir
        {
            int maiorValor = numeros.Max(); // encontra o maior valor no vetor com a função Max()
            listBoxNumeros.Items.Clear();

            for (i = 0; i < numeros.Length; i++)
            {
                double resultado = (double)numeros[i] / maiorValor; // divide cada elemento do vetor pelo maior valor
                listBoxNumeros.Items.Add(resultado); // exibe o resultado na listBoxNumeros
            }

        }

        private void buttonReiniciar_Click(object sender, EventArgs e) // link para o botão Reiniciar
        {
            i = 0; // reinicia a variável contadora
            textBoxNumeros.Clear(); // limpa a textBoxNumeros
            listBoxNumeros.Items.Clear(); // limpa a listBoxNumeros
            textBoxNumeros.Enabled = true;
            buttonInserir.Enabled = true; // permite escrever e inserir números novamente
        }
    }
}
