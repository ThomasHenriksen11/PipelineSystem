   M S B A M L   `   `   `  ����I  EPipelineSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PipelineSystemPipelineSystem  5   	   S.clr-namespace:PipelineSystem.Application_Layer PipelineSystem.Application_Layer  5   	   (    "PipelineSystem.UI_Layer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PipelineSystem     5   	   LApplication_Layer.clr-namespace:PipelineSystem.Application_Layer     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��0.4* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��0.4* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��0.6* �6   �� 5      $
��0.7* �6   �� 5      $��* �6   �� 5      $
��0.5* �6   �� 5      $��* �6   �� 5      $
��0.5* �6   �� 5      $��* �6   �� 5      $
��0.5* �6   .+�5!   
   (�  (� Stretch$ Uniform=�6   $��1��6$   $��0��61   $��8��6A   .��5"      �� $��Vleppo pipeline��6   $��25(�6.   5#      (� 5$   
   $ Uniform=�6   $��3��6$   $��1��61   $��3��6A   .��5%      �� $��Active pipelines��6   $��10(�6/   5&      �� 5'   
   $��3��6   $��4��6!   
�������.��5(      �� 5)      �� 5*   
   -   5         ��Name$ Listbox1��5*      $��Visible=�6$   $��1��6W   $��3��6g   $��4��6{   $��5��6�   $��Disabled=�6�   .@�5+      �� -   5        
�������.��5,      �� $	��530��6   $��23(�6$   $��Sales��62   5-      5.      �� 5/   
   -   5        $��6��5/      $��4��6!   
�������.��50      (� $ Uniform=�6   .��51      �� $��Add new pipeline��6   52      53      �� 54   
   -   5        $��6��54      $��6��6!   
�������.��55      (� $ Uniform=�6   .��56      �� $��Remove pipeline��6   57      58      59      5:      