   M S B A M L   `   `   `  ????Q  MEindOpdr_DD1_TutaiTran, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:EindOpdr_DD1_TutaiTranEindOpdr_DD1_TutaiTran  5   	   +    %EindOpdr_DD1_TutaiTran.CustomerWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:EindOpdr_DD1_TutaiTran     5   	     ? Title$  CustomerWindow??5   	   $	??450??6    $	??400??6-    ? WindowStartupLocation$ CenterScreen=?69   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $??50 ?6   ?? 5      $??1* ?6   ?? 5      $??50 ?6    ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      $??1* ?6   ?? 5      $??2* ?6   ?? 5      $
??0.5* ?6   ?? 5      $??1* ?6   .+?5   
   ?? $??5??6   $??6??6$   $
??Fill=?65   $????C:\Users\tutai\OneDrive\Bureaublad\Summa\SD2C\Desktop development\DDV1\Eindopdr\EindOpdr_DD1_TutaiTran\EindOpdr_DD1_TutaiTran\assets\beach.png??6D   ?? 5   
   $??2??6   $??1??6"   .+?5      ??  ?? Orientation$ 
Horizontal=?6   $??60??62   .+?5      ?? $
??Name??6   $??18(?6'   
???????$
??Bold"?6O   ?? 5      $	??150??6   $??40??6'    ? DataContext 63   ?? *NewCustomer+??6W   ?? *CustomerName+5      5      ?? 5    
   $??Create Costumer??6   $??1??6*   $??1??67   $??Center=?6G   $??Center=?6b   $??25(?6?   $
??Bold"?6?   
???????6?   ?? 5!   
   -   5        $??1??5!      $??3??6!   $??Create Customer??6.   
???????$??25(?6[   
??? ? ? ? 	Resources 5"       ?? 
TargetType ?? Property	 ?? Value??%_   '??       ?? 5#      " ??6   .?5$      ??  ?@??CornerRadius$	 15??65   5%      5&      5'      5+      5,      