   M S B A M L   `   `   `  ����L  HCustomerManager 1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:CustomerManager_1.Views.DashBoardControls)CustomerManager_1.Views.DashBoardControls  5      9    3CustomerManager_1.Views.DashBoardControls.DashBoard   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Ilocal7clr-namespace:CustomerManager_1.Views.DashBoardControls     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      b ^GalaSoft.MvvmLight.Platform, Version=5.4.1.0, Culture=neutral, PublicKeyToken=5f873c45e98af8a1.command http://www.galasoft.ch/mvvmlight  5	        � DataContext  5      ��    Locator �� Source# [   �� Path$ 	DashBoard�.  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      /  )GalaSoft.MvvmLight.Command.EventToCommand     Command 6%   �� *LoadedCommand+ �� Mode$ OneWay=�5      .��5      � ��5   
   �� 5       �� 
StartPoint$	 1,0&�6"   	 �� EndPoint$		 0,1&�63   .��5      � 
 � Color$
 #957DAD��6    � Offset$	 1.0Q�6/   � 5      $
  #D291BC��6   $	 0.5Q�60   � 5      $
 #E0BBE4��6   $	 0.0Q�6/   5       � ColumnDefinitions 5   
   �� 5       $��* �6   �� 5!      $��* �6   �� 5"      $��* �6     � RowDefinitions 5$   
   �� 5%      $��* �6   �� 5&      $��* �6   �� 5'      $��* �6   �� 5(      $��* �6   �� 5)      $��* �6   .+�5+   
   #  MaterialDesignThemes.Wpf.Card  ���#2E333A � ToolTip$ Total Customers��5,      $��	16,0,16,0q�5-      $��16q�5.      $	��600��5/      .��50      � .+�51      �� .+�52      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ AccountGroup=�6.     DataGrid.Hover.Foreground#��[ 6B   $��70��6z   $��70��6�   53      �� 54       �� Orientation$ 
Horizontal=�6   $��Right=�66   $��Bottom=�6R   .+�55      �� $��70(�6A   
���������6    �� *CustomersNumber+ J� Effect 56      3  -System.Windows.Media.Effects.DropShadowEffect  57         
BlurRadius$ 5Q�6/      ShadowDepth$ 1Q�58   /      	Direction$	 -90Q�59   /      Color$ White��5:   /   5<      5=      5>      5?        5@   
   ���#2E333A$ Total Food Menus��5A      $��	16,0,16,0q�5B      $��16q�5C      $��1��5D      $	��600��5E      .��5F      � .+�5G      �� .+�5H        $ BookOpenPageVariant=�6.   #��[ 6I   $��70��6�   $��70��6�   5I      �� 5K      $ 
Horizontal=�6   $��Right=�66   $��Bottom=�6R   .+�5L      �� $��70(�6=   
���������6    �� *MenusNumber+ 5M        5N      $ 5Q�6/   $ 1Q�5O   /   $	 -90Q�5P   /   $ White��5Q   /   5S      5T      5U      5W        5X   
   ���#2E333A$ Total Training Programs��5Y      $��	16,0,16,0q�5Z      $��16q�5[      $��2��5\      $	��600��5]      .��5_      � .+�5`      �� .+�5a        $ Dumbbell=�6.   #��[ 6>   $��70��6v   $��70��6�   5b      �� 5d      $ 
Horizontal=�6   $��Right=�66   $��Bottom=�6R   .+�5e      �� $��70(�6I   
���������6    �� *TrainingProgramssNumber+ 5f        5g      $ 5Q�6/   $ 1Q�5h   /   $	 -90Q�5i   /   $ White��5j   /   5l      5m      5n      5p        5r   
   ���#2E333A$ Total Training Programs��5s      $��	16,0,16,0q�5t      $��16q�5u      $��2��5v      $	��600��5w      .��5y      � .+�5z      �� .+�5{        $ Dumbbell=�6.   #��[ 6>   $��70��6v   $��70��6�   5|      �� 5~      $ 
Horizontal=�6   $��Right=�66   $��Bottom=�6R   .+�5      �� $��70(�6I   
���������6    �� *TrainingProgramssNumber+ 5�        5�      $ 5Q�6/   $ 1Q�5�   /   $	 -90Q�5�   /   $ White��5�   /   5�      5�      5�      5�      �� 5�   
   $��1��6   $��3��6#   $��3��67   $ Vertical=�6H   $��Center=�6_   $��Stretch=�6z   .+�5�        $��16q�6"   $��64q�5�   "   $��2��5�   "   $	��350��5�   "   $
��1050��5�   "   ��5�      �� 5�       �� ImageSource$&  /Assets/DashBoard_BackGround.png��6!   .��5�      �� .+�5�      �� $��/Assets/Logo.png��6    $	��300��6:   $	��300��6F    J� SnapsToDevicePixels . 6S   5�      5�      5�      �� 5�   
   $��4��6   $��5��6"   $��Bottom=�66   .+�5�   
   2  ,MaterialDesignThemes.Wpf.MaterialDateDisplay  $��Bottom=�6-   $��10q�6H   '	  !MaterialDesignThemes.Wpf.Snackbar	  5�   
   *
  $MaterialDesignThemes.Wpf.ThemeAssist 
  Theme$
 Dark=�6"    	  IsActive . $��
0,-80,0,20q�5�   "    	  Message. 5�      .  (MaterialDesignThemes.Wpf.SnackbarMessage  .��5�      �� $ 
Horizontal=�6   $��Center=�66   $��Center=�6S   .+�5�      �� $��30��6    $��30��6+   $��Right=�67   $��5��6S   $��Bottom=�6`    � Cursor$
 Hand��6{   $��	0,0,-20,0q�6�   �� 5�   
   $0��*https://www.facebook.com/idan.barzilay.52/?�6    �� TextDecorations$
 None{�5�      .�6*   .�5�      �� $��/Assets/facebook.png��6   64   5�       5�      _� 5�      $/��)https://www.facebook.com/idan.barzilay.52��6&   5�      5�      �� 5�      $��25��6    $��25��6+   $��Right=�67   $
 Hand��6S   $��	110,0,0,0q�6a   �� 5�   
   $�� ?�6   $
 None{�5�      .�6*   .�5�      �� $��/Assets/instagram.png��6   65   5�       5�      _� 5�      $/��)https://www.facebook.com/idan.barzilay.52��6&   5�      5�      �� 5�      $��30��6    $��30��6+   $��Right=�67   $��5��6S   $��Bottom=�6`   $
 Hand��6{   $��	100,0,0,0q�6�   �� 5�   
   $"��https://github.com/IdanBarzI?�6   $
 None{�5�      .�6*   .�5�      �� $��/Assets/Github.png��6   62   5�       5�      _� 5�      $"��https://github.com/IdanBarzI��6&   5�      5�      5�      5�      5�      5�      5�      5�      