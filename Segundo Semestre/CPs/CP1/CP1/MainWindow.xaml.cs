using System.Collections.ObjectModel;
using System.Windows;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace CP1
{
    public partial class MainWindow : Window
    {
        private Cadastro<Pessoa> cadastro = new Cadastro<Pessoa>();
        private ObservableCollection<Pessoa> lista = new ObservableCollection<Pessoa>();

        public MainWindow()
        {
            InitializeComponent();
            TabelaCadastro.ItemsSource = lista; // vincula DataGrid
        }

        private void BtnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(EntradaID.Text, out int id))
            {
                Pessoa p = new Pessoa { Id = id, Nome = EntradaNome.Text };
                cadastro.Adicionar(id, p);
                lista.Add(p);
            }
            else
            {
                MessageBox.Show("ID inválido!");
            }
        }

        private void BtnListar_Click(object sender, RoutedEventArgs e)
        {
            lista.Clear();
            foreach (var pessoa in cadastro.ListarTodos())
            {
                lista.Add(pessoa);
            }
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(EntradaID.Text, out int id))
            {
                var pessoa = cadastro.BuscarPorId(id);
                if (pessoa != null)
                    MessageBox.Show($"Encontrado: {pessoa}");
                else
                    MessageBox.Show("Pessoa não encontrada.");
            }
        }

        private void BtnRemover_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(EntradaID.Text, out int id))
            {
                cadastro.Remover(id);
                var pessoaRemovida = lista.FirstOrDefault(p => p.Id == id);
                if (pessoaRemovida != null)
                    lista.Remove(pessoaRemovida);
            }
        }

        private void BtnLimpar_Click(object sender, RoutedEventArgs e)
        {
            EntradaID.Clear();
            EntradaNome.Clear();
        }
    }
}
