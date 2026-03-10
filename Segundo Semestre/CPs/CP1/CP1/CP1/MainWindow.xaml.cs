using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace CP1
{
    public partial class MainWindow : Window
    {
        private Cadastro<Pessoa> cadastro = new Cadastro<Pessoa>();
        private List<Pessoa> lista = new List<Pessoa>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EntradaNome.Text))
            {
                MessageBox.Show("O nome não pode estar vazio!");
                return;
            }

            if (int.TryParse(EntradaID.Text, out int id) && int.TryParse(EntradaIdade.Text, out int idade))
            {
                Pessoa p = new Pessoa { Id = id, Nome = EntradaNome.Text, Idade = idade };
                cadastro.Adicionar(id, p);
                lista.Add(p);

                MessageBox.Show($"Pessoa adicionada: {p.Nome}, {p.Idade} anos (ID: {p.Id})");
            }
            else
            {
                MessageBox.Show("ID ou Idade inválidos!");
            }
        }

        private void BtnListar_Click(object sender, RoutedEventArgs e)
        {
            TabelaCadastro.ItemsSource = null;
            TabelaCadastro.ItemsSource = lista;
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(EntradaBuscaID.Text, out int id))
            {
                var pessoa = cadastro.BuscarPorId(id);
                if (pessoa != null)
                    MessageBox.Show($"Encontrado: {pessoa}");
                else
                    MessageBox.Show("Pessoa não encontrada.");
            }
            else
            {
                MessageBox.Show("ID inválido!");
            }
        }

        private void BtnRemover_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EntradaID.Text))
            {
                MessageBox.Show("Por favor, insira um ID para remover.");
                return;
            }

            if (int.TryParse(EntradaID.Text, out int id))
            {
                bool removido = cadastro.Remover(id);
                var pessoaRemovida = lista.FirstOrDefault(p => p.Id == id);

                if (pessoaRemovida != null)
                {
                    lista.Remove(pessoaRemovida);
                    MessageBox.Show("Pessoa removida com sucesso!");
                }
                else if (!removido)
                {
                    MessageBox.Show("Nenhuma pessoa encontrada com esse ID.");
                }
            }
            else
            {
                MessageBox.Show("ID inválido! Digite apenas números.");
            }
        }

        private void BtnLimpar_Click(object sender, RoutedEventArgs e)
        {
            EntradaID.Clear();
            EntradaNome.Clear();
            EntradaIdade.Clear();
        }
    }
}