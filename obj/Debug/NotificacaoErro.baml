   M S B A M L   `   `   `  ����C  ?JobStack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:JobStackJobStack  5   	       JobStack.NotificacaoErro   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:JobStack     5   	     � Title$  NotificacaoErro��5   	    � WindowStyle$
 None=�5	   	   $	��130��5
   	   $	��450��5   	   
������  � AllowsTransparency . 
������  � 	Resources 5         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1	 �� 
TargetType
 �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%b  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5    
   $ 	#FFF4F4F4��6=   �� 5!   
   $ 	#FFADB2B5��69   �� 5"   
   $ 	#FF838383��6=   �� 5#   
   "	 ��6%   .�5$      ��  �@�FocusVisualStyle8   61   �� 5%       � ��8  6+   �� 5&       � ��8  6,   �� 5'       � ��# � ��6+   �� 5(       � ��$ 0q�60   �� 5)       � ��$ Center=�6;   �� 5*       � ��$ Center=�69   �� 5+       � ��$ 1q�6(   �� 5,       � �� 5-      �� 5.      "
 ��6&   .R�5/      �� $ border��6!   $ 20��61   #��z��6C   #��z��6o   #��z��6�    . ._�50      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  51       52      P� 53       �@��IsDefaulted . . �54   "   �� $ border��6@   # � ��6T    � ��55      P� 56       �@J�IsMouseOver . . �57   "   �� $ border��6?    � �� �#A918186S   �� 58   "   $ border��6@    � �� �#A918186T   59      P� 5:       � �� . . �5;   "   �� $ border��6?    � �� �#B74B4B6S   �� 5<   "   $ border��6@    � �� �#B74B4B6T   5=      P� 5>       � {� .  . �5?   "   �� $ border��6?   8   � ��6S   �� 5@   "   $ border��6@   8   � ��6T   �� 5A   "   $ contentPresenter��6K   8   � ��6i   5B      5D      5F      5G      5H      .��5I      � .+�5J   
   �� -   5         ��Name$ FundoNotificacao��5J      
���  �� �� RadiusX$ 15��5L       �� RadiusY$ 15��5M       J� Opacity$ 90Q�5N       J� Effect 5P      3  -System.Windows.Media.Effects.DropShadowEffect  5Q         ShadowDepth$ 2Q�6#      Opacity$	 0.3Q�63      
BlurRadius$ 3Q�6A   5S      � 5T   
   -   5         �Name$ IconeNotificacao��5T      $��70��5U      $��70��5V      $
��Left=�5W      $��Center=�5X      $��20, 0, 0, 0q�5Y       � RowDefinitions 5Z      �� 5[      $	��32* �6    �� 5\      $��3* �6    .+�5^      �� $
��Left=�6   $	��100��6/   $	��Top=�6<   $	��151��6T   $��Imagens/alerta_falha.png��6`   $��-23,-16,-58,-14q�6�   $��2��6�   5_      �� 5`   
   $��Erro.��6   $��Century Gothic Bold)�5a      $��22(�5b      
�������
������ $��Center=�5e      $	��Top=�5f      $��144,38,260,0q�5g      �� 5i   
   -   5         ��Name$ MsgErro��5i      $��16(�5j      $��Century Gothic)�5k      
������ 
�������$
��Left=�5n      $��Center=�5o      $��144,75,-38,35q�5p      $	��344��6+   �� 5q      $'�!Que tal deslogar da próxima vez?��6   �� 6I   $�😉 ��6M   6[   �� 5r   
   -   5         ��Name$ 	BtnFechar��5r      $��30��5s      $��30��5t      $��Century Gothic Bold)�5v      $��16(�5w      
������ 
�������$��Right=�5z      $	��Top=�5{      $��0,7.334,7.834,0q�5|      #��� 
 6*   .��5~      �� $��Icones/fechar.png��6   $��20��6/   $��20��6:   5      5�      5�      