   M S B A M L   `   `   `  ����C  ?ResumeDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ResumeDBResumeDB  5   	   9!clr-namespace:ResumeDB.ViewModelsResumeDB.ViewModels  5   	       ResumeDB.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ResumeDB     5   	   4local1!clr-namespace:ResumeDB.ViewModels     5   	     � Title$  
MainWindow��5	   	   $	��500��6   $	��700��6)   $	��300��65   $	��700��6E   $	��700��6T   $	��900��6d    � 	Resources 5
      '  !ResumeDB.ViewModels.MainViewModel   MVM �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%6  &	        '��      '�� �     '�� w      5   
   6:   �� 5   
   " ��6   .�5      ��  � ��$ Courier New)�6+   �� 5       � ��$ 18(�6)   �� 5       � ��
 ���� 6+   �� 5       � �� �#C0C0C06+   5      �� 5   
   " ��6   .�5      ��  � ��$ Courier New)�6+   �� 5       � ��$ 18(�6)   �� 5       � �� �#C0C0C06+   5      �� 5   
   " ��6   .�5      ��  � ��$ Courier New)�6+   �� 5       � ��$ 18(�6)   �� 5       � ��
 �   �6+   �� 5       � �� �#C0C0C06+    5      P� 5       � {�$ False��6/   . �5      ��  � �� �#00008063   5      P� 5        �@J�IsMouseOver$
 True��61   . �5!      ��  � �� �#00008063   5"      5$      5%      .��5&      � ���#4B0082 � DataContext# [  6    	 � RowDefinitions	 5'   
   �� 5(      $
��Auto �6   �� 5)      $��* �6   �� 5*      $
��Auto �6   .+�5,   
   �� $2��,Заполните анкету резюме��6   $
��10 5q�63   $��18(�6A   $��Center=�6O   $��Center=�6l   �� 5-   
   $��1��6   .��5.      �� $��20q�6   .+�5/      �� 
 �� Orientation$
 
Horizontal=�6   $��0 0 0 10q�62   $��Stretch=�6D   .+�50      �� $��Имя: ��6   $��Center=�6*   �� 51      $��10 0 0 0q�6   ��61   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�52      �� 53      $
 
Horizontal=�6   $��0 0 0 10q�62   .+�54      �� $��Фамилия: ��6   $��Center=�6-   �� 55      $��10 0 0 0q�6   ��61   �� *	Surname+$ PropertyChanged=�56      �� 57      $
 
Horizontal=�6   $��0 0 0 10q�62   .+�58      �� $��Email: ��6   $��Center=�6,   �� 59      $��10 0 0 0q�6   ��62   �� *Email+$ PropertyChanged=�5:      �� 5;      $
 
Horizontal=�6   $��0 0 0 10q�62   .+�5<      �� $��Должность: ��6   $��Center=�60   �� 5=      $��10 0 0 0q�6   ��62   �� *Post+$ PropertyChanged=�5>      �� 5?      $
 
Horizontal=�6   $��0 0 0 10q�62   .+�5@      �� $��Опыт работы: ��6   $��Center=�62   �� 5A      $��10 0 0 0q�6   ��61   �� *JE+$ PropertyChanged=�5B      �� 5C      $
 
Horizontal=�6   $��0 0 0 10q�62   .+�5D      �� $��Center=�6    d� 	IsChecked 6:   �� *CPP+$ PropertyChanged=��� 5E      $��5q�6   $	��C++��6'   $��Center=�63   5F      �� 5G      $
 
Horizontal=�6   $��0 0 0 10q�62   .+�5H      �� $��Center=�6     6<   �� *CSharp+$ PropertyChanged=��� 5I      $��5q�6   $��C#��6'   $��Center=�62   5J      �� 5K      $
 
Horizontal=�6   $��0 0 0 10q�62   .+�5L      �� $��Center=�6    6;   �� *Unity+$ PropertyChanged=��� 5M      $��5q�6   $��Unity��6(   $��Center=�66   5N      �� 5O      $
 
Horizontal=�6   $��0 0 0 10q�62   .+�5P      �� $��Center=�6    6;   �� *WPF+$ PropertyChanged=��� 5Q      $��5q�6   $	��WPF��6(   $��Center=�64   5R      �� 5S      $
 
Horizontal=�6   $��0 0 0 10q�62   .+�5T      �� $��Center=�6    6;   �� *SQL+$ PropertyChanged=��� 5U      $��5q�6   $	��SQL��6(   $��Center=�64   5V      5W      5X      �� 5Y   
   $��2��6   $
 
Horizontal=�6"   .+�5Z      �� $��Отправить��6   $	��100��6H   $��30��6T   $��10q�6`   $��Center=�6l   $��Center=�6�   ��6)   �� *	AddResume+6�   �� 5[      $��Очистить��6   $	��100��6B   $��30��6N   $��10q�6Z   $��Center=�6f   $��Center=�6�   ��6(   �� *Clear+6�   �� 5\      $��10q�6N   $	��200��6Z   $��30��6i   $��Center=�6u    �� SelectedIndex 6   �� *SelectedIndex+ �� Mode$ TwoWay=���6�   �� *	Resumes+��5]      �� 5^      .R�5_      �  � ColumnDefinitions 5`      �� 5a   "   65   �� 5b   "   65   .+�5d      �� $��18(�6(   $��Courier New)�66   $��Center=�6O   
����  ���6j   �� *Name+6�   �� 5e      $��18(�6)   $��Courier New)�67   $
��10,0q�6P   $��Center=�6^   $��1��6y   
����  ���6�   �� *	Surname+6�   5f      5g      5i      �� 5j      $)��#Просмотреть резюме��66   $��10q�6T   $��3q�6`   ��6   �� *ReviewResume+6n   5k      5l      5m      