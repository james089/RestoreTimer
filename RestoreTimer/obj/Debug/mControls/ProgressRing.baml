   M S B A M L   `   `   `  ����G  CRestoreTimer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:RestoreTimer.mControlsRestoreTimer.mControls  5      )    #RestoreTimer.mControls.ProgressRing   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      c _Microsoft.Expression.Drawing, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      0local$clr-namespace:RestoreTimer.mControls  5      .��5      (� .��5   
   �� $��5q�6     �� CornerRadius$	  500��6%   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFDADADA��6#    � Offset$ 0Q�65   � 5      $ 	#FF252525��6#   $ 1Q�65   � 5      $ 	#FF818181��6#   $ 0.515Q�65   5      ._�5   
   � .+�5   
   A� 
�������$��40��6     J� Opacity$	 0.6Q�65   $��0q�6C    K� ZIndex$ 1��6N   A� 5   
   $��5��6   $��40q�6&   $ 1��62   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FF2C2C2C��6#   $ 0Q�65   � 5      $ 	#FF6E6E6E��6#   $ 1Q�65   � 5      $ 	#FF646464��6#   $ 0.866Q�65   5      5      %  Microsoft.Expression.Shapes.Arc  5   
   -   5          Name$ EllipseFill��5      $ 2��6&   $��0q�67      ArcThickness$ 40Q�6B   	   
StartAngle$	 0Q�6T   
   EndAngle$	
 360Q�6c    �� Stretch$
 None=�6r   
������ $��0��6�   
��� � � J� Effect 5       -  'System.Windows.Media.Effects.BlurEffect  5!         Radius$ 3Q�6!   5#      � 5%   
   $��40q�6   .+�5&      �� -   5         ��Name$ 
Btn_center��5&      $ 1��6B   ��5'      �� 5(       �� 
TargetType" ��6&   .R�5)   "   A�  A�Name$ centerButton��6*   $	��500��6@   
���   �$	 0.4Q�6c    5*   &     5+   *   $ 30Q�65   ��5-   &   �� 5.   *   $ 0.5,1&�6>   $ 0.5,0&�6O   .��5/   .   � $ 	#FFFFF8F8��6;   $ 0Q�6M   � 50   .   $ White��6;   $ 1Q�6I   � 51   .   $ Black��6;   $	 0.5Q�6I   52   +   54   #    �� Triggers 56   "   P� 57       P� Property � �� P� Value . . �58   "   ��  �� 
TargetName$ centerButton��6)    �� Property � �� �� Value
 �   �6U   59      5;      5=      �� 5?      -   5         ��Name$ TValue��5?      $ 0��6(   $��Center=�69   $��0,0,0,40q�6V   $
��Wrap=�6h   $
��100%��6|   $��Bottom=�6�   $��36(�6�   
�������$��Segoe UI Light)�6�   �� 5@      -   5        $ TText��5@      $ 0��6'   $��Center=�68   $��0q�6U   $
��Wrap=�6`   $��Hello world��6t   $��Center=�6�   
�������$��48(�6�   $��Segoe UI Light)�6�   5B      5C      5D      5E      5H      