   M S B A M L   `   `   `  ����C  ?JobStack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:JobStackJobStack  5      !    JobStack.TAlunosCoordenador   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:JobStack     5      ���	#FFD9EBFB  � 	Resources  5         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1 �� 
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
   " ��6%   .�5      ��  �@�FocusVisualStyle8   61   �� 5        � ��8  6+   �� 5!       � ��8  6,   �� 5"       � ��# � ��6+   �� 5#       � ��$ 0q�60   �� 5$       � ��$ Center=�6;   �� 5%       � ��$ Center=�69   �� 5&       � ��$ 1q�6(   �� 5'       � �� 5(      �� 5)      " ��6&   .R�5*      �� $ border��6!   $	 10��61   #��z��6C   #��z��6o   #��z��6�    . ._�5+      �� $
 contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5,       5-      P� 5.       �@��IsDefaulted . . �5/   "   �� $ border��6@   # � ��6T    � ��50      P� 51       �@J�IsMouseOver . . �52   "   �� $ border��6?    � �� �#2973AA6S   �� 53   "   $ border��6@    � �� �#2973AA6T   54      P� 55       � �� . . �56   "   �� $ border��6?    � �� �#67A8D86S   �� 57   "   $ border��6@    � �� �#67A8D86T   58      P� 59       � {� .  . �5:   "   �� $ border��6?   8   � ��6S   �� 5;   "   $ border��6@   8   � ��6T   �� 5<   "   $ contentPresenter��6K   8   � ��6i   5=      5?      5A      5B      5C      .��5D      � .+�5E   
   �� $	��404��5F      $��50��5G      $
��Left=�5H      $	��Top=�5I      $��ALUNOS CADASTRADOS��5J      $��35(�5K      $��Century Gothic Bold)�5L      ���#003964$��	30,30,0,0q�5M   -   �� 5O   
   -   5         ��Name$ BtnNovoAluno��5O      $	��120��5P      $��30��5Q      $��Right=�5R      $	��Top=�5S      $��
Novo aluno��5T      $��Century Gothic)�5U      $��16(�5V      $��0,44.497,30.5,0q�5W      ���#003964
�������#��� 
 5Y   $   6K   � 5[   
   -   5         �Name$ Lista��5[      $��31.5,85.5,31.5,28.5q�5\      $	��526��5]      $	��891��6$   $��Center=�5^      $��Center=�5_      .+�5`      �� -   5         ��Name$ FundoGridAlunos��5`       �� RadiusX$ 10��5a       �� RadiusY$ 10��5b      
�������$��2��5c   )    J� Effect 5e      3  -System.Windows.Media.Effects.DropShadowEffect  5f         ShadowDepth$ 3Q�6'      Color$ Black��67      Opacity$	 0.2Q�6E      
BlurRadius$ 5Q�6S   5h      �� 5i      -   5         ��Name$ SVAlunos��5i      $��Right=�5j      $��Center=�5k      $	��890��5l      $��526.5��5m       J� RenderTransformOrigin$	 0,0&�6*   $��0,-0.25q�6F   z�5n      V� 5o      .~�5p      �� �� 5q       �� AngleY$ 0Q�6(   �� 5r      T� 5s       T� Y$ 0Q�6-   5t      .��5v      �� -   5         ��Name$ SPAlunos��5v       �� Orientation$ Vertical=�5w   !   $	��870��5x      $��0��5y      $��	10,10,0,0q�5z   !   $	��Top=�5{   !   $
��Left=�5|   !   5~      5      5�      5�      5�      