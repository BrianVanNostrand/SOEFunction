   M S B A M L   `   `   `  ����  SOEFunctionalityTest,    &SOEFunctionalityTest.Views.ResultsView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3b+http://schemas.microsoft.com/xaml/behaviors  5      rd../Dictionary1.xaml  5	      $	��375��5   #   $	��364��60     � 	Resources  5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ ../Dictionary1.xaml?�6%   %    5      .��5   
   � 
�������   resultsSharedVM � DataContext# [  6"    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��40px �6   .+�5   
   � $��0��6   $��3��6   $��0��63    J� InputBindings 5      d� 5       d� MouseAction$ 	LeftClicke�6    �� Command 67   �� *selectDataGrid+ 5!      �� 5"      $
��30px �6    �� 5#       5%      �� 5&      �� 5'      �� 5(      .+�5*      � $��0��6   $��0��6     5+      �� 5,      �� 5-      .+�5/      ��   mapPointSharedVM# [ 6   $��0��6H   $��0��6U   .��6e   	Points:6n   �� 50      # [ 6   $��0��6H   $��1��6U   ��6e   �� *SoePointResponses.Count+6�   51      &   System.Windows.Controls.DataGrid  52      -   5        	  Name$	 
PointsGrid��52      # [ 6   
   CanUserAddRows$
 False��6G   $��3��6^   $��1��6r   $��Stretch=�6�      AutoGenerateColumns$ False��6�   $��Stretch=�6�   ��6�   ��  �� Path$ SoePointResponses�   RowStyle 53      �� 54       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6    �� Triggers 55      P� 56       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �57   "   ��  �� Property � �� �� Value
 ��ح�6?   58      5:         Columns 5<      4  .System.Windows.Controls.DataGridTemplateColumn  5=      ,  &System.Windows.Controls.DataGridColumn   Header$ Delete��6-      CellTemplate 5>      �� 5?      .R�5@   "   ��   whiteButton#��[ 6)   5A      5C      0  *System.Windows.Controls.DataGridTextColumn  5D      $ Route��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *Route+  5E      $	 ARM��6)    66   �� *Arm+  5F      $
 SRMP��6)    67   �� *Srmp+  5G      $ Decrease��6)    6;   �� *
Decrease+  5H      $
 Back��6)    67   �� *Back+  5I      $ X��6)    64   �� *RouteGeometry.x+  5J      $ Y��6)    64   �� *RouteGeometry.y+*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5L      +  %Microsoft.Xaml.Behaviors.EventTrigger  5M         	EventName$ SelectionChanged��6%   *	  $Microsoft.Xaml.Behaviors.TriggerBase 	  Actions. 5N      2
  ,Microsoft.Xaml.Behaviors.InvokeCommandAction
   
  CommandParameter 60   ��  �� ElementName$ 
PointsGrid��$ SelectedItems� 
  Command 6x   �� *SelectedItemsCommand+5O      5Q      5R      � 5S   
     mapLineSharedVM# [ 6   $��0��6>   $��3��6N   $��1��6b    5T      �� 5U      $
��30px �6    �� 5V       5X      �� 5Y      �� 5Z      �� 5[      .+�5]      � $��0��6   $��0��6     5^      �� 5_      �� 5`      .+�5b      �� $��0��6   $��0��6%   .��65   Lines:6=   �� 5c      $��0��6   $��1��6%   ��65   �� *SoeLineResponses.Count+6b   5d        5e      -   5        $	 	LinesGrid��5e   O   $
 False��6   $��3��6.   $��1��6B   $��Stretch=�6b   $ False��6�   $��Stretch=�6�   ��6�   �� $ SoeLineResponses� 5f      �� 5g      "  6    5h      P� 5i       �@J�IsMouseOver$
 True��5j      . �5k   "   ��  � ��
 ��ح�5l       5m      5o       5q        5s      $ Delete��6-    5t      �� 5u      5w      5y        5z      $ Route��6)    68   �� *	[0].Route+  5{      $	 ARM��6)    66   �� *	[0].Arm+  5|      $ EndARM��6)    69   �� *	[1].Arm+  5}      $
 SRMP��6)    67   �� *
[0].Srmp+  5~      $ EndSRMP��6)    6:   �� *
[1].Srmp+  5      $ Decrease��6)    6;   �� *[0].Decrease+  5�      $
 Back��6)    67   �� *
[0].Back+  5�      $ EndBack��6)    6:   �� *
[1].Back+  5�      $ X��6)    64   �� *[0].RouteGeometry.x+  5�      $ Y��6)    64   �� *[0].RouteGeometry.y+  5�      $
 EndX��6)    67   �� *[1].RouteGeometry.x+  5�      $
 EndY��6)    67   �� *[1].RouteGeometry.y+5�      5�      � 5�   
   $��0��6   $��2��6   $��3��6,    5�      �� 5�       5�      �� 5�      �� 5�      �� 5�      .+�5�      �� $��2��6   $��0��6"   #��[ 62   .��6W   Export Data5�      �� 5�      $��2��6   $��1��6"   # [ 62   #��[ 6�   ��6b   �� *DeleteItemsCommand+.��6�   Delete Record5�      �� 5�      $��2��6   $��2��6"   # [ 62   #��[ 6�   ��6b   �� *ClearItemsCommand+.��6�   Clear5�      5�      5�      5�      