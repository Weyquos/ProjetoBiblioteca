using ProjetoWPF.DAL;
using ProjetoWPF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjetoWPF.Views
{
    /// <summary>
    /// Interaction logic for frmAlugarLivro.xaml
    /// </summary>
    public partial class frmAlugarLivro : Window
    {
        private Movimentacao movimentacao = new Movimentacao();
        private Livro livro;
        public frmAlugarLivro()
        {
            InitializeComponent();
        }

        private void btnAlugarLivro_Click(object sender, RoutedEventArgs e)
        {
            if(livro.Status.Equals("Locado"))
            {
                MessageBox.Show("O livro já está alugado.", "Biblioteca", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                int idUsuario = (int)cboUsuario.SelectedValue;
                movimentacao.Usuario = UsuarioDAO.BuscarPorId(idUsuario);
                MovimentacaoDAO.Cadastrar(movimentacao);
                MessageBox.Show("Livro alugado com sucesso.", "Biblioteca", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtEditora.Clear();
            txtAnoPublicacao.Clear();
            txtAutor.Clear();
            btnAlugar.IsEnabled = false;
            txtNome.Focus();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Carregar os dados de clientes
            cboUsuario.ItemsSource = UsuarioDAO.Listar();
            cboUsuario.DisplayMemberPath = "Cpf";
            cboUsuario.SelectedValuePath = "Id";
        }

        private void btnBuscarLivro_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                livro = LivroDAO.BuscarPorNome(txtNome.Text);
                if (livro != null)
                {
                    btnAlugar.IsEnabled = true;

                    txtNome.Text = livro.Nome;
                    txtEditora.Text = livro.Editora;
                    txtAnoPublicacao.Text = livro.AnoPublicacao;
                    txtAutor.Text = livro.Autor;
                    livro.Status = "Locado";
                }
                else
                {
                    MessageBox.Show("Esse livro não existe.", "Biblioteca",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    LimparFormulario();
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo nome.", "Biblioteca",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
