   M S B A M L   `   `   `  ����M  ISystem, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089M3clr-namespace:System.ComponentModel;assembly=SystemSystem.ComponentModel  5   	   B >Wpflab6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Wpflab6Wpflab6 5   	      Wpflab6.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dthrd3clr-namespace:System.ComponentModel;assembly=System     5   	   'localclr-namespace:Wpflab6     5   	     � Title$  Function��5	   	   $	��350��6   $	��500��6'    � 	Resources 5
      ,   &System.ComponentModel.BackgroundWorker 
  worker   WorkerReportsProgress  test �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius��%U  &	        &	 ,       5   
   -   5         . 5       �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $��ButtonBorder��6!   $ 10��65   $��1q�6G   
�������
�������._�5      �� #��z��6/   $��Center=�6S   $��Center=�6p   5      5      5      5      5      .��5      �  � RowDefinitions 5    
   �� 5!      $
��auto �6   �� 5"      $
��Auto �6   .+�5$   
   �� $��	Progress:��6   $��16(�6$   $��Bottom=�62   $��Center=�5%      $��30��64   $��150,44,171,113q�5&      $��1��6(   $��Verdana)�65   � 5'   
   -   5        	 �Name$	 ProgressBar��5'      $��1��6+   
 � Minimum$
 0Q�68    � Maximum$	 100Q�5(       � Value$ 0Q�6$   $��30��5)      $��10,97,30,54q�6"   ���	#FF8383B467   �� 5*   
   -   5         ��Name$ Start1��5*      $��1��6!   $��Calculate:Dispatcher��5+      $��45��5,      $��Verdana)�6   $	��Top=�5-      #��[ 6)   $��20,185,300,-38q�6G   5.      �� 5/   
   -   5        $ Start2��5/      $��1��6!   $ ��Calculate:BackgroundWorker��6.   $��45��50      $��Verdana)�6   $	��Top=�51      #��[ 52      $��253,185,44,-35q�6/   53      �� 54   
   -   5        $
 Stop��54      $
��Stop��6   $��34��55      $��Verdana)�6   $	��Top=�56      $��
388,7,30,0q�6)    J� RenderTransformOrigin$ 15,30&�57   #   �� 58   
   -   5        $ Settings��58      $��Setting��6#   $��30��59      $	��Top=�5:      $��Verdana)�6)   #��[ 5;      $��20,10,397,0q�6/   5<      ��5>   
   �� 5?      ��5A      �  � Offset$
 0.00Q�6#    � Color$	 Red��61   � 5B      $
 0.50Q�6#   $ Indigo��61   � 5C      $
 1.00Q�6#   $ Violet��61   5E      5H      5I      