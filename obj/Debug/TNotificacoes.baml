   M S B A M L   `   `   `  ����C  ?JobStack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:JobStackJobStack  5          JobStack.TNotificacoes   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:JobStack     5      ���	#FFD9EBFB  � 	Resources  5         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 BotaoArredondadoStyle �� 
TargetType �� 
TargetType ��Name	 �� CornerRadius
 ��Name �� Triggers P� Property P� Value �� 
TargetName��%b  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6.   .�5      ��  �@�FocusVisualStyle8   61   �� 5        � ��8  6+   �� 5!       � ��8  6,   �� 5"       � ��# � ��6+   �� 5#       � ��$ 0q�60   �� 5$       � ��$ Center=�6;   �� 5%       � ��$ Center=�69   �� 5&       � ��$ 1q�6(   �� 5'       � �� 5(      �� 5)      " ��6&   .R�5*      �� $ border��6!   $	 10��61   #��z��6C   #��z��6o   #��z��6�    . ._�5+      �� $
 contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5,       5-      P� 5.       �@��IsDefaulted . . �5/   "   �� $ border��6@   # � ��6T    � ��50      P� 51       �@J�IsMouseOver . . �52   "   �� $ border��6?    � �� �#2973AA6S   �� 53   "   $ border��6@    � �� �#2973AA6T   54      P� 55       � �� . . �56   "   �� $ border��6?    � �� �#2973AA6S   �� 57   "   $ border��6@    � �� �#2973AA6T   58      P� 59       � {� .  . �5:   "   �� $ border��6?   8   � ��6S   �� 5;   "   $ border��6@   8   � ��6T   �� 5<   "   $ contentPresenter��6K   8   � ��6i   5=      5?      5A      5B      5C      .��5D      � .+�5F   
   �� -   5         ��Name$ 	txtTitulo��5F      $	��500��5G      $��50��5H      $
��Left=�5I      $	��Top=�5J      $��NOTIFICAÇÕES��5K      $��35(�5L      $��Century Gothic Bold)�5M      ���#003964$��	30,30,0,0q�5N   -   � 5P   
   -   5         �Name$ GridNotificacoes��5P      $��
0,17,0,-17q�6)    � ColumnDefinitions 5Q      �� 5R      $
��Auto �6#   �� 5S      $��* �6#   .+�5U      �� -   5         ��Name$ FundoGridNotificacoes��5U       �� RadiusX$ 10��5V       �� RadiusY$ 10��5W      $��28,72,23,81q�5X      
�������$��2��5Y   )    J� Effect 5[      3  -System.Windows.Media.Effects.DropShadowEffect  5\         ShadowDepth$ 3Q�6'      Color$ Black��67      Opacity$	 0.2Q�6E      
BlurRadius$ 5Q�6S   5^      �� 5_      -   5         ��Name$ SVNotificacoes��5_      $��Right=�5`      $��Center=�5a      $��897.5��5b      $��470.279��5c      $��0,80.883,27.5,88.838q�6,    J� RenderTransformOrigin$	 0,0&�6J   $��2��6f   z�5d      V� 5e      .~�5f      �� �� 5g       �� AngleY$ 0Q�6(   �� 5h      T� 5i       T� Y$ 0Q�6-   5j      .��5l      �� -   5         ��Name$ SPNotificacoes��5l       �� Orientation$ Vertical=�5m   !   $	��740��5n      $��0��5o      $	��Top=�5p   !   $��Center=�5q   !   5s      5t      �� 5u      -   5          ��Name$  	BtnVoltar��5u      $��80��5v      $��25��5w      $��	0,0,30,45q�5x      $��Voltar��5y      $��12(�5z      $��Century Gothic)�5{      ���	#FF27597E
�������$��Right=�5~      $��Bottom=�5      $��2��61   #��� 
 6E   5�      5�      5�      