   M S B A M L   `   `   `  ????S  ODevEmporium.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:DevEmporium.Presentation.ViewsDevEmporium.Presentation.Views  5      .    (DevEmporium.Presentation.Views.LoginView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:DevEmporium.Presentation.Views     5      .??5
      ??   ?? CornerRadius$  20??6   ._?5   
   ?? $  20??6   $??5q?5       J? Opacity$
 0.95Q?5      ??5      ?? 5       ?? 
StartPoint$	 0,0&?6&    ?? EndPoint$	 1,1&?67   .??5      ?  ? Color$ #202B31??6#    ? Offset$ 0Q?63   ? 5      $ #2C3C44??6#   $
 0.75Q?63   5      ._?5      ?  ? RowDefinitions 5      ?? 5      $??30 ?6$   ?? 5      .+?5      ?  ? ColumnDefinitions 5      ?? 5      ?? 5      $??35 ?6+   ?? 5      $??35 ?6+   .+?5      ?? $??Log In??6    ???#DAE2E7$??10(?5!       $??
Montserrat)?5"       $??0??5#       $??Center=?5$       $??	5,-25,0,0q?5%       5&      ?? 5'      $	??350??6   $??2??5(       ?? Orientation$ Vertical=?5)      $??0,35,0,0q?5*      $??Center=?5+      .+?5,      ?? $ 
Horizontal=?6!   $??center=?6:   .+?5-      ?? $??/Images/binary-code.png??6    $??50??6A   	 ?? BitmapScalingMode$	 HighQuality=?6L   ?? 5.      
?????? $??20??6=   ?? 5/      $??DevEmporium??6$   $??Center=?50   $   $??38(?51   $   ???#DAE2E7$??0,0,0,10q?53   $   $??Gadugi)?66   54      ?? 55      
?????? $??0??69   ?? 57      $/??)Shop smarter, code better at DevEmporium.??6    $??Center=?58   $   $??16(?59   $   ???#DAE2E7$??	10,0,0,10q?5;   $   
 ?? TextAlignment$
 Justify=?5<   $   $??Gadugi)?6<   ?? 5=      
?????? $??40??69   ?? 5>      $??0,0,0,0q?6!   $??Center=?5?   !   .+?5@      ?? $??Username??6$   $??Stretch=?5A   (   $??12(?5B   (   ???#DAE2E7$??0,0,0,10q?5D   (   $
 Justify=?5E   $   $??Leelawadee UI)?6<   ?? 5F      $ 
Horizontal=?6%   .+?5G      ?? $??/Images/user.png??6$   $??20??6>   ?? 5H      
?????? 6(   ?? 5I      -   5         ??Name$ txtUser??5I   &   $	??200??5J   !   $??13(?5K   !   $??Medium"?5L   !   
?????? 
??????? ?? 
CaretBrush
 ?????
????? ?$??0,0,0,2q?5Q   !   $??Center=?5R   !   $??0,5,0,0q?5S   !   $??28??62   .??6?   5T      5U      ?? 5V      
?????? $??25??6=   ?? 5W      $??Password??6$   $??Stretch=?5X   $   $??12(?5Y   $   ???#DAE2E7$??0,0,0,10q?5[   $   $
 Justify=?5\   $   $??Leelawadee UI)?6<   ?? 5]      $ 
Horizontal=?6%   .+?5^      ?? $??/Images/lock.png??6$   $??20??6>   $	 HighQuality=?6J   ?? 5_      
?????? 6(   G? 5a      -   5         G?Name$ txtPassword??5a   *   $	??200??5b   !   $??13(?5c   !   $??Medium"?5d   !   
?????? 
??????? G? 
CaretBrush
 ?????
????? ?$??0,0,0,2q?5i   !   $??Center=?5j   !   $??0,5,0,0q?5k   !   $??28??62   5l      5m      ?? 5n      
?????? $??30??6=   ?? 5r      -   5         ??Name$ btnLogin??5r   !   ???#DAE2E7$??Log In??5t      $??14(?5u      $
??Bold"?5v      
???   ?$??
Montserrat)?5x       ? Cursor$
 Hand??5y      $??1??5z      ??5|      ?? 5}   "    ?? 
TargetType" ??6(   .?5~   &   ??  ?? Property ? ?? ?? Value
 ??  ?6C    ?? Triggers 5   &   P? 5?   *    P? Property ?@J?IsMouseOver P? Value$
 true??6I   . ?5?   .   ??  ? ??
 ? ???6K   5?   +   5?   #   ??5?      ?? 5?   "    ?? 
TargetType" ??62   .R?5?   &   ?? $	??150??6-   $??28??69   $  14??5?   -   #??z??5?   -   ._?5?   *   ?? $??Center=?6;   $??Center=?5?   ?   5?   '   5?   #   5?      ?? 5?      
?????? $??05??6=   ?? 5?      $ 
Horizontal=?6%   $??Center=?5?   %   .+?5?      ?? $??Forgot Password???6(   ???#DAE2E7$??10(?5?   (   ?? 5?      
?????? $??15??6A   ?? 5?      -   5        $ resetPasswordBtn??5?   %   ???#DAE2E7$??Reset??5?      $??10(?5?      $
??Bold"?5?      
???????$??
Montserrat)?5?      $
 Hand??5?      $??1??5?      $??	-10 0 0 0q?5?   %   ??5?   "   ?? 5?   &   " ??66   .R?5?   *   ?? $??50??61   $??15??6<   $  14??5?   )   
?????? ._?5?   .   ?? $??Center=?6?   $??Center=?5?   ?   5?   +   5?   '   5?      5?      ?? 5?      
?????? $??15??6=   ?? 5?      $ 
Horizontal=?6%   $??Center=?5?   %   .+?5?      ?? $??Don't Have an Account???6(   ???#DAE2E7$??10(?5?   (   ?? 5?      
?????? $??15??6A   ?? 5?      -   5        $ createAccountButton??5?   %   ???#DAE2E7$??Create??5?   %   $??10(?5?   %   $
??Bold"?5?   %   
???????$??
Montserrat)?5?   %   $
 Hand??5?   %   $??1??5?   %   $??	-15 0 0 0q?5?   %   ??5?   "   ?? 5?   &   " ??66   .R?5?   *   ?? $??50??61   $??15??6<   $  14??5?   )   
?????? ._?5?   .   ?? $??Center=?6?   $??Center=?5?   ?   5?   +   5?   '   5?      5?      ?? 5?      
?????? $??15??6=   5?      5?      5?      5?      5?      5?      