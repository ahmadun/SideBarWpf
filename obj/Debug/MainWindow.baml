   M S B A M L   `   `   `  ????J  FMenuWithSubMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MenuWithSubMenuMenuWithSubMenu  5   	   M+clr-namespace:MenuWithSubMenu.CustomControlMenuWithSubMenu.CustomControl  65        MenuWithSubMenu.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:MenuWithSubMenu     5   	   Ecustomcontrol+clr-namespace:MenuWithSubMenu.CustomControl     65     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      -   5         ??Name$ col_side??5      ?? 5       ? RowDefinitions 5   
   ?? 5      $??40 ?6   ?? 5      $??* ?6   .+?5   
   ]? 
????ح?6   ]? 5   
   $??1??6   
????ح?.+?5      ?? -   5        $??40??5      $
??Left=?6   $??5q?67   $??0q?6B   5      :   4MenuWithSubMenu.CustomControl.MenuWithSubMenuControl  5   
   -   5          Name$ 
pn_sidebar??5   /   $??1??6C      HasIcon .    SubMenuPadding$ 15,0,0,0q?6_    ? 5   
   -   5          ?Name$ MainWindowFrame??5      $??1??6)   $??1??66     ? NavigationUIVisibility$ Hidden=?6F   5      5      