   M S B A M L   `   `   `  ����E  AProjetoWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ProjetoWPF.ViewsProjetoWPF.Views  5   	   '    !ProjetoWPF.Views.frmDevolverLivro   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ProjetoWPF.Views     5   	     � Title$  Devolver Livro��5   	   $	��280��6    $	��352��6-    � UseLayoutRounding$
 True��69    � WindowStartupLocation$ CenterScreen=�6R   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��65* �6   �� 5      $	��12* �6   �� 5      $	��11* �6   .+�5   
   �� -   5         ��Name$ txtNome��5      $
��Left=�6$   $��
150,60,0,0q�6?   $�� ��6S    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��120��6�   $��2��6�   $��0��6�   �� 5   
   -   5        $ 
txtEditora��5      $
��Left=�6'   $��
150,90,0,0q�6B   $�� ��6V   $
 Wrap=�6^   $	��Top=�6r   $	��120��6�   $��2��6�   $��1��6�   ${�False��6�   �� 5   
   -   5        $ txtAnoPublicacao��5      $
��Left=�6-   $��150,120,0,0q�6H   $�� ��6]   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   $��2��6�   $��2��6�   ${�False��6�   �� 5   
   -   5        $ txtAutor��5      $
��Left=�6%   $��150,150,0,0q�6@   $�� ��6U   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   $��2��6�   $��3��6�   ${�False��6�   �� 5   
   $��Devolver Livro��6   $��Arial)�6)   $��16(�6<   $��Medium&�6J   $��3��6_   $��5��6s   �� 5   
   $��Nome:��6   $��Arial)�6    $��12(�63   $
��Left=�6A   $��9,60,0,0q�6\   $	��Top=�6n   �� 5   
   $��Editora:��6   $��Arial)�6#   $��12(�66   $
��Left=�6D   $��9,90,0,0q�6_   $	��Top=�6q   �� 5   
   $��Ano de Publicação:��6   $��Arial)�6-   $��12(�6@   $
��Left=�6N   $��	9,120,0,0q�6i   $	��Top=�6|   �� 5   
   $��Autor:��6   $��Arial)�6!   $��12(�64   $
��Left=�6B   $��	9,150,0,0q�6]   $	��Top=�6p   �� 5   
   -   5         ��Name$ btnDevolver��5      $��Devolver��6'   $
��Left=�6:   $��198,194,0,0q�6U   $	��Top=�6j   $��25��6�   $��72��6�   $��Arial)�6�   $��14(�6�   $��Medium&�6�   $��Normal"�6�   ���	#FF171917 � ForceCursor$
 True��6�   ���#7FFFD4$��2��6"  $��7��6U  ${�False��6b  6v  �� 5   
   -   5        $��Buscar��5      $
��Left=�6"   $��104,194,0,0q�6=   $	��Top=�6R   $��25��6j   $��72��6v   $��Arial)�6�   $��14(�6�   $��Medium&�6�   $��Normal"�6�   ���	#FF171917$
 True��6�   ���#F8F8FF$��6��6'  5      5      