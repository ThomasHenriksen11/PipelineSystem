   M S B A M L   `   `   `  ����I  EPipelineSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:PipelineSystem.UI_LayerPipelineSystem.UI_Layer  5   	   S.clr-namespace:PipelineSystem.Application_Layer PipelineSystem.Application_Layer  5   	   2    ,PipelineSystem.UI_Layer.RemovePipelineWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:PipelineSystem.UI_Layer     5   	   LApplication_Layer.clr-namespace:PipelineSystem.Application_Layer     5   	     � Title$  RemovePipelineWindow��5	   	   $	��450��6&   $	��800��63   .��5
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
   �� -   5         ��Name$ Listbox2��5!      $��Visible=�6%   $��1��6X   $��3��6h   $��1��6|   $��5��6�   $��Disabled=�6�   $	��215��6�   $��
0.2,0,0,27q�6�   $��Bottom=�6�   $ �� IsSynchronizedWithCurrentItem$ FalseY�6   � DataContext 5"      3   -PipelineSystem.Application_Layer.PipeLineRepo  5#      5%      �� 5&   
   -   5        $��6��5&      $��6��6!   .��5'      (�  (� Stretch$ Uniform=�6   .��5(      �� $
��Back��6   5)      5*      �� 5+   
   -   5        $��6��5+      $��4��6!   .��5,      (� $ Uniform=�6   .��5-      �� $��Remove��6   5.      5/      50      51      