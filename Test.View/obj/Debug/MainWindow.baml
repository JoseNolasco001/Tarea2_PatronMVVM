   M S B A M L   `   `   `  ����I  ETest.ViewModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG4clr-namespace:Test.ViewModel;assembly=Test.ViewModelTest.ViewModel  5   	   D @Test.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Test.View	Test.View 5   	      Test.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Cvm4clr-namespace:Test.ViewModel;assembly=Test.ViewModel     5   	   )localclr-namespace:Test.View     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5
      "   Test.ViewModel.MainViewModel   MainViewModel��%   &	          5   
   63   5      .��5      �  J� RenderTransformOrigin$ 0.497,0.391&�6I    � DataContext 6   ��  �� Source# [   � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $	��100 �6   6-   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��8* �6   6*   �� 5      $��* �6   6)   .+�5   
   �� $��1��6   $��1��6!   $��
0,52,0,249q�6.   ��6B   �� *
DerechaUno+.��6b   >>6f   �� 5   
   $��1��6   $��1��6!   $��
0,99,0,204q�6.   ��6B   �� *DerechaTodo+.��6b   >6e   �� 5   
   $��Atras��6   $��1��6!   $��1��6.   $��0,205,0,100q�6>   ��6S   �� *IzquierdaUno+�� 5   
   $��
Atras Todo��6   $��1��6&   $��
0,253,0,50q�66   $��1��6J   ��6W   �� *IzquierdaTodo+&   System.Windows.Controls.DataGrid  5   
   $��1��6R   $��0��6_      AutoGenerateColumns .     CanUserAddRows .  	   
IsReadOnly	 . $��50q�6�   ��6   �� *Lista1+
 �� SelectedItem
 62   �� *ItemL1+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5!      $ Traceability��6%   $ * 6\    6;   �� *Traceability+6\   5#        5%   
   $��1��6R   $��2��6_    .   .  	 . $��50q�6�   ��6   �� *Lista2+
 62   �� *ItemL2+ 5&        5'      $ Id��6%   $	 100 6H    61   �� *Id+6H     5(      $ Traceability��6%   $ * 6\    6;   �� *Traceability+6\   5*      5+      5,      