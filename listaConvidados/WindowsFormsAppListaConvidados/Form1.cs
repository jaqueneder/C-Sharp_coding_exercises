using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsAppListaConvidados.Form1;

// Briena Bertoni
// Jaqueline Neder

namespace WindowsFormsAppListaConvidados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Convidado
        {
            public string Nome { get; set; }
            public Convidado Proximo { get; set; }

            public Convidado(string nome)
            {
                Nome = nome;
                Proximo = null;
            }
        }

        public class ListaConvidados
        {
            private Convidado primeiro;

            public ListaConvidados()
            {
                primeiro = null;
            }
            public bool ConvidadoExiste(string nome)
            {
                Convidado atual = primeiro;
                while (atual != null)
                {
                    if (atual.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                        return true;
                    atual = atual.Proximo;
                }
                return false;
            }

            public void AdicionarConvidado(string nome)
            {
                if (ConvidadoExiste(nome))
                {
                    MessageBox.Show("Esse nome já está na lista!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Convidado novoConvidado = new Convidado(nome);

                if (primeiro == null || string.Compare(primeiro.Nome, nome) > 0)
                {
                    novoConvidado.Proximo = primeiro;
                    primeiro = novoConvidado;
                }
                else
                {
                    Convidado atual = primeiro;
                    while (atual.Proximo != null && string.Compare(atual.Proximo.Nome, nome) < 0)
                    {
                        atual = atual.Proximo;
                    }
                    novoConvidado.Proximo = atual.Proximo;
                    atual.Proximo = novoConvidado;
                }
            }

            public void RemoverConvidado(string nome)
            {
                if (primeiro == null) return;

                if (primeiro.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    primeiro = primeiro.Proximo;
                    return;
                }

                Convidado atual = primeiro;
                while (atual.Proximo != null && !atual.Proximo.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    atual = atual.Proximo;
                }

                if (atual.Proximo != null)
                {
                    atual.Proximo = atual.Proximo.Proximo;
                }
            }

            public List<string> Listar()
            {
                List<string> convidados = new List<string>();
                Convidado atual = primeiro;
                while (atual != null)
                {
                    convidados.Add(atual.Nome);
                    atual = atual.Proximo;
                }
                return convidados;
            }
        }

        ListaConvidados listaConvidados = new ListaConvidados();

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text.Trim();
            if (!string.IsNullOrEmpty(nome))
            {
                listaConvidados.AdicionarConvidado(nome);
                textBoxNome.Clear();
            }
        }
        private void buttonRemover_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text.Trim();
            if (!string.IsNullOrEmpty(nome))
            {
                listaConvidados.RemoverConvidado(nome);
                textBoxNome.Clear();
            }
        }
        private void buttonExibir_Click(object sender, EventArgs e)
        {
            listBoxConvidados.Items.Clear();
            List<string> convidados = listaConvidados.Listar();

            foreach (var nome in convidados)
            {
                listBoxConvidados.Items.Add(nome);
            }
        }
    }
}
