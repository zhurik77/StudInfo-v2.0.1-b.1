   M S B A M L   `   `   `  ����L  HStudInfo v2.0 b.3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:StudInfo_v2._0_b._3StudInfo_v2._0_b._3  5   	   &     StudInfo_v2._0_b._3.Theme_Editor   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:StudInfo_v2._0_b._3     5   	     � Title$  Theme_Editor��5   	   $	��400��6   $	��800��6+   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dataTheme��5
      $
��Left=�6&   $	��349��6A   $��	10,10,0,0q�6N   $	��Top=�6a   $	��391��6y   6�   �� 5   
   $��	Тема:��6   $
��Left=�6    $��
444,10,0,0q�6;   $	��Top=�6O   $
��Bold"�6g   $��14(�6y   �� 5   
   -   5         ��Name$ Theme_Add_Box��5      $
��Left=�6)   $��23��6D   $��
498,16,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��285��6�   �� 5   
   $��Задание:��6   $
��Left=�6#   $��
420,50,0,0q�6>   $	��Top=�6R   $��14(�6j   $
��Bold"�6x   �� 5   
   -   5        $ Zadanie_Add_Box��5      $
��Left=�6+   $��24��6F   $��
498,55,0,0q�6R   $
 Wrap=�6f   $	��Top=�6z   $	��285��6�    �� 	UndoLimit$
 1500��6�   �� 5   
   $��	Дата:��6   $
��Left=�6    $��
446,93,0,0q�6;   $	��Top=�6O   $
��Bold"�6g   $��14(�6y   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ Data_Picker��5      $
��Left=�6*   $��
498,97,0,0q�6E   $	��Top=�6Y   $	��284��6q   �� 5   
   -   5         ��Name$ 	Add_Theme��5      $%��Добавить занятие��6$   $
��Left=�6?   $��411,228,0,0q�6Z   $	��Top=�6o   $	��370��6�   $��25��6�   6�   �� 5   
   -   5        $ Save_Change_Theme��5      $+��%Сохранить изменения��6,   $
��Left=�6J   $��411,258,0,0q�6e   $	��Top=�6z   $	��180��6�   $��50��6�   6�   �� 5   
   -   5        $ Delete_Theme��5      $#��Удалить занятие��6'   $
��Left=�6A   $��601,258,0,0q�6\   $	��Top=�6q   $	��180��6�   $��50��6�   6�   �� 5   
   -   5        $ Cancel��5      $$��Вернуться в меню��6!   $
��Left=�6<   $��25��6W   $��411,315,0,0q�6c   $	��Top=�6x   $	��370��6�   6�   5      5      