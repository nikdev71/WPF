   M S B A M L   `   `   `  ����B  >Gallery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:GalleryGallery  5   	   5clr-namespace:Gallery.ViewModelGallery.ViewModel  5   	       Gallery.Authorisation   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Gallery     5   	   4localRegclr-namespace:Gallery.ViewModel     5   	     � Title$  Authorisation��5	   	   $	��430��6   $	��400��6,    � WindowStartupLocation$ CenterScreen=�68   $	��300��6]   $	��300��6m    � 	Resources 5
      -  'Gallery.ViewModel.RegistrationViewModel   RVM �� 
TargetType �� Property �� Value 
 txtbox �� 
TargetType �� CornerRadius �� RelativeSource	 �� Path
 �� Triggers P� Property P� Value��%�  &	        '�      &	 �     '�� �      5   
   6)   �� 5   
   " �6   .�5      ��  � ��$ 16(�6)   66   �� 5       � ��$ SemiBold"�6+   6>   5      �� 5   
   " ��6)   .R�5      �� $��1q�6   $��5q�6)   ���#b3a272���#efefdf$ 10��6_   ._�5      � .+�5      �� 
������ $��0q�5      $��14(�62   
���   �$��5q�6S   ��5      ��  �� *TemplatedParent+$
	 Text�5   S   5      5      5      �� 5   
   " ��6   .�5      ��  � �� �#b3a2726+   �� 5       � ��
 �����6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ 16(�6)   �� 5       � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � �� 5       �� 5!      " ��6&   .R�5"      �� #��z��6!   $ 20��6K   ._�5#      �� $��Center=�6/   $��Center=�6L   5$      5%      5'      
 5(      P� 5)       �@J�IsMouseOver$
 True��61   . �5*      ��  � �� �#93844d63   5+      P� 5,       � ��$
 True��6/   . �5-      ��  � �� �#c3be9c6E   5.      P� 5/       � {�$ False��6/   . �50      ��  � �� �#c3be9c6E   51      53      54      .��55      �  � DataContext# [  6   ��56   
   �� 57       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 0,1&�63   .��58      �  � Offset$ 0Q�6    � Color$ #c3be9c��6*   � 59      $ 1Q�6   $ #efefdf��6*   5;      .+�5=   
   �� .+�5>      �� $��20q�6   $��Center=�6!   .��6>   Gallery Registration6T   �� 5?      $
��10 0q�6   .��6"   Login6)   �� 5@      $
��10 0q�6   #��[ 6$   ��6G   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5A      $
��10 0q�6   .��6"   
Password6,   �� 5B      $
��10 0q�6   #��[ 6$   ��6G   �� *
Password+$ PropertyChanged=�6�   �� 5C      $
��10 0q�6   .��6"   Repeat Password63   �� 5D      $
��10 0q�6   #��[ 6$   ��6G   �� *PasswordAgain+$ PropertyChanged=�6�   �� 5E      $
��10 0q�6   .��6"   
Username6,   �� 5F      $
��10 0q�6   #��[ 6$   ��6G   �� *Author+$ PropertyChanged=�6�   � 5H      $
��0 10q�6    � ColumnDefinitions 5I      �� 5J      6)   �� 5K      6)   .+�5M      �� $	��150��6   $��40��6%   ��61   �� *RegisterCommand+$ PropertyChanged=�.��6y   	Sign Up6�   �� 5N      -   5        $	��150��5N      $��40��6%   $��1��61   .��6V   Exit6\   5O      5P      5Q      5R      