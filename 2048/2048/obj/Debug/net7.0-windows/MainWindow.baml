   M S B A M L   `   `   `  ����?  ;2048, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_2048_2048  5   	       _2048.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:_2048     5   	   -   5          � Title$
  2048��5   	   $	��550��6   $	��500��6#   $	��300��6/   $	��250��6?    � 	Resources 5	         plt �� 
TargetType �� CornerRadius��%�   &	        �� 5
   
   " ��6&   .R�5      �� $��1q�6   $ 10��6)   $��5q�6;   
�������._�5      � .+�5      �� 6)   5      5      5      5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   .+�5   
   o� .@�5      m� -   5        $��Restart��5      $��14(�68   
�������
����  �6q   5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $	��29* �6#   62   �� 5      $	��96* �6#   �� 5      $
��125* �6#   63   .+�5!      �� $��	25,20,5,5q�6   
�������$��1q�6;   $ 10��6O   $��2��6a   ._�5"      �  5#      �� 5$      6*   �� 5%      6*   .+�5'      ��  �� TextAlignment$ Center=�6    $��5q�67   
�������$��18(�6Y   Score6n   �� 5(      -   5        $��Score��5(       $��1��6.   $ Center=�6;   $��2q�6R   
�������$��18(�6p   $��0��6~   6�   5)      5*      �� 5+      $��2��6   $��	5,20,25,5q�6%   
�������$��1q�6J   $ 10��6^   ._�5,      �  5-      �� 5.      6*   �� 5/      6*   .+�51      �� $ Center=�6    $��5q�67   
�������$��18(�6Y   
High Score6s   �� 52      -   5        $��	highscore��52       $��1��61   $ Center=�6>   $��2q�6U   
�������$��18(�6s   06�   53      54      55      �� 56   
   $��2��6   $��
25,5,25,10q�6   
�������$��1q�6D   $ 10��6X   ._�57      � $��1��6   $��5q�6    .+�58      �  59      �� 5:      6-   �� 5;      6-   �� 5<      6-   �� 5=      6-    5?      �� 5@      6*   �� 5A      6*   �� 5B      6*   �� 5C      6*   .+�5E      �� -   5        $	��b00��5E      $��0��6'   $��0��67   #��[  6D   6f   �� 5F      -   5        $	��b10��5F      $��1��6'   $��0��67   #��[  6D   6f   �� 5G      -   5        $	��b20��5G      $��2��6'   $��0��67   #��[  6D   6f   �� 5H      -   5        $	��b30��5H      $��3��6'   $��0��67   #��[  6D   6f   �� 5I      -	   5        $	��b01��5I      $��0��6'   $��1��67   #��[  6D   6f   �� 5J      -
   5        $	��b11��5J      $��1��6'   $��1��67   #��[  6D   6f   �� 5K      -   5        $	��b21��5K      $��2��6'   $��1��67   #��[  6D   6f   �� 5L      -   5        $	��b31��5L      $��3��6'   $��1��67   #��[  6D   6f   �� 5M      -   5        $	��b02��5M      $��0��6'   $��2��67   #��[  6D   6f   �� 5N      -   5        $	��b12��5N      $��1��6'   $��2��67   #��[  6D   6f   �� 5O      -   5        $	��b22��5O      $��2��6'   $��2��67   #��[  6D   6f   �� 5P      -   5        $	��b32��5P      $��3��6'   $��2��67   #��[  6D   6f   �� 5Q      -   5        $	��b03��5Q      $��0��6'   $��3��67   #��[  6D   6f   �� 5R      -   5        $	��b13��5R      $��1��6'   $��3��67   #��[  6D   6f   �� 5S      -   5        $	��b23��5S      $��2��6'   $��3��67   #��[  6D   6f   �� 5T      -   5        $	��b33��5T      $��3��6'   $��3��67   #��[  6D   6f   5U      5V      5W      5Z      5[      