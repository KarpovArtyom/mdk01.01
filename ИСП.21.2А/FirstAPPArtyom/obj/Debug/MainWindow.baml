   M S B A M L   `   `   `  ����I  EFirstAPPPolina, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FirstAPPPolinaFirstAPPPolina  5   	       FirstAPPPolina.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:FirstAPPPolina     5   	     � Title$  Главное окно��5   	   $	��600��6   $	��800��6+   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��100 �6   �� 5      $��4* �6   �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��5* �6   .+�5   
   �� $��1��6    �� Orientation$ 
Horizontal=�5      $��Center=�5      .+�5      �� $!��программа на WPF��6      TxbStyle#��[  5      �� 5      -   5        $��BtnHello��5       $��50��5      $	��150��6!   $��Приветствие��5      $��18(�5      $��5q�5      
������5!      5"      �� 5#   
   $��2��6   $��1��5$      $%��Строка состояния��5%      #��[  5&      �� 5'   
   -   5        $��
BtnPagePR2��5,      $��50��5'      $	��150��6   $!��Переход на стр2��5(      $��18(�5)      $��5q�5*      
���  ��5-      �� 5.   
   $��1��6   $ Vertical=�5/      $	��Top=�50      .+�51      �� -   5        $��
BtnPagePR3��56      $��50��51      $	��150��6!   $!��Переход на стр3��52      $��18(�53      $��5q�54      
�������57      �� 58      -   5        $��
BtnPagePR7��5=      $��50��58      $	��150��6!   $!��Переход на стр4��59      $��18(�5:      $��10q�5;      
���P��5>      5?       � 5A   
   -   5        $��FrmMain��5B      $��1��5A      $��1��6   5B      5C      5D      