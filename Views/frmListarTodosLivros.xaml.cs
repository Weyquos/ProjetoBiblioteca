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
    /// Interaction logic for frmListarTodosLivros.xaml
    /// </summary>
    public partial class frmListarTodosLivros : Window
    {
        public frmListarTodosLivros()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtaLivros.ItemsSource = LivroDAO.Listar();
        }
    }
}
