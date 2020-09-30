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
        private Livro livro;
        //Instanciar as listas de movimentação ou itens movimentação, ver no modelo do professor "cadastrarVenda" -> https://github.com/dideconto/desenvolvimentomicrosoftnoite
        public frmAlugarLivro()
        {
            InitializeComponent();
        }

        private void btnAlugarLivro_Click(object sender, RoutedEventArgs e)
        {
            //Desenvolver o Metódo
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
