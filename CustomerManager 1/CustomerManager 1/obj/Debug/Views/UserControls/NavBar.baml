   M S B A M L   `   `   `  ����L  HCustomerManager 1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:CustomerManager_1.Views.UserControls$CustomerManager_1.Views.UserControls  5      1    +CustomerManager_1.Views.UserControls.NavBar   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Dlocal2clr-namespace:CustomerManager_1.Views.UserControls     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � DataContext  5	      ��    Locator �� Source# [   �� Path$ 
Navigation�.��5
      � $��1��6   $��50��6   ��5   
   �� 5       �� 
StartPoint$	 0,1&�6"    �� EndPoint$	 1,0&�63   .��5      �  � Color$ #2E333A��6    � Offset$	 0.4Q�6/   � 5      $ #f5f5f5 ��6   $ 1Q�60   5       � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6    �� 5      $��* �6   �� 5      $
��auto �6    .+�5   
   �� '  !System.Windows.Shell.WindowChrome   IsHitTestVisibleInChrome . $��Center=�6C   $��Right=�6^   	 �� Orientation$	 
Horizontal=�6z   .+�5      �� -   5        
 ��Name$
 NextBtn��5   !   $��50��6     MaterialDesignFlatButton#��[ 62   
������  � ToolTip$ Back to last page��6�   ���#f5f5f5��6d   �� *GoBackCommand+��5      '  !MaterialDesignThemes.Wpf.PackIcon  5         Kind$ ArrowRightCircle=�6.   5      �� 5      -   5        $
 BackBtn��5   !   $��50��6   #��[ 62   
������ $ Next To last Page��6}   ���#f5f5f5��5         5!      $ ArrowBackCircle=�6.   5#      5$      �� 5%   
   $��3��6    . $��Center=�6R   $��Right=�6m   $	 
Horizontal=�6�   .+�5'      �� $	 
Horizontal=�6   .+�5*      �� -   5        $
 LogoBtn��5*   %   $��50��6   #��[ 66   
������ $ Back to DashBoard��6�   ���#f5f5f5��6h   �� *DashBordCommand+��5+      �� 5,      $��/Assets/Logo.png��6    5.      �� 50      -   5        $
 MinimizeBtn��50   %   $��50��6   #��[ 6:   
������ $ Minimize Window��6�   ���#2E333A��51        52      $ WindowMinimize=�62   54      �� 55      -   5        $
 MaximizeBtn��55   %   $��50��6   #��[ 6:   
������ $ Maximize Window��6�   ���#2E333A��56        57      $ WindowMaximize=�62   59      �� 5:      -   5        $
 CloseBtn��5:   %   $��50��6   #��[ 67   
������ $ Exit App��6�   ���#2E333A��5;        5<      $ PresenceExit=�62   5>      5?      5@      5A      5C      