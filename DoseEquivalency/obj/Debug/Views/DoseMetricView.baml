   M S B A M L   `   `   `  ����J  FDoseEquivalency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:DoseMetrics.ViewsDoseMetrics.Views  5      ?$clr-namespace:DoseMetrics.ConvertersDoseMetrics.Converters  5      &     DoseMetrics.Views.DoseMetricView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:DoseMetrics.Views     5      ;
converters$clr-namespace:DoseMetrics.Converters     5        � 	Resources  5
      ,   &DoseMetrics.Converters.DoubleConverter   doubleConverter3  -DoseMetrics.Converters.PassFailColorConverter  passFailConverter�� 5   
   %:   &	        &	        5      6)     5      60   5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��2* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   .+�5   
   �� $��	Structure��6   $
��Bold"�6%   �� 5   
   $��Dose Metric��6   $
��Bold"�6'   $��1��69   �� 5    
   $��Value��6   $
��Bold"�6!   $��2��63   �� 5!   
   $��	Tolerance��6   $
��Bold"�6%   $��3��67   �� 5"   
   $��α / β Ratio��6   $
��Bold"�6'   $��4��69   �� 5#   
   $��	EQD2 (Gy)��6   $
��Bold"�6%   $��5��67   �� 5$   
   $��BED (Gy)��6   $
��Bold"�6$   $��6��66   �� 5%   
   $��1��6   $��7��6$   ��68   �� *DoseMetrics+��5&      �� 5'      .R�5(      � ��6   �� *ToleranceMet+ �� 	Converter# [  5)      �� 5*      $��* �6/   �� 5+      $��2* �6/   �� 5,      $��* �6/   �� 5-      $��* �6/   �� 5.      $
��0.5* �6/   �� 5/      $
��0.5* �6/   �� 50      $
��0.5* �6/   .+�52      �� $��Center=�6?   ��6$   �� *	Structure+6?   �� 53      $��1��6$   $��Center=�64   �� 54      �6"   �� *Metric+ �� 55      $� (��6"    �� 56      �6"   �� *
InputValue+ �� 57      �6"   �� *	InputUnit+ �� 58      $� )��6"   59      �� 5:      $��2��6$   $��Center=�64   �� 5;      �6"   �� *OutputValue+# [   �� 5<      �6"   �� *
OutputUnit+5=      �� 5>      $��3��6?   $��Center=�6O   ��6$   �� *	Tolerance+6O   �� 5?      $��4��6=   $��Center=�6M   ��6$   �� *	ABRatio+6M   �� 5@      $��5��6l   $��Center=�6|   ��6$   �� *
OutputEQD2+# [  6|   �� 5A      $��6��6k   $��Center=�6{   ��6$   �� *	OutputBED+# [  6{   5B      5C      5E      5F      5G      