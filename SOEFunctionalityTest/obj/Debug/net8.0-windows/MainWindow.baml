   M S B A M L   `   `   `  ����O  KSOEFunctionalityTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:SOEFunctionalityTest.ViewModelsSOEFunctionalityTest.ViewModels  5   	   Q-clr-namespace:SOEFunctionalityTest.ViewModelsSOEFunctionalityTest.ViewModels  5   	   G(clr-namespace:SOEFunctionalityTest.ViewsSOEFunctionalityTest.Views  5   	   %    SOEFunctionalityTest.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:SOEFunctionalityTest.ViewModels     5   	   D
viewmodels-clr-namespace:SOEFunctionalityTest.ViewModels     5   	   :views(clr-namespace:SOEFunctionalityTest.Views     5   	     � Title$  
MainWindow��5
   	   $	��526��6   $	��375��6)    � 	Resources 5      ,   &SOEFunctionalityTest.Views.MapLineView   MapLineViewKey-   'SOEFunctionalityTest.Views.MapPointView  MapPointViewKey,   &SOEFunctionalityTest.Views.ResultsView  ResultsViewKey �� DataType7   1SOEFunctionalityTest.ViewModels.MapPointViewModel6   0SOEFunctionalityTest.ViewModels.MapLineViewModel6   0SOEFunctionalityTest.ViewModels.ResultsViewModel��%�  &	        &	      &	 &     (�� 9     5   1   *, +)7  (�� �     5   0   *, +)7   (�� �     5   0   *, +)7    5   
   6     5   
   6     5   
   6   �� 5   
   MapPointTemplate��"  61   .R�5      �� 8��  6   5      �� 5   
   MapLineTemplate��"  60   .R�5      �� 8��  6   5      �� 5   
   ResultsTemplate��"  60   .R�5      �� 8��  6   5      5      .��5      �  5   
    �� Source�� 5      $ Dictionary1.xaml?�6!   %     � ColumnDefinitions 5    
   �� 5!      �� 5"      �� 5#       � RowDefinitions 5%   
   �� 5&      $
��70px �6   �� 5'      .+�5)   
   ]� $��0��6   $��0��6!   $��3��61   
�������.+�5*      � -   5         �Name$ controlsGrid��5*       5+      �� 5,      �� 5-      �� 5.      .+�50      �� -   5         ��Name$ MapPointButton��50      $��15(�61    � ToolTip$ Open the Map A Point tab��6^   $��0��6�   ���#cfd8ff.��51      �� 	 �� Orientation$	 
Horizontal=�6!   .+�52      �� $��30��6    $��30��6,     
pointImage#��[ 67   �� 53      $��Map a Point��6    54      55      �� 56      -   5        $ MapLineButton��56      $��15(�60   $ Open the Map A Line tab��6\   $��1��6~   
�������.��57      �� $	 
Horizontal=�6!   .+�58      �� $��30��6    $��30��6,     	lineImage#��[ 67   �� 59      $��
Map a Line��6    $��Center=�65   5:      5;      �� 5<      -   5        $ ResultsButton��5<      $��15(�60   $ Open the Results tab��6\   $��2��6{   
�������.��5=      �� $	 
Horizontal=�6!   .+�5>      ��   
tableImage#��[ 6    $��30��6E   $��30��6P   �� 5?      $��View Results��6    $��Center=�67   5@      5A      5B      5C      �� 5D   
   $��1��6   $��0��6&   $��3��66   
���������6a   �� 5F      5G      5H      