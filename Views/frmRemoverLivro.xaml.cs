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
    /// Interaction logic for frmRemoverLivro.xaml
    /// </summary>
    public partial class frmRemoverLivro : Window
    {
        private Livro livro;
        public frmRemoverLivro()
        {
            InitializeComponent();
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtEditora.Clear();
            txtAnoPublicacao.Clear();
            txtAutor.Clear();

            txtNome.Focus();
        }

        private void btnBuscarLivro(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                livro = LivroDAO.BuscarPorNome(txtNome.Text);
                if (livro != null)
                {
                    txtNome.Text = livro.Nome;
                    txtEditora.Text = livro.Editora;
                    txtAnoPublicacao.Text = livro.AnoPublicacao;
                    txtAutor.Text = livro.Autor;
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

        private void btnRemoverLivro(object sender, RoutedEventArgs e)
        {
            if (livro != null)
            {
                LivroDAO.RemoverLivro(livro);
                MessageBox.Show("O livro foi removido com sucesso.", "Biblioteca", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("O livro não foi removido.", "Biblioteca", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            LimparFormulario();
        }
    }
}
