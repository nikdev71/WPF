   M S B A M L   `   `   `  ����C  ?NoteBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:NoteBookNoteBook  5   	       NoteBook.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:NoteBook     5   	     � Title$  NoteBook��5   	   $	��450��6   $	��800��6'   $	��300��63   $	��400��6C    � 	Resources 5	         NoteBook.Person   	lstperson   Name   Adress   Phone  menuitem �� 
TargetType �� Property �� Value��%�   &	        &	 >       5
   
   $
 None��6)   $
 None��65   $
 None��6C   �� 5   
   " m�6!   .�5      ��  � ��$ 14(�6)   66   �� 5       � ��
 ��  �6:   5      5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5        	   Command$"	 local:DataCommands.Addperson��5      5   #     5   
   -   5        $"	 local:DataCommands.Delperson��5      5        5   
   -   5        $$	 local:DataCommands.Modifperson��5      5      .��5      � 
 � RowDefinitions
 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   .+�5   
   o� .@�5      m� $��Файл��6   #��[ 6%   .@�5       m� $��Сохранить��6    m� Command$
 Save��6.   6@   m� 5!      $��Загрузить��6   $
 Open��6.   6@   5"      m� 5#      $��Правка��6   #��[ 6'   .@�5$      m� $��Добавить��6   $" local:DataCommands.Addperson��6-   6W   m� 5%      $��Удалить��6   $" local:DataCommands.Delperson��6,   6W   m� 5&      $��Изменить��6   $$ local:DataCommands.Modifperson��6-   6X   5'      5(      � 5)   
   $��1��6    � DataContext# [  6    � ColumnDefinitions 5*      �� 5+      $
��Auto �6#   62   �� 5,      $��* �6#   6/   �� 5-      $
��Auto �6#   62   �� 5.      $��* �6#   6/   �� 5/      $
��Auto �6#   62   �� 50      $��* �6#   6/   .+�52      �� $��14(�6   $��5,0,0,0q�6&   ФИО6>   �� 53      $��2��6   $��14(�6(   Адресс6?   �� 54      $��4��6   $��14(�6(   Телефон6?   �� 55      -   5        $	��fio��55      $��1��6!   $��20��61   $
��15,0q�6@   ��6N   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 56      -   5        $��adress��56      $��3��6$   $��20��64   $
��15,0q�6C   ��6Q   �� *Adress+$ PropertyChanged=�6�   �� 57      -   5        $��phone��57      $��5��6#   $��20��63   $
��15,0q�6B   ��6P   �� *Phone+$ PropertyChanged=�6�   58      �� 59   
   -   5         ��Name$ listbox��59      $��2��6   # [  60   ��6Y   �� *people+ �� SelectedIndex 5:      �� *Index_selected_listbox+ �� Mode$ TwoWay=���5;      �� 5<      " ��6   .�5=      ��  � ��$ 18(�61   6>    �� Triggers 5>      P� 5?       P� Property �@J�IsMouseOver P� Value$
 True��69   . �5@      ��  � ��
 �� ��6P   5A      P� 5B       �@��
IsSelected$
 True��68   . �5C      ��  � ��
 �  ��6I   5D      5F      5H      5I      5J      