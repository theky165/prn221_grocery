   M S B A M L   `   `   `  ����  SalesWPFApp    SalesWPFApp.WindowMembers   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  WindowOrders��5   	   $	��720��6   $	��800��6+    � WindowStartupLocation$ CenterScreen=�67    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       '�� H     �� 5
   
   " ��6   .�5      ��  � ��$ 16(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 16(�6)   �� 5       � ��$ 25��6'   5      5      .��5      �� .��5   
   � $��0,0,0,0q�6   $	��700��6     � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      o� $
��Left=�6   ���#fafafa
���� ��$��0 0 0 0q�6W   $	��Top=�6h   $	��800��6�   $��1��6�   $��3��6�   .@�5      m� -   5        $
��Bold"�5      $��	Dashboard��6-   $
��Left=�6@   6x   m� 5      -   5        $
��Bold"�5      $��Account��6-   $
��Left=�6>   6t   m� 5      -   5        $
��Bold"�5      $��Order��6-   $
��Left=�6<   6t   m� 5      -   5        $
��Bold"�5      $��Product��6-   $
��Left=�6>   6v   5       �� 5!      $��Right=�6    �� Orientation$ 
Horizontal=�65   $��2��6N   .+�5"      �� -   5        $��btnAdd��5"      $��Add Account��6'   $��10q�6=   6I   5#      �� 5$      -   5        $��	lvAccount��5$   $   $��3��6   $	��800��65   $��	-8,0,-9,5q�6A   $
��Left=�6T   ��5%      �� 5&      " ��6   .�5'      ��  � ��$ 	25 10 0 0q�63   5(       �� View 5*      �� 5+      .P�5,      �� $��
Account ID��6)   	 �� DisplayMemberBinding	 6=   �� 
 �� Path$
 id��� 5-      $��Email��6)   	 68   �� $
 username��� 5.      $
��Type��6)   	 67   �� $

 type��� 5/       �� CellTemplate 50      �� 51   "   .R�52   &   �� $
��Edit��53   )   6:   54   #   56      �� 57       58      �� 59   "   .R�5:   &   �� ���#b71c1c$��Delete��5<   )   6<   5=   #   5?      5@      5B      5C      5D      5E      