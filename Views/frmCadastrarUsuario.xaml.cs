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
    /// Interaction logic for frmCadastrarUsuario.xaml
    /// </summary>
    public partial class frmCadastrarUsuario : Window
    {
        private Usuario usuario;
        public frmCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();

            txtNome.Focus();
        }

        private void btnCadastrarUsuario(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                Usuario usuario = new Usuario
                {
                    Nome = txtNome.Text,
                    Cpf = txtCpf.Text,
                    Email = txtEmail.Text,
                    
                };
                if (UsuarioDAO.Cadastrar(usuario))
                {
                    MessageBox.Show("Usuário Cadastrado com Sucesso.", "Biblioteca", MessageBoxButton.OK, MessageBoxImage.Information);
                    LimparFormulario();
                }
                else
                {
                    MessageBox.Show("Esse usuário já existe.", "Biblioteca", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Campo nome é obrigatório.", "Biblioteca", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
