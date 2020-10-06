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
    /// Interaction logic for CadastrarLivro.xaml
    /// </summary>
    public partial class frmCadastrarLivro : Window
    {
        public int quantidade = 0;
        public void auxQtd(int qtd = 0)
        {
            if (txtQuantidade.Text != "")
            {
                if (Int32.TryParse(txtQuantidade.Text, out qtd)) ;

            }
            if (qtd != 0)
                quantidade = qtd;
        }

        public frmCadastrarLivro()
        {
            InitializeComponent();
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtEditora.Clear();
            txtAnoPublicacao.Clear();
            txtAutor.Clear();
            txtQuantidade.Clear();

            txtNome.Focus();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Carregar os dados de clientes
            cboCategoria.ItemsSource = CategoriaDAO.Listar();
            cboCategoria.DisplayMemberPath = "Nome";
            cboCategoria.SelectedValuePath = "Id";
        }

        private void btnCadastrarLivro(object sender, RoutedEventArgs e)
        {
            auxQtd();
            //pegar o txt quantidade e fazer um loop aqui e/ou (não tenho certeza, acho que é so no metodo cadastrar do livroDAO), no metodo cadastrar em LivroDAO
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                int id = (int)cboCategoria.SelectedValue;
                Categoria categoria = CategoriaDAO.BuscarPorId(id);

                var livros = new List<Livro>();

                for (int i = 0; i < quantidade; i++)
                {
                    Livro livro = new Livro
                    {
                        Nome = txtNome.Text,
                        Editora = txtEditora.Text,
                        AnoPublicacao = txtAnoPublicacao.Text,
                        Autor = txtAutor.Text,
                        Categoria = categoria,
                    };

                    livros.Add(livro);

                }

                if (LivroDAO.Cadastrar(livros, quantidade))
                {
                    MessageBox.Show("Livro Cadastrado com Sucesso.", "Biblioteca", MessageBoxButton.OK, MessageBoxImage.Information);
                    LimparFormulario();
                }
                else
                {
                    MessageBox.Show("Esse Livro já existe.", "Biblioteca", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Campo nome é obrigatório.", "Biblioteca", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
