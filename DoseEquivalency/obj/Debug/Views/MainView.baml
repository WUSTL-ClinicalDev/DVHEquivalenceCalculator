   M S B A M L   `   `   `  ����J  FDoseEquivalency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:DoseEquivalency.ViewsDoseEquivalency.Views  5   	   5clr-namespace:DoseMetrics.ViewsDoseMetrics.Views  5      $    DoseEquivalency.Views.MainView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:DoseEquivalency.Views     5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null8metro,http://metro.mahapps.com/winfx/xaml/controls  5   	   1dosemetricsclr-namespace:DoseMetrics.Views  5        � Title$!  Dose Equivalence Calculator��5
   	   $	��650��6-   $
��1000��6:   
�������.��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   2   ,DoseEquivalency.Views.StructureSelectionView  $��2��6[   $��1��6l    � DataContext 6'   �� *StructureSelectionViewModel+6l   �� 5!   
   $��1��6   $��2��6%   .@�5"      �� $	��DVH��6   .��5#      #   DoseEquivalency.Views.DVHView   6    �� *DVHViewModel+5$      �� 5%      $��EQD2 DVH��6   
���/���$��0,0,0,10q�6B   .��5&      (   "DoseEquivalency.Views.EQD2_DVHView   6%   �� *EQD2DVHViewModel+5'      �� 5(      $��BED DVH��6   
���/���$��0,0,0,10q�6A   .��5)      '   !DoseEquivalency.Views.BED_DVHView   6$   �� *BEDDVHViewModel+5*      �� 5+      $��Dose Metric��6   
���/���$��0,0,0,10q�6E   .��5,      �� .+�5-      /   )DoseMetrics.Views.DoseMetricSelectionView   6:   �� *DoseMetricSelectionViewModel+&    DoseMetrics.Views.DoseMetricView  5.       61   �� *DoseMetricViewModel+5/      50      51      52      53      