   M S B A M L   `   `   `  ����H  DCoffeeShop.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CoffeeShop.UI.ViewsCoffeeShop.UI.Views  5   	   $    CoffeeShop.UI.Views.ShowSnacks   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CoffeeShop.UI.Views     5   	     � Title$  
ShowSnacks��5   	   $	��450��6   $	��800��6)   .��5	      �  � DataContext 6	   ��  �� ElementName$ 
snacksList�� �� Path$ SelectedItem� � RowDefinitions 5
      �� 5      $��* �6    � ColumnDefinitions 5      �� 5      $��* �6   �� 5      $��3* �6   .+�5      �� -   5        $��
snacksList��5      $��1��6    ��5      �� 5   
   .R�5      �� ��6   �� *Name+5      5      � 5      $��1��6   $��
0,0,-0.5,0q�6    5      �� 5   
   $��* �6    5      �� 5   
   $��1* �6   �� 5    
   $��3* �6   .+�5#      �� -   5        $��	IdTextBox��5#      $��1��6!   $��23��61   $��8,8,8,0q�6=    �� TextWrapping$
 Wrap=�6N   $	��Top=�6�   {�.  $��2��6�   ��6b   �� *Id+ �� Mode$ TwoWay=�6�   �� 5%      -   5        $��NameTextBox��5%      $��1��6#   $��23��63   $��8,39,8,0q�6?   $
 Wrap=�6Q   $	��Top=�6�   {�.  $��2��6�   ��6e   �� *Name+$ TwoWay=�6�   �� 5'      -   5        $��DescriptionTextBox��5'      $��1��6.   $��Stretch=�6>   $��54��6\   $��8,70,8,0q�6h   $	��Top=�6z   $
��Auto��6�   {�.  $��2��6�   . �5(   
   /� .T�5)      J� .*�6   .*�5*      �� �6   �� *Description+$ TwoWay=�5+      5,      5-   	   �� 5/      -   5        $��PriceTextBox��5/      $��1��6$   $��23��64   $��	8,132,8,0q�6@   $
 Wrap=�6S   $	��Top=�6�   {�.  ��6g   �� *Price+$ TwoWay=� �� StringFormat$ {0:C}��6�   �� 51      $��8,8,8,0q�6   $
��Wrap=�6#   $��ID��67   $	��Top=�6A   $��23��6Y   �� 52      $��8,70,8,0q�6   $
��Wrap=�6$   $��Description��68   $	��Top=�6K   $��23��6c   �� 53      $��8,39,8,0q�6   $
��Wrap=�6$   $
��Name��68   $	��Top=�6D   $��23��6\   �� 54      $��	8,132,8,0q�6   $
��Wrap=�6%   $��Price��69   $	��Top=�6F   $��23��6^   �� 55      -   5        $��Image��55      $��1��68   $��	8,223,8,8q�6H   $y�Hidden=�6[   ��6   �� *	ImagePath+6[   �� 56      -   5        $��WeightTextBox��56      $��1��6%   $��23��65   $��	8,163,8,0q�6A   $
 Wrap=�6T   $	��Top=�6�   {�.  ��6h   �� *Weight+$ TwoWay=�$ {0} g��6�   �� 57      $��	8,163,8,0q�6   $
��Wrap=�6%   $��Weight��69   $	��Top=�6G   $��23��6_   58      59      5:      