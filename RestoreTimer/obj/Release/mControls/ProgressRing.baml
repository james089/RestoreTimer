   M S B A M L   `   `   `  ���� G  CRestoreTimer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:RestoreTimer.mControlsRestoreTimer.mControls  )    #RestoreTimer.mControls.ProgressRing   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     c _Microsoft.Expression.Drawing, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  :d2http://schemas.microsoft.com/expression/blend/2008  0local$clr-namespace:RestoreTimer.mControls  .��(� .���� $��5q�  �� CornerRadius$	  500������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFDADADA�� � Offset$ 0Q�� $ 	#FF252525��$ 1Q�� $ 	#FF818181��$ 0.515Q�._�� .+�A� 
�������$��40�� J� Opacity$	 0.6Q�$��0q� K� ZIndex$ 1��A� $��5��$��40q�$ 1������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF2C2C2C��$ 0Q�� $ 	#FF6E6E6E��$ 1Q�� $ 	#FF646464��$ 0.866Q�%  Microsoft.Expression.Shapes.Arc  -     Name$ EllipseFill��$ 2��$��0q�   ArcThickness$ 40Q�	   
StartAngle$	 0Q�
   EndAngle$	
 360Q� �� Stretch$
 None=�
������ $��0��
��� � � J� Effect -  'System.Windows.Media.Effects.BlurEffect     Radius$ 3Q�� $��40q�.+��� -    ��Name$ 
Btn_center��$ 1������  �� 
TargetType" ��.R�A�  A�Name$ centerButton��$	��500��
���   �$	 0.4Q�   $ 30Q����� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFFFF8F8��$ 0Q�� $ White��$ 1Q�� $ Black��$	 0.5Q� �� Triggers P�  P� Property � �� P� Value . . ���  �� 
TargetName$ centerButton�� �� Property � �� �� Value
 �   ��� -    ��Name$ TValue��$ 0��$��Center=�$��0,0,0,40q�$
��Wrap=�$
��100%��$��Bottom=�$��36(�
�������$��Segoe UI Light)��� -   $ TText��$ 0��$��Center=�$��0q�$
��Wrap=�$��Hello world��$��Center=�
�������$��48(�$��Segoe UI Light)�