   M S B A M L   `   `   `  ����F  Bassignment4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:assignment4assignment4  5   	       assignment4.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:assignment4     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�65   .��5	      � .+�5
   
   ��  �� Orientation$ Vertical=�6   .+�5      �  � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$    � ColumnDefinitions 5      �� 5      $
��Auto �6'   �� 5      $
��Auto �6'   �� 5      $
��Auto �6'   .+�5      �� $&�� Building type(Barn/House/Garage)��6   $��0��6C   $��0��6P   $
��Left=�6a   $	��Top=�6|   �� 5      -   5         ��Name$ TxtType��5      $�� ��6+    �� TextWrapping$
 Wrap=�63   $
��Left=�6G   $��Center=�6b   $	��150��6}   $��0��6�   $��1��6�   6�   �� 5      $"��Size of building[1000-50000]��6   $��1��6?   $��0��6L   $
��Left=�6]   $	��Top=�6x   �� 5      -   5        $ TxtSize��5      $�� ��6+   $
 Wrap=�63   $
��Left=�6G   $��Center=�6b   $	��150��6}   $��1��6�   $��1��6�   6�   �� 5      $$��Number of bulbs required[1-20]��6   $��2��6A   $��0��6N   $
��Left=�6_   $	��Top=�6z   �� 5      -   5        $ TxtBulbs��5      $�� ��6,   $
 Wrap=�64   $
��Left=�6H   $��Center=�6c   $	��150��6~   $��2��6�   $��1��6�   6�   �� 5       $&�� Number of outlets required[1-50]��6   $��3��6C   $��0��6P   $
��Left=�6a   $	��Top=�6|   �� 5!      -   5        $ 
TxtOutlets��5!      $�� ��6.   $
 Wrap=�66   $
��Left=�6J   $��Center=�6e   $	��150��6�   $��3��6�   $��1��6�   6�   �� 5"      $'��!Credit card[16 digits, no spaces]��6   $��4��6D   $��0��6Q   $
��Left=�6b   $	��Top=�6}   �� 5#      -   5        $ TxtCC��5#      $�� ��6)   $
 Wrap=�61   $
��Left=�6E   $��Center=�6`   $	��150��6{   $��4��6�   $��1��6�   6�   �� 5$      -   5         ��Name$ BtnAdd��5$      $	��Add��6)   $��0��67   $��5��6G   $	��100��6T   6`   �� 5%      -   5        $ 
BtnDisplay��5%      $��Display��6-   $��1��6?   $��5��6O   $	��100��6\   6h   �� 5&      -   5        $ BtnExit��5&      $
��Exit��6*   $��2��69   $��1��6I   $��3��6V   $��	200,0,0,0q�6g   $	��100��6z   6�   �� 5'      $-��'Information is sorted by building size:��6   $��5��6J   $��2��6W   5(      �� 5)      $	��750��6   $	��250��6!   $��0,10,0,0q�6.   $��1q�6@   
���   �._�5*      �� .��5+      �� -	   5         ��Name$ TB��5+       $
��Wrap=�6,   5,      5-      5.      5/      50      