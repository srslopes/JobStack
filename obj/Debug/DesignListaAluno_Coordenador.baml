   M S B A M L   `   `   `  ����C  ?JobStack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:JobStackJobStack  5      +    %JobStack.DesignListaAluno_Coordenador   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:JobStack     5      $��0,0,0,10q�5
      $��Center=�5      $	��Top=�5        � 	Resources  5         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Disabled.Foreground  ButtonStyle1 �� 
TargetType �� 
TargetType ��Name	 �� CornerRadius
 ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    7   7  7  7  �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6%   .�5      ��  �@�FocusVisualStyle8   61   �� 5        � ��8  6+   �� 5!       � ��8  6,   �� 5"       � ��# � ��6+   �� 5#       � ��$ 0q�60   �� 5$       � ��$ Center=�6;   �� 5%       � ��$ Center=�69   �� 5&       � ��$ 1q�6(   �� 5'       � �� 5(      �� 5)      " ��6&   .R�5*      �� $ border��6!   $	 10��61   #��z��6C   #��z��6o   #��z��6�    . ._�5+      �� $
 contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5,       5-      P� 5.       �@��IsDefaulted . . �5/   "   �� $ border��6@   # � ��6T    � ��50      P� 51       �@J�IsMouseOver . . �52   "   �� $ border��6?    � �� �#2973AA6S   �� 53   "   $ border��6@    � �� �#2973AA6T   54      P� 55       � �� . . �56   "   �� $ border��6?    � �� �#67A8D86S   �� 57   "   $ border��6@    � �� �#67A8D86T   58      P� 59       � {� .  . �5:   "   �� $ border��6?    � �� �#0039646S   �� 5;   "   $ border��6@    � �� �#0039646T   �� 5<   "   $ contentPresenter��6K   8   � ��6i   5=      5?      5A      5B      5C      .��5D      � .+�5E   
   �� 
������� �� RadiusX$ 10��5F       �� RadiusY$ 10��5G      $	��880��5H      $	��100��5I      $��0,1,0,-1q�6!    J� Effect 5K      3  -System.Windows.Media.Effects.DropShadowEffect  5L         ShadowDepth$ 2Q�6#      Opacity$	 0.2Q�63      
BlurRadius$ 3Q�6A   5N      �� 5P   
   -   5        $ 
FotoPerfil��5P      $
��Left=�6%   $��	22,8,0,12q�6@   $��80��6S   $��80��6^   $	 50��6j   ��5Q      �� 5R      -   5        Img�� �� ImageSource$5 /blank-profile-picture-973460_1280-1-705x705.png��5R   *    j� Stretch$
 Fill=�6h    5T        5U      $ 3Q�6#      Color$ Black��63   $	 0.2Q�6A   $ 5Q�6O   5W      �� 5X   
   -   5         ��Name$ 	NomeAluno��5X      $��Nome do aluno��5Y      $	��Top=�5Z      $
��Left=�5[      $��
116,36,0,0q�5\      $��24(�5]      $��Century Gothic)�5^      ���#003964$	��565��5_   "   �� 5`   
   -   5        $ 	Aprovacao��5`      $��Aprovado��6'   
��� � �$��20(�6J   $	��Top=�5a      $
��Left=�6,   $��
116,62,0,0q�6G   $��Century Gothic)�5b      �� 5c   
   -   5         ��Name$ BtnVerPerfil��5c      $	��110��5d      $��30��5e      $��Century Gothic)�5f      $��16(�5g      ���#003964
�������$��Right=�5j      $��Center=�5k      $��
Ver perfil��5l      $��
0,35,33,35q�6"   #���  66   6]   5o      5p      