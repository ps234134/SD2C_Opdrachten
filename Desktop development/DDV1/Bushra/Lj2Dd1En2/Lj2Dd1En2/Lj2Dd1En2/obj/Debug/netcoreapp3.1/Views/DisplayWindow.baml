   M S B A M L   `   `   `  ????D  @Lj2Dd1En2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Lj2Dd1En2.ViewsLj2Dd1En2.Views  5   	   #    Lj2Dd1En2.Views.DisplayWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Lj2Dd1En2.Views     5   	     ? Title$  DisplayWindow??5   	   $	??450??6   $	??800??6,   
???? ??.??5	      ? $??20q?6   .+?5
   
   ?? ??6   ?? *Meals+ ?? SelectedItem 61   ?? *SelectedMeal+??5      ?? 5      .R?5      ? 
???   ?$	??500??6.    ? ColumnDefinitions 5      ?? 5      $
??Auto ?6/   ?? 5      .+?5      ?? $??0??6    $	??100??60   $??UniformToFill=?6<   $????C:\Users\bushr\Documents\school\Leerjaar 2\Desktop Development\Herhalingsopdrachten\Opdracht03\Lj2Dd1En2\Lj2Dd1En2\Assets\pizzeria_14.png??6T   ? 5      $??1??6   $??10, 2q?6/    ? RowDefinitions 5      ?? 5   "   $
??Auto ?60   ?? 5   "   .+?5      ? $??0??6#   $??0, 2, 0, 10q?60    5   "   ?? 5   &   $
??Auto ?67   ?? 5   &   .+?5   "   ?? $??0??6,   
???????$??14(?6f   $
??Bold"?6t   ??6<   ?? *Name+6t   ?? 5   "   $??1??6,   
???????$??Right=?6}   $??10,0,0,0q?6?   ??6<   ?? *Price+ ?? StringFormat$ € 0.00??6?   5      ?? 5       $??1??6(   
???????$
??Wrap=?6e   ??65   ?? *Description+6e   5!      5"      5#      5%      5&      5'      