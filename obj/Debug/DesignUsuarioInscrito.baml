   M S B A M L   `   `   `  ����C  ?JobStack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:JobStackJobStack  5      $    JobStack.DesignUsuarioInscrito   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:JobStack     5      $��0,0,0,10q�5
        � 	Resources  5         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1 �� 
TargetType �� 
TargetType ��Name	 �� CornerRadius
 ��Name �� Triggers P� Property P� Value �� 
TargetName��%b  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6%   .�5       ��  �@�FocusVisualStyle8   61   �� 5!       � ��8  6+   �� 5"       � ��8  6,   �� 5#       � ��# � ��6+   �� 5$       � ��$ 0q�60   �� 5%       � ��$ Center=�6;   �� 5&       � ��$ Center=�69   �� 5'       � ��$ 1q�6(   �� 5(       � �� 5)      �� 5*      " ��6&   .R�5+      �� $ border��6!   $	 10��61   #��z��6C   #��z��6o   #��z��6�    . ._�5,      �� $
 contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5-       5.      P� 5/       �@��IsDefaulted . . �50   "   �� $ border��6@   # � ��6T    � ��51      P� 52       �@J�IsMouseOver . . �53   "   �� $ border��6?    � �� �#2973AA6S   �� 54   "   $ border��6@    � �� �#2973AA6T   55      P� 56       � �� . . �57   "   �� $ border��6?    � �� �#67A8D86S   �� 58   "   $ border��6@    � �� �#67A8D86T   59      P� 5:       � {� .  . �5;   "   �� $ border��6?   8   � ��6S   �� 5<   "   $ border��6@   8   � ��6T   �� 5=   "   $ contentPresenter��6K   8   � ��6i   5>      5@      5B      5C      5D      .��5E      � $	��100��6   $	��880��6   .+�5F   
   �� 
������� �� RadiusX$ 10��5G       �� RadiusY$ 10��5H      $	��880��5I      $	��100��5J      $��0,1,0,-1q�6!    J� Effect 5L      3  -System.Windows.Media.Effects.DropShadowEffect  5M         ShadowDepth$ 2Q�6#      Opacity$	 0.2Q�63      
BlurRadius$ 3Q�6A   5O      �� 5Q   
   -   5        $ 
FotoPerfil��5Q      $
��Left=�6%   $��22,11,0,7.5q�6@   $��80��6U   $��80��6`   $	 50��6l   ��5R      �� 5S      -   5        Img�� �� ImageSource$5 /blank-profile-picture-973460_1280-1-705x705.png��5S   *    j� Stretch$
 Fill=�6h    5U        5V      $ 3Q�6#      Color$ Black��63   $	 0.2Q�6A   $ 5Q�6O   5X      �� 5Y   
   -   5         ��Name$ NomeUsuario��5Y      $��Nome do Usuario��5Z      $	��Top=�5[      $
��Left=�5\      $��115.5,27,0,0q�5]      $��24(�5^      $��Century Gothic)�5_      ���#0039645`      �� 5a   
   -   5        $ Status��5a      $��Selecionado��5b      $	��Top=�5c      $
��Left=�5d      $��115.5,56,0,0q�5e      $��20(�5f      $��Century Gothic)�5g      
��� � �5h      �� 5j   
   -   5         ��Name$ BtnVerPerfil��5j      $	��110��5k      $��30��5l      $��Century Gothic)�5m      $��16(�5n      ���#003964
�������$��
Ver perfil��5q      $��724,35,26,35q�6&   #��� 
 6<   6c   5s      5t      