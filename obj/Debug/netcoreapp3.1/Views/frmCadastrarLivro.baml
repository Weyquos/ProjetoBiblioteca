   M S B A M L   `   `   `  ����E  AProjetoWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ProjetoWPF.ViewsProjetoWPF.Views  5   	   (    "ProjetoWPF.Views.frmCadastrarLivro   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ProjetoWPF.Views     5   	   -   5          � Title$  Cadastrar Livro��5   	   $	��340��6!   $	��352��6.    � UseLayoutRounding$
 True��6:    � WindowStartupLocation$ CenterScreen=�6S   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��65* �6   �� 5      $	��12* �6   �� 5      $	��11* �6   .+�5   
   �� -   5         ��Name$ txtNome��5      $
��Left=�6$   $��
150,60,0,0q�6?   $�� ��6S    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��120��6�   $��2��6�   $��0��6�   �� 5   
   -   5        $ 
txtEditora��5      $
��Left=�6'   $��
150,90,0,0q�6B   $�� ��6V   $
 Wrap=�6^   $	��Top=�6r   $	��120��6�   $��2��6�   $��1��6�   �� 5   
   -   5        $ txtAnoPublicacao��5      $
��Left=�6-   $��150,120,0,0q�6H   $�� ��6]   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   $��2��6�   $��2��6�   �� 5   
   -   5        $ txtAutor��5      $
��Left=�6%   $��150,150,0,0q�6@   $�� ��6U   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   $��2��6�   $��3��6�   �� 5   
   -   5        $ txtQuantidade��5      $
��Left=�6*   $��150,180,0,0q�6E   $�� ��6Z   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   $��2��6�   $��4��6�   �� 5   
   $��Cadastrar Livro��6   $��Arial)�6*   $��16(�6=   $��Medium&�6K   $��3��6`   $��5��6t   �� 5   
   $��Nome:��6   $��Arial)�6    $��12(�63   $
��Left=�6A   $��9,60,0,0q�6\   $	��Top=�6n   �� 5   
   $��Editora:��6   $��Arial)�6#   $��12(�66   $
��Left=�6D   $��9,90,0,0q�6_   $	��Top=�6q   �� 5   
   $��Ano de Publicação:��6   $��Arial)�6-   $��12(�6@   $
��Left=�6N   $��	9,120,0,0q�6i   $	��Top=�6|   �� 5   
   $��Autor:��6   $��Arial)�6!   $��12(�64   $
��Left=�6B   $��	9,150,0,0q�6]   $	��Top=�6p   �� 5   
   $��Quantidade:��6   $��Arial)�6&   $��12(�69   $
��Left=�6G   $��	9,180,0,0q�6b   $	��Top=�6u    J� RenderTransformOrigin$ 0.355,0.538&�6�   �� 5   
   $��Editora:��6   $��Arial)�6#   $��12(�66   $
��Left=�6D   $��9,90,0,0q�6_   $	��Top=�6q   �� 5   
   -   5        $��	Cadastrar��5      $
��Left=�6%   $��150,247,0,0q�6@   $	��Top=�6U   $��23��6m   $	��120��6y   $��Arial)�6�   $��14(�6�   $��Medium&�6�   $��Normal"�6�   ���	#FF171917 � ForceCursor$
 True��6�   ���	#FF68AA3A$��2��6  6@  �� 5   
   -   5         ��Name$ cboCategoria��5      $
��Left=�6)   $��150,208,0,0q�6D   $	��Top=�6Y   $	��120��6q   $��2��6}   $��24��6�   �� 5   
   $��
Categoria:��6   $��Arial)�6%   $��12(�68   $
��Left=�6F   $��	9,208,0,0q�6a   $	��Top=�6t   $ 0.355,0.538&�6�   5      5      