   M S B A M L   `   `   `  ����B  >raikhan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:raikhanraikhan  5   	       raikhan.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:raikhan     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      � ���	#FF874B4B � ColumnDefinitions 5
   
   �� 5      $
��228* �6   �� 5      $
��289* �6   .+�5   
   �� $
��Left=�6   $��34��6+   $��0,18,0,0q�67   $	��Top=�6I   $	��158��6a   $��1��6m   �� 5   
   $��2��6   $��85,12,74,254q�6$   $��img_fonts.png��6:   $
��Fill=�6Q    J� OpacityMask 5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5      $ 	#FFEE6B6B��6#   $ 1Q�65   5      5      �� 5   
   -   5         ��Name$ textBoxUser��5      $
��Left=�6'   $��33��6B   $��	49,68,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��128��6�   $��1��6�   ���	#FFD6A0A06�   �� 5   
   $��LOGIN��6   $
��Left=�6    $��29��6;   $��
138,70,0,0q�6G   $	��Top=�6[   $��89��6s   ���	#FFECB8B86~   �� 5   
   $��PASSWORD��6   $
��Left=�6#   $��29��6>   $��140,113,0,0q�6J   $	��Top=�6_   $��88��6w   ���	#FFFFBDBD6�   �� 5   
   -   5        	 ��Name$	 LOG_IN1��5      $��LOG IN��6"   $
��Left=�63   $��34��6N   $��
68,182,0,0q�6Z   $	��Top=�6n   $	��122��6�   $��1��6�   ���	#FFD8A7A7���	#FFDA9A9A$��Showcard Gothic)�6�   �� 5   
   -   5        $
	 EXIT��5      $
��EXIT��6   $
��Left=�6.   $��34��6I   $��
86,182,0,0q�6U   $	��Top=�6i   $	��123��6�   ���	#FFF1EEEE���	#FF0A0909
���   �$��Showcard Gothic)�6�   G� 5   
   -   5        
 G�Name$
 
passBoxPwd��5      $
��Left=�6*   $��
48,111,0,0q�6E   $	��Top=�6Y   $	��127��6q   $��34��6}   $��1��6�   ���	#FFD6A5A56�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtGrid��5      $
��Left=�6<   $	��101��6W   $��10,221,0,-3q�6d   $	��Top=�6y   $	��497��6�   $��2��6�   ��6#   �� 6�   5      5       