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
    /// Interaction logic for frmPrincipal.xaml
    /// </summary>
    public partial class frmPrincipal : Window
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuSair_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultado = MessageBox.Show("Fechar Aplicação?", "Biblioteca", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if(resultado == MessageBoxResult.OK)
            {
                Close();
            }
        }

        private void menuCadastrarLivro_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarLivro frm = new frmCadastrarLivro();
            frm.ShowDialog();
        }

        private void menuCadastrarCategoria_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarCategoria frm = new frmCadastrarCategoria();
            frm.ShowDialog();
        }

        private void menuRemoverLivro_Click(object sender, RoutedEventArgs e)
        {
            frmRemoverLivro frm = new frmRemoverLivro();
            frm.ShowDialog();
        }

        private void menuRemoverUsuario_Click(object sender, RoutedEventArgs e)
        {
            frmRemoverUsuario frm = new frmRemoverUsuario();
            frm.ShowDialog();
        }

        private void menuAlterarLivro_Click(object sender, RoutedEventArgs e)
        {
            frmAlterarLivro frm = new frmAlterarLivro();
            frm.ShowDialog();
        }

        private void menuAlterarUsuario_Click(object sender, RoutedEventArgs e)
        {
            frmAlterarUsuario frm = new frmAlterarUsuario();
            frm.ShowDialog();
        }

        private void menuAlugarLivro_Click(object sender, RoutedEventArgs e)
        {
            frmAlugarLivro frm = new frmAlugarLivro();
            frm.ShowDialog();
        }

        private void menuCadastrarUsuario_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarUsuario frm = new frmCadastrarUsuario();
            frm.ShowDialog();
        }

        private void menuListarTodosLivros_Click(object sender, RoutedEventArgs e)
        {
            frmListarTodosLivros frm = new frmListarTodosLivros();
            frm.ShowDialog();
        }

        private void menuListarLivrosLocados_Click(object sender, RoutedEventArgs e)
        {
            frmListarLivrosLocados frm = new frmListarLivrosLocados();
            frm.ShowDialog();
        }
    }
}
