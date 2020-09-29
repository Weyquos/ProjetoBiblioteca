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
    /// Interaction logic for frmRemoverUsuario.xaml
    /// </summary>
    public partial class frmRemoverUsuario : Window
    {
        private Usuario usuario;
        public frmRemoverUsuario()
        {
            InitializeComponent();
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();

            txtCpf.Focus();
        }

        private void btnBuscarUsuario(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCpf.Text))
            {
                usuario = UsuarioDAO.BuscarPorCpf(txtCpf.Text);
                if (usuario != null)
                {
                    txtNome.Text = usuario.Nome;
                    txtCpf.Text = usuario.Cpf;
                    txtEmail.Text = usuario.Email;
                }
                else
                {
                    MessageBox.Show("Esse usuário não existe.", "Biblioteca",
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

        private void btnRemoverUsuario(object sender, RoutedEventArgs e)
        {
            if (usuario != null)
            {
                UsuarioDAO.RemoverUsuario(usuario);
                MessageBox.Show("O usuário foi removido com sucesso.", "Biblioteca", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("O usuário não foi removido.", "Biblioteca", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            LimparFormulario();
        }
    }
}
