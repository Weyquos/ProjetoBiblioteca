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
    /// Interaction logic for frmAlterarUsuario.xaml
    /// </summary>
    public partial class frmAlterarUsuario : Window
    {
        private Usuario usuario;
        public frmAlterarUsuario()
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

        private void btnAlterarUsuario(object sender, RoutedEventArgs e)
        {
            if (usuario != null)
            {
                usuario.Nome = txtNome.Text;
                usuario.Cpf = txtCpf.Text;
                usuario.Email = txtEmail.Text;
                UsuarioDAO.AlterarDados(usuario);
                MessageBox.Show("Usuário alterado com Sucesso.", "Biblioteca", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Erro ao alterar usuário.", "Biblioteca", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            LimparFormulario();
        }
    }
}
