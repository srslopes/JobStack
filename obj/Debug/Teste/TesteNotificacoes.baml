   M S B A M L   `   `   `  ����C  ?JobStack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:JobStack.TesteJobStack.Teste  5   	   &     JobStack.Teste.TesteNotificacoes   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:JobStack.Teste     5   	     � Title$  TesteNotificacoes��5   	   $	��450��6#   $	��800��60    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � .+�5   
   �� -   5         ��Name$ 
BtnSucesso��5      $��Sucesso��5      
��� � �
�������$
��Left=�5      $
��43.5��5      $��173,184.5,0,0q�5      $	��Top=�5      $	��126��5      6   �� 5   
   -   5        $ 
BtnAtencao��5      $��	Atenção��5      ���#FFC309$
��Left=�5      $
��43.5��5      $��330.5,184.5,0,0q�5      $	��Top=�5      $	��126��5      6   �� 5   
   -   5        $ BtnErro��5      $
��Erro��5      
���  ��
�������$
��Left=�5!      $
��43.5��5"      $��488,184.5,0,0q�5#      $	��Top=�5$      $	��126��5%      6   �� 5&   
   $
��Left=�6   $��88��5'      $��	18,63,0,0q�5(      $
��Wrap=�5)      $	��Top=�5*      $��16(�5+      $	��756��5,      �� 6!   $���Para mudar o texto inferior (o único mutável) das notificações para cada contexto, é preciso usar o método AtualizarMensagemSucesso/AtualizarMensagemErro/AtualizarMensagemAtencao no momento em que for chamar a notificação. ��5-      �� 6�   6
  5/      50      