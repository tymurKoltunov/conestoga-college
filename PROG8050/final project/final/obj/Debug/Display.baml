   M S B A M L   `   `   `  ����@  <final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:finalfinal  5   	       final.Display   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:final     5   	     � Title$  Display��5   	   $	��520��6   $	��850��6&    � 	Resources 5	         final.Converter   	Converter��%   &	          5
   
   6   5      .��5      ��  �� Orientation$ Vertical=�6   .+�5   
   �� $ 
Horizontal=�6   $��Center=�6.   $��0,5,0,0q�6K   .+�5      �� $��
Filter by:��6   $��14(�6)   $��Center=�67   �� 5      -   5         ��Name$ 	CmbFilter��5      $	��100��6*   �� 5      -   5         ��Name$ 	BtnFilter��5      $��Filter��6(   $��10,0,0,0q�69   $��50��6K   $��14(�6V   6d   �� 5      -   5        $ BtnAll��5      $��Display All��6%   $��10,0,0,0q�6;   6M   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ GridDisp��5         
IsReadOnly . $��10,10,10,10q�67   $	��370��6L   $	��800��6Y      AutoGenerateColumns .  ��5      ��  �� Path$ U�	   RowStyle	 5      �� 5      
 �� 
TargetType)  #System.Windows.Controls.DataGridRow"
  6   .�5      ��  �� Property � �� �� Value 63   �� $ .� �� 	Converter# [  5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Item Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *
ItemName+   ElementStyle 5      �� 5      .�5       ��  � ��$
 Wrap=�6G   �� 5!       �@��TextAlignment$ Center=�6H   5"      5$        5%      $ 	Item Type��6%   $ 65 6Q    68   �� *Type+6Q     5&      $ Specific Condition��6%    6A   �� *SpecificCondition+  5'      $ 
First Name��6%    69   �� *	FirstName+  5(      $ 	Last Name��6%    68   �� *
LastName+  5)      $ Credit Card��6%    6:   �� *
HiddenCC+  5*      $ Item Description��6%   $	 110 6c    6?   �� *ItemDescription+ 5+      �� 5,      .�5-      ��  � ��$
 Wrap=�6G   �� 5.       �@��TextAlignment$ Center=�6H   5/      51        52      $ Item Condtion��6%    6<   �� *	Condition+  53      $ 
Item Price��6%    69   �� *Price+55      �� 56   
   -   5        $ BtnDispClose��56      $��Close��6'   $	��150��67   $��50��6C   6O   57      58      