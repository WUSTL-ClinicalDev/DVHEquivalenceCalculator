   M S B A M L   `   `   `  ����J  FDoseEquivalency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:DoseMetrics.ViewsDoseMetrics.Views  5      /    )DoseMetrics.Views.DoseMetricSelectionView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:DoseMetrics.Views     5      .��5	      � 
����İ�  � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5!   
   �� $��	Structure��6   �� 5"   
   $��Metric��6   $��1��6"   �� 5#   
   $��Input Value��6   $��2��6'   �� 5$   
   $��In Unit��6   $��3��6#   �� 5%   
   $��Out Unit��6   $��5��6$   �� 5&   
   $��	Tolerance��6   $��6��6%   �� 5'   
   $��α / β Ratio��6   $��7��6'   �� 5*   
   $��1��6    �� DisplayMemberPath$ Id��6C   $��2q�5+   >   ��5*       �� *
Structures+ �� SelectedItem 5+      �� *SelectedStructure+6>   �� 5,   
   $��1��6   $��1��6    $ Metric��5-      $��2q�6V   ��5,   0   �� *DoseMetrics+ 5-   .   �� *SelectedMetric+6V   �� 5.   
   $��2��6=   $��1��6M   $��2q�6Z   ��6   �� *SelectedMetric.InputValue+6Z   �� 5/   
   $��1��6   $��3��6    $��2q�50   R   ��5/   0   �� *SelectedMetric.InputUnits+ 50      �� *SelectedMetric.InputUnit+ �� Mode$ TwoWay=�6R   �� 51   
   $��in��6   $��1��6   $��4��6+   $��Center=�6;   �� 52   
   $��1��6   $��5��6    ��60   �� *SelectedMetric.OutputUnits+ 53      �� *SelectedMetric.OutputUnit+$ TwoWay=��� 54   
   $��1��6<   $��6��6I   $��2q�6Y   ��6   �� *SelectedMetric.Tolerance+6Y   �� 55   
   $��1��6k   $��7��6x   $��2q�6�   ��6   �� *SelectedMetric.ABRatio+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 56   
   $��
Add Metric��6   $��1��6&   $��8��63   $��2q�6C   ��6N   �� *AddMetricCommand+58      59      