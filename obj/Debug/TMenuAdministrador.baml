   M S B A M L   `   `   `  ����C  ?JobStack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:JobStackJobStack  5   	   !    JobStack.TMenuAdministrador   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:JobStack     5   	     � Title$
  Menu��5   	   $	��640��5	   	   $
��1024��5
   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$ SingleBorderWindow=�5   	    � Topmost .  � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency .  ���	#FFD9EBFB   AppIcon � Icon# [  5   	    � 	Resources 5        
font_style �� 
TargetType	 �� Property
 �� Value  tb_mouse_over �� ImageSource  tb_style �� 
TargetType ��Name J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName  tt_style��%_  &	       &	 x     &	 �     7  7  7  7  &	 �    �� 5   
   " ��6#   .�5      �� 	 � ��$
 Center=�5      �� 5      	 � ��$
 20(�5      5      �� 5   
   $  Icones/icon menu bar 2.png��5      �� 5   
   " d�6!   .�5      �� 	 � ��
 5       �� 5!      " d�6&   .R�5"      �� $ border��6!   #��z��5#   !   #��z��5$   !    . 5%   >    5&      P� 5'       �@J�IsMouseOver . . �5(   "   �� $ border��5)   )   8
   	 � ��5*   )   �� 5+   "   $ border��5,   )   8
  	 � ��5-   )   5.      P� 5/       �@d�	IsChecked$
 TrueY�6;   . �50   "   �� $ border��51   )   8
  	 � ��52   )   �� 53   "   $ border��54   )   8
  	 � ��55   )   56      58      5:      5;      �� 5>   
   " _�6   .�5?      �� 	 �@_�	Placement$
 Right=�6*   �� 5@      	 � ��$
 20, 0, 0, 0q�6'   �� 5A      	 � ��
 �	#FF0039646+   �� 5B      	 � ��

 ���� 6,   �� 5C      	 � ��

 �����6+   �� 5D      	 � ��$
 Century Gothic)�6+   �� 5E      	 � ��$
 16(�6)   �� 5F      	 �@_�PlacementRectangle$
 60, 0, 0, 0�63   �� 5G      	 �@_�HorizontalOffset$
 15��61   �� 5H      	 �@_�VerticalOffset$
 6��6/   �� 5I      	 �@_�HasDropShadow
 . 6.   �� 5J      	 � ��$
 Center=�6;   5K      5N      .��5O      ��  �� CornerRadius$ 20��6   $��0q�6   
������ ._�5P   
   � .+�5Q      � -   5         �Name$ ConteudoJanela��5Q      $	��954��5R      $	��640��5S      $��	70,0,-6,0q�5T      $��Center=�5U      $��Center=�5V      5Y      � 5Z      .+�5[      � -   5        $ 
barra_menu��5[      $
��Left=�5\      $��70��5]      ��5^      �� 5_       �� EndPoint$ 0.5,1&�6.    �� 
StartPoint$ 0.5,0&�6?   .��5`      �  � Color$ 	#FF003964��6+    � Offset$ 0Q�6=   � 5a      $ 	#FF04121D��6+   $ 1Q�6=   5b      .+�5d      �� -   5         ��Name$ panel_btnmenu��5d   !   .+�5e      � $��88.667��6   .+�5h      d� -   5         d�Name$ 	BotaoMenu��5h   +   $��0��5i   '   $��Center=�5j   '   $
��Left=�5k   '   $��15,25.998,0,22.669q�5l   '   $��40��5m   '   $��40��5n   '   $��0q�5o   '   #��[ 5p   '   ��5q   "   �� 5r   &   $ Icones/icon menu bar.png��61    j� Stretch$ Uniform=�5s   -    � Triggers 5v   "   :� 5w   &    :� RoutedEvent$ ToggleButton.Unchecked��63   .[�5x   *   �� .��5y   .   �� -   5         ��Name$ DiminuiMenu��5y   9   .��5z   2   W�  �� 
TargetName$ 
barra_menu��5{   1     �� TargetProperty$  Width�5|   1   ! g� 	BeginTime$! 0:0:0X�5}   1   " W� From$	" 250X�5~   1   	# W� To$# 70X�6<   $ g� Duration$$ 	0:0:0:0.3D�5   1   6H   5�   /   5�   +   5�   '   :� 5�   &   $ ToggleButton.Checked��63   .[�5�   *   �� .��5�   .   �� -   5        $ ExpandeMenu��5�   9   .��5�   2   W� $ 
barra_menu��5�   1   $  Width�5�   1   $! 0:0:0X�5�   1   $" 70X�5�   1   $	# 250X�6;   $$ 	0:0:0:0.3D�5�   1   6H   5�   /   5�   +   5�   '   5�      5�      � 5�      $��60��5�      $	��250��5�      $
��Left=�5�      $	��Top=�5�      .+�5�      �� $��Icones/jobstack-v3.png��6$   $	��250��5�   $   $��65��5�   $   $
��Left=�5�   $   $��2.5,-0.332,-2.5,-4.668q�6?   $	��Top=�6_   5�      5�      �� 5�      -   5        % ��Name$% 	ItensMenu��5�   #   
������ 
������ $��542.167��5�   9   .@�5�      �� -   5        $
��Left=�5�   +   $��0, 0, 0, 15q�5�   '   .��5�   "   � -	   5        $ 	LVBtnChat��5�   '   $	��250��5�   '   $��50��5�   '   $
��Left=�5�   '   .+�5�   &   �� $��Icones/icon_chat.png��6,   $��UniformToFill=�5�   ,   $
��Left=�5�   ,   $��40��5�   ,   $��40��5�   ,   $��9.158,3.664,0,6.335q�68   �� 5�   &   -
   5        & ��Name$& 
txtBtnChat��5�   0   $	��250��5�   0   $��50��5�   0   $��Century Gothic)�5�   0   $
��CHAT��5�   0   
�������$��18(�5�   0   $��Center=�5�   0   ' �� Padding$' 62, 13, 0, 0q�5�   0   5�   '   � 5�   &   -   5        $ Notificacao��5�   +   $��Center=�6@   $
��Left=�6[   $��	35,0,0,20q�6v   $��20��6�   $��20��6�   .+�5�   *   �� ( �� RadiusX$( 15��64   ) �� RadiusY$) 15��6A   
���  ��* J� Effect* 5�   .   3  -System.Windows.Media.Effects.DropShadowEffect  5�   2   +   ShadowDepth$+ 3Q�6C   ,   Color$, Black��6S   -   Opacity$	- 0.2Q�6a   .   
BlurRadius$. 5Q�6o   5�   +   �� 5�   *   -   5        $& Notif��5�   4   $��X��6C   $��Center=�6M   $��Center=�6h   $��14(�6�   $
��Bold"�6�   
�������$��0,0,0,0q�6�   5�   '   5�   #   / � ToolTip/ 5�   "   _� 5�   &   -   5        0 _�Name$0 tt_chat��5�   .   $
��Chat��5�   .   #��[ 5�   .   $��90��5�   .   $��50��5�   .   5�      �� 5�      -   5        $
��Left=�5�   +   $��0, 0, 0, 15q�6F   .��5�   "   � -   5        $ LVBtnUsuarios��5�   '   $	��250��5�   '   $��50��5�   '   $
��Left=�5�   '   .+�5�   &   �� $��Icones/icon usuarios.png��6,   $��UniformToFill=�5�   ,   $
��Left=�5�   ,   $��38��5�   ,   $��9,6,0,9q�67   �� 5�   &   -   5        $& txtBtnUsuarios��5�   0   $	��250��5�   0   $��50��5�   0   $
��Left=�5�   0   $��	USUÁRIOS��5�   0   $��Century Gothic)�5�   0   $��18(�5�   0   
�������$��Center=�5�   0   $' 62, 13, 0, 0q�5�   0   5�   '   5�   #   / 5�   "   _� 5�   &   -   5        $0 tt_usuarios��5�   .   $��	Usuários��5�   .   #��[ 5�   .   $	��100��5�   .   $��50��5�   .   5�      �� 5�      -   5        $
��Left=�5�   +   $��0, 0, 0, 15q�6F   .��5�   "   � -   5        $ LVBtnCadUsuario��5�   '   $	��250��5�   '   $��50��5�   '   $��Center=�5�   '   .+�5�   &   �� $"��Icones/icon cad_usuarios.png��6,   $��UniformToFill=�5�   (   $
��Left=�5�   (   $��38��5�   (   $��16,6,0,5q�63   �� 5�   &   -   5        $& txtBtnCadUsuarios��5�   0   $��50��5�   ,   $	��250��5   ,   $��	CADASTRAR��5  ,   $��Century Gothic)�5  ,   $��18(�5  ,   
�������$��Center=�5  ,   $' 65, 13, 0, 0q�5  ,   $��	1,2,-1,-2q�6C   6V   5  #   / 5	  "   _� 5
  &   -   5        $0 tt_cadusuario��5
  .   $��Cadastro de usuário��5  .   #��[ 5  .   $	��180��5  .   $��50��5  .   5     �� 5     -   5        $
��Left=�5  +   $��0, 0, 0, 15q�6F   .��5  "   � -   5        $ LVBtnLogout��5  '   $	��250��5  '   $��50��5  '   $
��Left=�5  '   .+�5  &   �� $��Icones/icon logout .png��6,   $��40��5  .   $��40��5  .   $��UniformToFill=�5  .   $
��Left=�5  .   $��10.655,5.662,0,4.337q�6I   �� 5  &   -   5        $& txtBtnLogout��5  0   $��50��5  0   $	��250��5   0   $��LOG OUT/SAIR��5!  0   $��Century Gothic)�5"  0   $��18(�5#  0   
�������$��Center=�5%  0   $' 60, 13, 0, 0q�5&  0   5(  '   5)  #   / 5*  "   _� 5+  &   -   5        $0 	tt_logout��5+  .   $
��Sair��5,  .   #��[ 5-  .   $��90��5.  .   $��50��5/  .   51     ��53     �� 54  "   " ��6(   .�55  &   �� 	 � ��
 56  *   �� 57  .   " ��6>   .R�58  2   �� $ borda��69   $��60��59  9   $	��250��5:  9   #��z��5;  9   #��z��5<  9   #��z��5=  9   1 �� Padding#1 z��5>  9    . ._�5@  6   �� #��z��6G   # z 5A  G   #��z��5B  G   5C  3    5D  2   ]� 5E  6   2 ]� 
Conditions2 5F  :   �� 5G  >   3 �� Property3 �@J�IsMouseOver4 �� Value4 . 6_   ./�5I  :   �� $ borda��5J  A   	 � ��
 �#014C855K  A   �� 5L  :   $ borda��5M  A   	 � ��
 �#014C855N  A   5P  7   5R  /   5T  '   5U  #   5W     5X     5Y     5Z     5[     5\     5]     