   M S B A M L   `   `   `  ����L  HCustomerManager 1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CustomerManager_1.ViewsCustomerManager_1.Views  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      7    1CustomerManager_1.Views.UserControls.MenuDataView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:CustomerManager_1.Views     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      3system&clr-namespace:System;assembly=mscorlib  5      -   5          >�Name$  _window��5
       � DataContext 5      ��    Locator �� Source# [   �� Path$
 Menu�.��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          	FoodsGrid#��[ 5      $��0,0,0,0q�6�      
IsReadOnly . ��66   �� *	MenuFoods+   Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header 5      )  #MaterialDesignThemes.Wpf.DialogHost  5      -   5           
Identifier$ DeleteMenuDialog��5         DialogTheme$
 Dark=�5      	   CloseOnClickAway	 . 
   DialogContent
 5      �� 5   "   $	��600��6-   $	��388��69   .+�5   &   �� $%��את בטוחה שאת רוצה��60   $��
60,100,0,0q�6I   $��Center=�6]   $
��Bold"�6x   $��48(�6�   �� 5   &   $,��&למחוק את התפריט קוצי?��60   $��30,0,0,0q�6M   $��Center=�6_   $
��Bold"�6z   $��48(�6�   �� 5   *    �� Orientation$ 
Horizontal=�65   $��1��6N   $��Stretch=�6[   .+�5   *   �� $
��לא��61   $
��Left=�6>   $	��100��5    1   $��75��6=   $��28(�6I   $��Bottom=�5!   1   $��12,75,480,0q�5"   1      CloseDialogCommand#��Z 5#   1   ��5$   .   ��5%   2   	False��6H   5'   +   �� 5)   *   $
��כן��61   $��Right=�6>   $	��100��5*   1   $��75��6=   $��28(�6I   $��Bottom=�5+   1   $��
-160,0,0,0q�5,   1    $  MaterialDesignFlatAccentBgButton#��[ 5-   1   #��Z 5.   1   ��5/   .   ��50   2   True��6G   52   +   54   +   55   '   .��57      ��    OpenDialogCommand#��Z 6%     Remove.Background#��[ 6f   ��58   "   �� 59   &   $ 
Horizontal=�61   .+�5:   *   �� $��מחק תפריט��64   '  !MaterialDesignThemes.Wpf.PackIcon  5;   *      Kind$ 
NoteRemove=�6B    ! PrimaryHueDarkForegroundBrush#��[ 6T   5<   '   5>      5?         CellTemplate 5A      �� 5B      .R�5C      �� #��[ 6�   $��50��6�   ��6%   �� *#!DataContext.RemoveFromMenuCommand+ �� ElementName$ _window����6p   �� ��5D   "     5E   &   $ CloseCircle=�6>   #��[ 6Q   5G      5H      5K      5M      �� 5O   
   -   5         ��Name$ Save_btn��5O      $��Right=�6#   $��Bottom=�6?   $��20q�6Z   ��6f   �� *SaveMenuCommand+.��5P      �� $ 
Horizontal=�6   .+�5Q        $ 	AddCircle=�6*   $��Center=�6;   #��[ 6X   �� 5R      $��שמור תפריט��6   #��[ 6.   5S      5T      5W      5X      