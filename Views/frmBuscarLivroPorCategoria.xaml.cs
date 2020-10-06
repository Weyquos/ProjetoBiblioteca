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
    /// Interaction logic for frmBuscarLivroPorCategoria.xaml
    /// </summary>
    public partial class frmBuscarLivroPorCategoria : Window
    {
        public frmBuscarLivroPorCategoria()
        {
            InitializeComponent();
        }

        private void btnBuscarLivroPorCategoria_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cboCategoria.Text))
            {
                //livro = LivroDAO.BuscarPorCategoria(cboCategoria.Text);
                if (LivroDAO.BuscarPorCategoria(cboCategoria.Text) != null)
                {
                    dtaLivrosPorCategoria.ItemsSource = LivroDAO.BuscarPorCategoria(cboCategoria.Text);
                    dtaLivrosPorCategoria.Items.Refresh();
                }
                else
                {
                    MessageBox.Show("Não existe livro cadastrado nessa categoria.", "Biblioteca",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo Categoria.", "Biblioteca",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            cboCategoria.ItemsSource = CategoriaDAO.Listar();
            cboCategoria.DisplayMemberPath = "Nome";
            cboCategoria.SelectedValuePath = "Id";
        }

    }
}
