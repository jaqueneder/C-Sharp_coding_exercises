using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSistemaAtendimento
{
    public partial class Form1 : Form
    {
        private Queue<string> filaNormal = new Queue<string>();
        private Queue<string> filaPrioritaria = new Queue<string>();
        private int contadorNormal = 0;
        private int contadorPrioritario = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGerarSenhaNormal_Click(object sender, EventArgs e)
        {
            contadorNormal++;
            string senha = "N" + contadorNormal.ToString("D3");
            filaNormal.Enqueue(senha);
            AtualizarExibicao();
            MessageBox.Show("Senha Normal gerada: " + senha);
        }

        private void buttonGerarSenhaPrioritaria_Click(object sender, EventArgs e)
        {
            contadorPrioritario++;
            string senha = "P" + contadorPrioritario.ToString("D3");
            filaPrioritaria.Enqueue(senha);
            AtualizarExibicao();
            MessageBox.Show("Senha Prioritária gerada: " + senha);
        }

        private void buttonAtenderNormal_Click(object sender, EventArgs e)
        {
            if (filaNormal.Count > 0)
            {
                string senha = filaNormal.Dequeue();
                MessageBox.Show("Atendendo senha: " + senha);
                AtualizarExibicao();
            }
            else
            {
                MessageBox.Show("Não há senhas normais na fila.");
            }
        }

        private void buttonAtenderPrioritaria_Click(object sender, EventArgs e)
        {
            if (filaPrioritaria.Count > 0)
            {
                string senha = filaPrioritaria.Dequeue();
                MessageBox.Show("Atendendo senha: " + senha);
                AtualizarExibicao();
            }
            else
            {
                MessageBox.Show("Não há senhas prioritárias na fila.");
            }
        }

        private void buttonLimparFila_Click(object sender, EventArgs e)
        {
            filaNormal.Clear();
            filaPrioritaria.Clear();
            AtualizarExibicao();
            MessageBox.Show("As filas foram limpas.");
        }

        private void AtualizarExibicao()
        {
            listaFilaNormal.Items.Clear();
            listaFilaPrioritaria.Items.Clear();

            foreach (var senha in filaNormal)
            {
                listaFilaNormal.Items.Add(senha);
            }

            foreach (var senha in filaPrioritaria)
            {
                listaFilaPrioritaria.Items.Add(senha);
            }
        }
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
