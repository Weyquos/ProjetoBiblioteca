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
    /// Interaction logic for frmDevolverLivro.xaml
    /// </summary>
    public partial class frmDevolverLivro : Window
    {
        private Movimentacao movimentacao = new Movimentacao();
        private Livro livro;
        private Usuario usuario = new Usuario();
        public frmDevolverLivro()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Carregar os dados de clientes
            cboUsuario.ItemsSource = UsuarioDAO.Listar();
            cboUsuario.DisplayMemberPath = "Cpf";
            cboUsuario.SelectedValuePath = "Id";
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtEditora.Clear();
            txtAnoPublicacao.Clear();
            txtAutor.Clear();
            btnDevolver.IsEnabled = false;
            txtNome.Focus();
        }

        private void btnBuscarLivroEUsuario_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                livro = LivroDAO.BuscarPorNome(txtNome.Text);
                usuario = UsuarioDAO.BuscarPorCpf(cboUsuario.Text);
                if (livro != null && usuario != null)
                {
                    btnDevolver.IsEnabled = true;

                    txtNome.Text = livro.Nome;
                    txtEditora.Text = livro.Editora;
                    txtAnoPublicacao.Text = livro.AnoPublicacao;
                    txtAutor.Text = livro.Autor;
                }
                else
                {
                    MessageBox.Show("Esse livro não está em posse desse CPF.", "Biblioteca",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    LimparFormulario();
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo nome ou e selecione um CPF.", "Biblioteca",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnDevolverLivro_Click(object sender, RoutedEventArgs e)
        {
            if (livro.Status.Equals("Disponivel"))
            {
                MessageBox.Show("O livro já foi entregue.", "Biblioteca", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                livro.Status = "Disponivel";
                int idUsuario = (int)cboUsuario.SelectedValue;
                movimentacao.Usuario = UsuarioDAO.BuscarPorId(idUsuario);
                MovimentacaoDAO.Cadastrar(movimentacao);
                MessageBox.Show("Livro disponível com sucesso.", "Biblioteca", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
