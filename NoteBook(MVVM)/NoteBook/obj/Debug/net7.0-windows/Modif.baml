   M S B A M L   `   `   `  ����C  ?NoteBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:NoteBookNoteBook  5   	       NoteBook.Modif   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:NoteBook     5   	     � Title$  Modif��5   	   $	��100��6   $	��500��6$    � 	Resources 5	         NoteBook.Persontemp   temp   name   adress   phone  grad �� Property �� Value �� 
StartPoint �� EndPoint	 � Offset
 � Color �� 
TargetType  btn �� Triggers P� Property P� Value��%�  &	        &	 2     &	       5
   
   $  ��6(   $  ��60   $  ��6:   �� 5   
   .�5      ��  � �� 5      �� 5      $ 0,0.5&�6*   $ 1,0.5&�6=   .��5      � $	 0Q�6'   $
 Black��62   � 5      $	 1Q�6'   $

 Gold��62   5      5      5      �� 5   
   " ��6   �5      �� 5       � �� 5      �� 5      $ 0,0.5&�6.   $ 1,0.5&�6A   .��5      � $	 0Q�6+   $
 Black��66   � 5      $	 1Q�6+   $

 Gold��66   5      5      �� 5       � ��
 �����6?    5!      P� 5"       �@J�IsMouseOver$
 True��68   . �5#      ��  � ��
 �   �6;   5$      5'      5(      .��5)      �  � DataContext# [  6   ��5*   
   �� 5+      $ 0,0.5&�6"   $ 1,0.5&�65   .��5,      � $	 0Q�6   $
 Black��6*   � 5-      $	 1Q�6   $

 Gold��6*   5.       � ColumnDefinitions 50   
   �� 51      6"   �� 52      6"   �� 53      6"    � RowDefinitions 55   
   �� 56      $
��Auto �6   6,   �� 57      $��* �6   6)   �� 58      $
��Auto �6   6,   .+�5:   
   �� $��14(�6   
�������$��Center=�66   Fio6X   �� 5;   
   $��1��6   
�������$��14(�67   $��Center=�6E   Adress6j   �� 5<   
   $��2��6   
�������$��14(�67   $��Center=�6E   Phone6i   �� 5=   
   -   5        $��fiomod��5=   8   
���   �
�������$��1��6F   $��18(�6S   6c   �� 5>   
   -   5        $��	adressmod��5>   8   
���   �
�������$��1��6I   $��1��6V   $��18(�6f   6v   �� 5?   
   -   5        $��phonemod��5?   8   
���   �
�������$��1��6H   $��12��6U   $��18(�6f   6v   �� 5@   
   -   5        #��[ 5@      $��Ok��6/   $��2��6<   $��3��6I   6t   5A      5B      