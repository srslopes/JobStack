   M S B A M L   `   `   `  ����C  ?JobStack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:JobStackJobStack  5   	   !    JobStack.NotificacaoAtencao   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:JobStack     5   	     � WindowStyle$
  None=�5   	   $	��130��5	   	   $	��450��5
   	   
������  � AllowsTransparency . 
������  � 	Resources 5         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1 �� 
TargetType	 �� 
TargetType
 ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%b  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5    
   $ 	#FFADB2B5��69   �� 5!   
   $ 	#FF838383��6=   �� 5"   
   " ��6%   .�5#      ��  �@�FocusVisualStyle8   61   �� 5$       � ��8  6+   �� 5%       � ��8  6,   �� 5&       � ��# � ��6+   �� 5'       � ��$ 0q�60   �� 5(       � ��$ Center=�6;   �� 5)       � ��$ Center=�69   �� 5*       � ��$ 1q�6(   �� 5+       � �� 5,      �� 5-      "	 ��6&   .R�5.      �� $
 border��6!   $ 20��61   #��z��6C   #��z��6o   #��z��6�    . ._�5/      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  50       51      P� 52       �@��IsDefaulted . . �53   "   �� $ border��6@   # � ��6T    � ��54      P� 55       �@J�IsMouseOver . . �56   "   �� $ border��6?    � �� �#E0AA006S   �� 57   "   $ border��6@    � �� �#E0AA006T   58      P� 59       � �� . . �5:   "   �� $ border��6?    � �� �#C091006S   �� 5;   "   $ border��6@    � �� �#C091006T   5<      P� 5=       � {� .  . �5>   "   �� $ border��6?   8   � ��6S   �� 5?   "   $ border��6@   8   � ��6T   �� 5@   "   $ contentPresenter��6K   8   � ��6i   5A      5C      5E      5F      5G      .��5H      � .+�5I   
   �� -   5         ��Name$ FundoNotificacao��5I      ���#FFC309 �� RadiusX$ 15��5K       �� RadiusY$ 15��5L       J� Opacity$ 90Q�5M       J� Effect 5O      3  -System.Windows.Media.Effects.DropShadowEffect  5P         ShadowDepth$ 2Q�6#      Opacity$	 0.3Q�63      
BlurRadius$ 3Q�6A   5R      � 5S   
   -   5         �Name$ IconeNotificacao��5S      $��70��5T      $��70��5U      $
��Left=�5V      $��Center=�5W      $��20, 0, 0, 0q�5X      .+�5Y      A� $��70��5Z      $��70��5[      $
��Left=�5\      $��Center=�5]      $��-0.01,0,0,0q�5^      
�������5a      �� 5b      $��Icones/warning.png��6   $��40��5c      $��40��5d      $��Center=�5e      $��Center=�5f      5g      �� 5h   
   $��
Atenção!��6   $��Century Gothic Bold)�5i      $��22(�5j      
�������
������ $��Center=�5m      $	��Top=�5n      $��98.678,40,252.318,0q�5o      �� 5q   
   -   5         ��Name$ 
MsgAtencao��5q      $��Insira o texto aqui��5r      $��16(�5s      $��Century Gothic)�5t      
������ 
�������$
��Left=�5w      $��Center=�5x      $��99.387,70.191,0,40.191q�5y      $��343.807��64   �� 5{   
   -   5         ��Name$ 	BtnFechar��5{      $��30��5|      $��30��5}      $��Century Gothic Bold)�5      $��16(�5�      
������ 
�������$��Right=�5�      $	��Top=�5�      $��0,7.334,7.834,0q�5�      #��� 
 6*   .��5�      �� $��Icones/fechar.png��6   $��20��6/   $��20��6:   5�      5�      5�      