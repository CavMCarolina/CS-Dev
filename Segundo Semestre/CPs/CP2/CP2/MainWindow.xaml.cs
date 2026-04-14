using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CP2
{
    public partial class MainWindow : Window
    {
        private readonly AlunoRepository _repo = new AlunoRepository();

        public MainWindow()
        {
            InitializeComponent();
            CarregarAlunos();
        }

        private void CarregarAlunos()
        {
            try
            {
                DgAlunos.ItemsSource = _repo.ListarTodos();
                TxtStatus.Text = "Alunos carregados com sucesso.";
            }
            catch (Exception ex)
            {
                TxtStatus.Text = $"Erro ao carregar: {ex.Message}";
            }
        }

        private void BtnInserir_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidarCampos(exigirId: false)) return;

            var aluno = new Aluno
            {
                Nome = TxtNome.Text.Trim(),
                Idade = int.Parse(TxtIdade.Text.Trim())
            };

            try
            {
                _repo.Inserir(aluno);
                TxtStatus.Text = $"Aluno '{aluno.Nome}' inserido com sucesso!";
                LimparCampos();
                CarregarAlunos();
            }
            catch (Exception ex)
            {
                TxtStatus.Text = $"Erro ao inserir: {ex.Message}";
            }
        }

        private void BtnListar_Click(object sender, RoutedEventArgs e)
        {
            CarregarAlunos();
        }

        private void BtnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidarCampos(exigirId: true)) return;

            var aluno = new Aluno
            {
                Id = int.Parse(TxtId.Text),
                Nome = TxtNome.Text.Trim(),
                Idade = int.Parse(TxtIdade.Text.Trim())
            };

            try
            {
                bool atualizado = _repo.Atualizar(aluno);
                TxtStatus.Text = atualizado
                    ? $"Aluno ID {aluno.Id} atualizado com sucesso!"
                    : "Nenhum aluno encontrado com esse ID.";
                LimparCampos();
                CarregarAlunos();
            }
            catch (Exception ex)
            {
                TxtStatus.Text = $"Erro ao atualizar: {ex.Message}";
            }
        }

        private void BtnRemover_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtId.Text))
            {
                TxtStatus.Text = "Selecione um aluno na tabela para remover.";
                return;
            }

            int id = int.Parse(TxtId.Text);
            var confirmacao = MessageBox.Show(
                $"Tem certeza que deseja remover o aluno ID {id}?",
                "Confirmar remoção", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (confirmacao != MessageBoxResult.Yes) return;

            try
            {
                bool removido = _repo.Remover(id);
                TxtStatus.Text = removido
                    ? $"Aluno ID {id} removido com sucesso!"
                    : "Nenhum aluno encontrado com esse ID.";
                LimparCampos();
                CarregarAlunos();
            }
            catch (Exception ex)
            {
                TxtStatus.Text = $"Erro ao remover: {ex.Message}";
            }
        }

        private void BtnBuscarId_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtId.Text))
            {
                TxtStatus.Text = "Digite um ID no campo para buscar.";
                return;
            }

            try
            {
                int id = int.Parse(TxtId.Text);
                var aluno = _repo.BuscarPorId(id);

                if (aluno != null)
                {
                    TxtNome.Text = aluno.Nome;
                    TxtIdade.Text = aluno.Idade.ToString();
                    TxtStatus.Text = $"Aluno encontrado: {aluno.Nome}, {aluno.Idade} anos.";
                }
                else
                {
                    TxtStatus.Text = $"Nenhum registro encontrado para o ID {id}.";
                }
            }
            catch (Exception ex)
            {
                TxtStatus.Text = $"Erro ao buscar: {ex.Message}";
            }
        }

        private void DgAlunos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgAlunos.SelectedItem is Aluno aluno)
            {
                TxtId.Text = aluno.Id.ToString();
                TxtNome.Text = aluno.Nome;
                TxtIdade.Text = aluno.Idade.ToString();
            }
        }

        private bool ValidarCampos(bool exigirId)
        {
            if (exigirId && string.IsNullOrWhiteSpace(TxtId.Text))
            {
                TxtStatus.Text = "Selecione um aluno na tabela primeiro.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtNome.Text))
            {
                TxtStatus.Text = "Informe o nome do aluno.";
                return false;
            }
            if (!int.TryParse(TxtIdade.Text, out int idade) || idade <= 0)
            {
                TxtStatus.Text = "Informe uma idade válida.";
                return false;
            }
            return true;
        }

        private void LimparCampos()
        {
            TxtNome.Text = "";
            TxtIdade.Text = "";
            DgAlunos.SelectedItem = null;
        }

        private void BtnSair_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}