   M S B A M L   `   `   `  ����C  ?JobStack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:JobStackJobStack  5      '    !JobStack.TVagasFinalizadasEmpresa   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:JobStack     5      ���	#FFD9EBFB  � 	Resources  5
         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 BotaoArredondadoStyle �� 
TargetType �� 
TargetType ��Name	 �� CornerRadius
 ��Name �� Triggers P� Property P� Value �� 
TargetName��%J  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6.   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5        � ��8  6,   �� 5!       � ��# � ��6+   �� 5"       � ��$ 0q�60   �� 5#       � ��$ Center=�6;   �� 5$       � ��$ Center=�69   �� 5%       � ��$ 1q�6(   �� 5&       � �� 5'      �� 5(      " ��6&   .R�5)      �� $ border��6!   $	 10��61   #��z��6C   #��z��6o   #��z��6�    . ._�5*      �� $
 contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5+       5,      P� 5-       �@��IsDefaulted . . �5.   "   �� $ border��6@   # � ��6T    � ��5/      P� 50       �@J�IsMouseOver . . �51   "   �� $ border��6?   8   � ��6S   �� 52   "   $ border��6@   8   � ��6T   53      P� 54       � �� . . �55   "   �� $ border��6?   8   � ��6S   �� 56   "   $ border��6@   8   � ��6T   57      P� 58       � {� .  . �59   "   �� $ border��6?   8   � ��6S   �� 5:   "   $ border��6@   8   � ��6T   �� 5;   "   $ contentPresenter��6K   8 	  � ��6i   5<      5>      5@      5A      5B      .��5C      � .+�5D   
   �� -   5         ��Name$ TxtFinalizadas��5D      $,��&Essas são suas vagas já finalizadas:��5E      $��24(�5F      $��Century Gothic)�5G      $
��Left=�5H      
������ ���#003964$	��Top=�5K      $��	24,20,0,0q�6,   � 5M   
   -   5         �Name$ GridExibirVaga��5M      $	��852��5N      $	��380��5O      $��Center=�5P      $��Center=�5Q      $��25.323,69.52,22.177,50.98q�6*   .+�5R      �� 
������� �� RadiusX$ 10��5T       �� RadiusY$ 10��5U       J� Effect 5W      3  -System.Windows.Media.Effects.DropShadowEffect  5X         ShadowDepth$ 3Q�6'      Color$ Black��67      Opacity$	 0.2Q�6E      
BlurRadius$ 5Q�6S   5Z      �� 5[      -   5         ��Name$ SVVagas��5[      $��Right=�5\      $��Center=�5]      $	��852��5^      $	��380��5_      $��-0.5,-1,0.5,1q�6(    J� RenderTransformOrigin$	 0,0&�6?   .��5`      �� -   5         ��Name$ SPVagas��5`       �� Orientation$ Vertical=�5a   !   $	��820��5b      $��0��5c      $��	10,10,0,0q�5d      $	��Top=�5e   !   $
��Left=�5f   !   5h      5i      5j      5k      5l      