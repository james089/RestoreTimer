   M S B A M L   `   `   `  ���� G  CRestoreTimer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:RestoreTimer.mControlsRestoreTimer.mControls  +    %RestoreTimer.mControls.TimerSelector2   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     c _Microsoft.Expression.Drawing, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  0local$clr-namespace:RestoreTimer.mControls  -   .��(� .��� .+�A� $��60��$	��400��$	��400��  K� ZIndex$  0������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFE8E8E8�� � Offset$ 0Q�� $ 	#FF1D1D1D��$ 1Q�� $ 	#FF636363��$	 0.5Q�A� $��30��$��60q�$  0������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF272727��$ 0Q�� $ White��$ 1Q�� $ 	#FF6C6A6A��$ 0.524Q�A� $��20��$��60q����� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF272727��$ 0Q�� $ White��$ 1Q�� $ 	#FF6C6A6A��$ 0.524Q�� -    �Name$ Button_group��.+��� -    ��Name$ Btn_up��$  1��$	��Top=�$��Center=�����  �� 
TargetType" ��.R�0  *Microsoft.Expression.Shapes.RegularPolygon    Name$ upButton��	   InnerRadius$	 1Q�$��0q�
   
PointCount$
 3Q� �� Stretch$
 Fill=�$	��Top=�$��30��$��80��$��Center=�
���  �� �� Left$ 375.2��
 �� Top$	 190�� J� RenderTransformOrigin$ 0.5,0.5&���Z� z�V� .~��� �� ��  �� Angle$ 0Q�T�  �� Triggers P�  P� Property � �� P� Value . . ���  �� 
TargetName$ upButton�� �� Property � �� �� Value
 ������� -   $ 
Btn_center��$  0��$	��200��$	��200������ " ��.R�A�  A�Name$ centerButton��$	��200��
���   � J� Opacity$	 0.4Q� J� Effect -  'System.Windows.Media.Effects.BlurEffect     Radius$ 30Q����� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFFFF8F8��$ 0Q�� $ White��$ 1Q�� $ Black��$	 0.5Q��� -   $ Btn_down��$  1��$��Bottom=�$��Center=�$ 0.5,0.5&�z�V� .~��� �� �� $	 180Q�T� ���� " ��.R�  $ 
downButton��$	 1Q�$��0q�$
 3Q�$
 Fill=�$	��Top=�$��30��$��80��$��Center=�
���  ��$ 375.2��$	 190��$ 0.5,0.5&���Z� z�V� .~��� �� �� $ 0Q�T�  P�  � �� . . ��� $ 
downButton�� � ��
 ������� -    ��Name$ TText��$��Center=�$��Center=�$��48(�$	��---��$��Segoe WP Light)�
�������$  -1��