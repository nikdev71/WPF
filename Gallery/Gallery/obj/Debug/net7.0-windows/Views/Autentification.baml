   M S B A M L   `   `   `  ����B  >Gallery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:GalleryGallery  5   	   5clr-namespace:Gallery.ViewModelGallery.ViewModel  5   	       Gallery.Autentification   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Gallery     5   	   4localRegclr-namespace:Gallery.ViewModel     5   	     � Title$  Autentification��5	   	   $	��300��6!   $	��400��6.    � WindowStartupLocation$ CenterScreen=�6:   $	��200��6_   $	��300��6o    � 	Resources 5
      &    Gallery.ViewModel.LoginViewModel   LVM �� 
TargetType �� Property �� Value 
 txtbox �� 
TargetType �� CornerRadius �� RelativeSource	 �� Path
 �� Triggers P� Property P� Value��%}  &	        '�      &	 �     '�� �      5   
   6"   �� 5   
   " �6   .�5      ��  � ��$ 16(�6)   66   �� 5       � ��$ SemiBold"�6+   6>   5      �� 5   
   " ��6)   .R�5      �� $��1q�6   $��5q�6)   ���#b3a272���#efefdf$ 10��6_   ._�5      � .+�5      �� 
������ $��0q�5      $��14(�6.   
���   �$��5q�6O   ��5      ��  �� *TemplatedParent+$
	 Text�5   O   5      5      5      �� 5   
   " ��6   .�5      ��  � �� �#b3a2726+   �� 5       � ��
 �����6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ 16(�6)   �� 5       � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � �� 5       �� 5!      " ��6&   .R�5"      �� #��z��6!   $ 20��6K   ._�5#      �� $��Center=�6/   $��Center=�6L   5$      5%      5'      
 5(      P� 5)       �@J�IsMouseOver$
 True��61   . �5*      ��  � �� �#93844d63   5+      P� 5,       � ��$
 True��6/   . �5-      ��  � �� �#c3be9c6E   5.      50      51      .��52      �  � DataContext# [  6   ��53   
   �� 54       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 0,1&�63   .��55      �  � Offset$ 0Q�6    � Color$ #c3be9c��6*   � 56      $ 1Q�6   $ #efefdf��6*   58      .+�5:   
   �� .+�5;      �� $��20q�6   $��Center=�6!   .��6>   Gallery Entrance6P   �� 5<      $
��10 0q�6   .��6"   Login6)   �� 5=      $
��10 0q�6   #��[ 6$   ��6G   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5>      $
��10 0q�6   .��6"   
Password6,   �� 5?      $
��10 0q�6   #��[ 6$   ��6G   �� *
Password+$ PropertyChanged=�6�   � 5@      $
��0 15q�6    � ColumnDefinitions 5A      �� 5B      6)   �� 5C      6)   .+�5E      �� -   5        $	��150��5E      $��40��6%   ��6F   �� *LoginCommand+.��6g   Ok6k   �� 5F      -   5        $	��150��5F      $��40��6%   $��1��61   .��6X   Cancel6`   5G      5H      5I      5J      