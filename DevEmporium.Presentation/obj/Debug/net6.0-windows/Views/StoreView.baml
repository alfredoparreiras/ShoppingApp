   M S B A M L   `   `   `  ????S  ODevEmporium.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:DevEmporium.Presentation.ViewsDevEmporium.Presentation.Views  5   	   .    (DevEmporium.Presentation.Views.StoreView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:DevEmporium.Presentation.Views     5   	   -   5          ? Title$  Store??5   	   $	??900??5	   	   $
??1000??5
   	    ? WindowStyle$
 None=?5   	    ? 
ResizeMode$ 	CanResize=?5   	    ? WindowStartupLocation$ CenterScreen=?5   	    ? AllowsTransparency$
 true??5   	   
?????? .??5      ??  ?? CornerRadius$ 20??6   ._?5   
   ?? $ 20??6   $??5q?5      ??5      ?? 5       ?? 
StartPoint$	 0,0&?6&    ?? EndPoint$	 1,1&?67   .??5      ?  ? Color$ #DAE2E7??6#   	 ? Offset$	 0Q?63   ? 5      $ #202B31??6#   $
	 0.74Q?63   ? 5      $ #DAE2E7??6#   $	 1Q?63   5      ??5      ?? 5      $	 0,0&?6&   $	 1,1&?67   .??5      ? $ #202B31??6#   $	 0Q?63   ? 5       $ #2C3C44??6#   $
	 0.75Q?63   5!      ._?5#      ? 
 ? RowDefinitions
 5$      ?? 5%      $??30 ?6$   ?? 5&      .+?5(      ?  ? ColumnDefinitions 5)      ?? 5*      ?? 5+      $??35 ?6+   ?? 5,      $??35 ?6+   .+?5.      ?? $??DevEmporium??6    ???#DAE2E7$??10(?50       $??
Montserrat)?51       $??0??52       $??Center=?53       $??10,0,0,0q?54       ?? 56      -   5         ??Name$ btnMinimize??56      ???#202B31$??-??58      $??18(?59      $
??Bold"?5:      
???????$??
Montserrat)?5<       ? Cursor$
 Hand??5=      $??1??5>      ??5@      ?? 5A       ?? 
TargetType" ??6$   .?5B   "   ??  ?? Property ? ?? ?? Value
 ??  ?6?    ?? Triggers 5C   "   P? 5D   &    P? Property ?@J?IsMouseOver P? Value$
 true??6E   . ?5E   *   ??  ? ??
 ? ???6G   5F   '   5H      ??5J      ?? 5K       ?? 
TargetType" ??6.   .R?5L   "   ?? $??24??6)   $??24??64   $ 9??5M   )   #??z??5N   )   ._?5O   &   ?? $??Center=?67   $??Center=?5P   8   5Q   #   5R      5T      ?? 5V      -   5        $ btnClose??5V      ???#202B31$??10(?5X      $??SemiBold"?5Y      $??X??5Z      
???????$??
Montserrat)?5\      $
 Hand??5]      $??2??5^      ??5`      ?? 5a      " ??6$   .?5b   "   ??  ? ??
 ??  ?6?    5c   "   P? 5d   &    ?@J?IsMouseOver$
 true??6E   . ?5e   *   ??  ? ??
 ? ???6G   5f   '   5h      ??5j      ?? 5k      " ??6.   .R?5l   "   ?? $??24??6)   $??24??64   $ 9??5m   )   #??z??5n   )   ._?5o   &   ?? $??Center=?67   $??Center=?5p   8   5q   #   5r      5t      5u      ?? 5v      $??1??6   .+?5w      ]? .+?5x      &   System.Windows.Controls.DataGrid  -   5          Name$ storeViewPanel??5?      $	??450??5x   #   $	??500??5y      $
??Left=?5z      $??	40 20 0 0q?5{         AutoGenerateColumns$ False??5|         SelectionMode$ Single=?5}      ??5~      ??  ?? Path$ Products? ?? SelectedItem 5      ?? $ SelectedProduct?   Columns 5?      0  *System.Windows.Controls.DataGridTextColumn  5?   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Product??65      Width5  /System.Windows.Controls.DataGridLengthConverter$	 145 5?   1      
IsReadOnly$
 True??5?   1   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5?   1   ?? $
 Name? ?? UpdateSourceTrigger$ PropertyChanged=?  5?   "   $ Price??65   $	 120 5?   1   $
 True??5?   1    5?   1   ?? $ Price?$ PropertyChanged=?  5?   "   $ Category??65   $	 180 5?   1   $
 True??5?   1    5?   1   ?? $ Category?$ PropertyChanged=?5?      0   *DevEmporium.Presentation.Views.ProductView  5?      -   5           Name$  productViewPanel??5?   -   $??
0 20 -20 0q?5?   ,   $y?	Collapsed=?5?   -   5?      ?? 5?      .+?5?      -   'DevEmporium.Presentation.Views.CartView  -   5        !  Name$! cartViewPanel??5?   *   $y?	Collapsed=?5?   *   5?      5?      5?      5?      5?      5?      