   M S B A M L   `   `   `  ����E  AProjetoWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ProjetoWPF.ViewsProjetoWPF.Views  5   	   1    +ProjetoWPF.Views.frmBuscarLivroPorCategoria   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ProjetoWPF.Views     5   	   -   5          � Title$   Buscar Livro Por Categoria��5   	   $	��400��6,   $	��520��69    � UseLayoutRounding$
 True��6E    � WindowStartupLocation$ CenterScreen=�6^   .��5	      � .+�5   
   �� $ ��Buscar Livro Por Categoria��6   $��Arial)�65   $��16(�6H   $��Medium&�6V   $��3��6k   �� 5   
   $��
Categoria:��6   $��Arial)�6%   $��12(�68   $
��Left=�6F   $��	31,50,0,0q�6a   $	��Top=�6t    J� RenderTransformOrigin$ 
0.39,1.953&�6�   �� 5   
   -   5        $��Buscar��5      $
{�True��6"   $
��Left=�63   $��
176,97,0,0q�6N   $	��Top=�6b   $��25��6z   $��72��6�   $��Arial)�6�   $��14(�6�   $��Medium&�6�   $��Normal"�6�   ���	#FF171917 � ForceCursor$
 True��6�   ���#F8F8FF$��4��6D  &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtaLivrosPorCategoria��5         AutoGenerateColumns$ False��62   $��Center=�6N   $	��Top=�6k   $	��167��6�   $	��458��6�   $��	0,164,0,0q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nome��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 63   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6=   �� *Nome+6X     5      $ Autor��6%   $	 * 64   
 6>   �� *Autor+6Z     5      $ Editora��6%   $	 * 66   
 6@   �� *	Editora+6^     5      $ Ano de Publicação��6%   $		 150 6@   
 6L   �� *AnoPublicacao+6p     5      $ Status��6%   $	 * 65   
 6?   �� *Status+6\   5      �� 5   
   -   5         ��Name$ cboCategoria��5      $
��Left=�6)   $��
176,52,0,0q�6D   $	��Top=�6X   $	��120��6p   5      5      