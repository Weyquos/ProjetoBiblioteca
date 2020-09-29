﻿using ProjetoWPF.DAL;
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cboCategoria.ItemsSource = CategoriaDAO.Listar();
            cboCategoria.SelectedValuePath = "Id";
        }

        private void btnCadastrarLivro(object sender, RoutedEventArgs e)
        {
            //pegar o txt quantidade e fazer um loop aqui e/ou (não tenho certeza, acho que é so no metodo cadastrar do livroDAO), no metodo cadastrar em LivroDAO
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                Livro livro = new Livro
                {
                    Nome = txtNome.Text,
                    Editora = txtEditora.Text,
                    AnoPublicacao = txtAnoPublicacao.Text,
                    Autor = txtAutor.Text,
                    //MessageBox.Show($"Id: {cboCategoria.SelectedValue}");
                };
                if (LivroDAO.Cadastrar(livro))
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