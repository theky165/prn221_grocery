   M S B A M L   `   `   `  ����  SalesWPFApp    SalesWPFApp.Dashboard   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  	Dashboard��5   	   $	��450��6   $	��800��6(    � WindowStartupLocation$ CenterScreen=�64    � 	Resources 5	      ��%    5
      .��5      �� .��5   
   � $��0,0,0,0q�6   $	��700��6     � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      o� $
��Left=�6   
���� ��$��0 0 0 0q�6B   $	��Top=�6S   $	��800��6m   $��1��6{   .@�5      m� -   5        $
��Bold"�5      $��	Dashboard��6-   $
��Left=�6@   6x   m� 5      -   5        $
��Bold"�5      $��Account��6-   $
��Left=�6>   6t   m� 5      -   5        $
��Bold"�5      $��Order��6-   $
��Left=�6<   6t   m� 5      -   5        $
��Bold"�5      $��Product��6-   $
��Left=�6>   6v   5      �� 5      $��	0,50,0,10q�6   $��2��6,    �� Orientation$ 
Horizontal=�69   $��Center=�6R   .+�5      �� $��0 0 10 0q�6   $��Start Order Date��6*   (  "System.Windows.Controls.DatePicker  5      -   5        $��dpStartDate��5   =   $
��80px��6   $��	0 0 0 180q�6*   6=   �� 5      $��	50 0 10 0q�6   $��End Order Date��6+     5      -   5        $��	dpEndDate��5   >   $
��80px��6   $��	0 0 0 180q�6+   6>   �� 5      -   5        $��	btnSearch��5   8   $��80��6   $��
50 0 0 180q�6$   .��6a   Search6i   5      �� 5      $��Center=�6   $ 
Horizontal=�66   $��3��6O   $��	0 120 0 0q�6\   .+�5      #  MaterialDesignThemes.Wpf.Card  $	��200��6&   $��20q�62   $��0q�6>   ���#462C43 !  PrimaryHueDarkForegroundBrush#���   6_   .��5       �  5!      �� 5"      $
��Auto �6,   �� 5#      $
��Auto �6,   �� 5$      $
��Auto �6,   .+�5&      �� $��0��6$   $��
16,16,16,4q�61    $  MaterialDesignHeadline5TextBlock#��[ 6E   ��6   �� *
totalOrder+�� 5'      $��1��6$      MaterialDesignLightSeparator#��[ 61   �� 5(      $��2��6$   $��	16,0,16,8q�61   $
��Left=�6D   $��Center=�6_      MaterialDesignBody2TextBlock#��[ 5)   $   $��Total Order��6Z   �� 5*      $��2��6%   $��	16,0,16,8q�62   $��Right=�6E   $ 
Horizontal=�6a   5+      5,      5-        5.      $	��200��6&   $��20q�62   $��0q�6>   ���#462C43#���   6_   .��5/      �  50      �� 51      $
��Auto �6,   �� 52      $
��Auto �6,   �� 53      $
��Auto �6,   .+�55      �� $��0��6$   $��
16,16,16,4q�61   #��[ 6E   ��6   �� *totalProduct+�� 56      $��1��6$   #��[ 61   �� 57      $��2��6$   $��	16,0,16,8q�61   $
��Left=�6D   $��Center=�6_   #��[ 58   $   $��Total Product��6Z   �� 59      $��2��6%   $��	16,0,16,8q�62   $��Right=�6E   $ 
Horizontal=�6a   5:      5;      5<        5=      $	��200��6&   $��20q�62   $��0q�6>   ���#462C43#���   6_   .��5>      �  5?      �� 5@      $
��Auto �6,   �� 5A      $
��Auto �6,   �� 5B      $
��Auto �6,   .+�5D      �� $��0��6$   $��
16,16,16,4q�61   #��[ 6E   ��6   �� *totalAccount+�� 5E      $��1��6$   #��[ 61   �� 5F      $��2��6$   $��	16,0,16,8q�61   $
��Left=�6D   $��Center=�6_   #��[ 5G   $   $��Total Account��6Z   �� 5H      $��2��6%   $��	16,0,16,8q�62   $��Right=�6E   $ 
Horizontal=�6a   5I      5J      5K      5L      5M      5N      5O      