   M S B A M L   `   `   `  ����I  EPipelineSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PipelineSystemPipelineSystem  5   	   I)clr-namespace:PipelineSystem.Domain_LayerPipelineSystem.Domain_Layer  5   	   )    #PipelineSystem.UI_Layer.AddPipeline   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PipelineSystem     5   	   BDomain_Layer)clr-namespace:PipelineSystem.Domain_Layer     5   	     � Title$  AddPipeline��5	   	   $	��450��6   $	��800��6*    � ContextMenu 5
      �� 5   
    � DataContext 5      *   $PipelineSystem.Domain_Layer.Pipeline  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��4* �6   �� 5      $��4* �6   �� 5      $��4* �6   �� 5      $��4* �6   �� 5      $��4* �6   �� 5      $��4* �6   �� 5      $��4* �6   �� 5      $��4* �6   �� 5      $��4* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5       $��1* �6   �� 5!      $��1* �6   �� 5"      $��1* �6   �� 5#      $��1* �6   .+�5%   
   (�  (� Stretch$ Uniform=�6   $��1��6$   $��3��61   $��3��6A   .��5&      �� -   5         ��Name$ NewPipiline��5&      $��New pipeline��6)   5'      (� 5(   
   $ Uniform=�6   $��2��6$   $��1��61   .��5)      �� -   5        $
 Name��5)      $
��Name��6"   $
��Left=�61   5*      �� 5+   
   -   5         ��Name$ PipelineName��5+      $��3��6F   $��1��6S   $��7��6c   $��30(�6w   $��Center=�6�   ��6(   �� *PipelineName+.��6�    5,        5-      .��5.   #   5/      �� 50   
   -   5        $��3��50      $��5��6"   .��51      (� $ Uniform=�6   .��52      �� $
��Save��6   53      54      �� 55   
   -   5        $��5��55      $��5��6!   .��56      (� $ Uniform=�6   .��57      �� $��Cancel��6   58      59      5:      5;      