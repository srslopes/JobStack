   M S B A M L   `   `   `  ����C  ?JobStack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:JobStackJobStack  5   	       JobStack.TLogin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:JobStack     5   	     � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$
 None=�6?    � AllowsTransparency . 
������  � Title$ TLogin��5	      $
��1000��6   $	��960��6"   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��1.5* �6   .+�5   
   �� ���#F4F7FF �� CornerRadius$ 	0 10 10 0��6&   $��356,0,0,-40q�6?   $��2��6T   ._�5      �� $��Bottom=�6   $��
10,0,10,10q�64   $��1��6H   $	��532��6X   4  .System.Windows.Automation.AutomationProperties   Name$ 
textoEmail��6e   .+�5      �� $��Entre em sua conta��6      
tituloText#��[  66   $��50��6Z   �� 5      $��Insira o seu email��6    J� Opacity$	 0.8Q�66   $��20 30 20 30q�6D     
normalText#��[ 6Y   $��29��6}   �� 5      -   5         ��Name$ CondicaoEmail��5      $��email��63   $	 0.8Q�6@   $��20 30 20 30q�6N   #��[ 6c   $��29��6�   $ CondicaoEmail��6�   �� 5      -   5        	 ��Name$	 
campoEmail��5      $��E-mail��6.   $��Century Gothic)�6<   $��18(�6X   $	��400��6f   $��25��6r   $
��78,0q�6~   �� 5      $��Insira a sua senha��6   $	 0.8Q�66   $��20 30 20 30q�6D   #��[ 6Y   $��28.246��6}   G� 5      -   5        
 G�Name$
 
campoSenha��5      $	��400��62   $��25��6>   $��Century Gothic)�6J   $��18(�6f   �� 5      -   5         ��Name$
 erro��5      $
��Left=�6)   $��38��6D   $��	166,0,0,0q�6P   $	��200��6c    J� RenderTransformOrigin$ -0.755,4.053&�6o    �� 
IsReadOnly . $
 erro��6�   �� 5      $��Entrar��6    	 botao#��[ 6*   $��193,0,190,70q�6I   $��75��6_   $
��Auto��6k   5      5      �� 5   
   $ 	10 0 0 10��6   $��	0,0,0,-40q�6*   ��5       �� 5!       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5"      �  � Color$ #002495��6#    � Offset$ 0Q�63   � 5#      $ #6B8CF6��6#   $ 1Q�63   5$      ._�5&      �� $��10,238,10,246.75q�6   $ ��logo-versao-3-ajustada.png��6.   5'      �� 5)   
   -   5         ��Name$ botaoFechar��5)      $��Fechar��6&   $��1��67   $
��Left=�6G   $��22��6b   $��501,568,0,0q�6n   $	��Top=�6�   $��47��6�   6�   5*      5.      