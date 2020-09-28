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
    /// Interaction logic for frmCadastrarCategoria.xaml
    /// </summary>
    public partial class frmCadastrarCategoria : Window
    {
        public frmCadastrarCategoria()
        {
            InitializeComponent();
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtNome.Focus();
        }

        private void btnCadastrarCategoria(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                Categoria categoria = new Categoria
                {
                    Nome = txtNome.Text,  
                };
                if (CategoriaDAO.Cadastrar(categoria))
                {
                    MessageBox.Show("Categoria Cadastrada com Sucesso.", "Biblioteca", MessageBoxButton.OK, MessageBoxImage.Information);
                    LimparFormulario();
                }
                else
                {
                    MessageBox.Show("Essa Categoria já existe.", "Biblioteca", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Campo nome é obrigatório.", "Biblioteca", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

