   M S B A M L   `   `   `  ????C  ?NotesApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:NotesAppNotesApp  5   	       NotesApp.CheckWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:NotesApp     5   	      OrangeWindow#??[  5        ? WindowStyle$
  None=?6@    ? Title$ CheckWindow??5   	   $	??600??6   $	??500??6*   $	??600??66   $	??500??6F   '  !System.Windows.Shell.WindowChrome   WindowChrome 5
        5   
      CornerRadius$ 0??6      GlassFrameThickness$ 0q?6(      ResizeBorderThickness$ 6q?6@      CaptionHeight$ 30Q?6Z   .??5      ? $??5q?6    ? RowDefinitions 5   
   ?? 5      $	??100 ?6   ?? 5      ?? 5      $	??100 ?6   .+?5   
   ?? .+?5      ?? $(??"Введите Заголовок:??6   ?? 5      -   5         ??Name$
 text??5      	 ?? 	MaxLength$	 50??6$     OrangeTextBox#??[ 63   ?? 5      $$??Введите заметку:??6   $??0 25 0 0q?60   5      ?? 5   
   -   5        $
 desc??5      $??1??6   $		 499??6-   
 ?? TextWrapping$

 Wrap=?6=   #??[ 6Q   ? 5   
   $??2??6    ? ColumnDefinitions 5      ?? 5      $
??1.5* ?6#   ?? 5      ?? 5      $
??1.5* ?6#   .+?5       ?? -   5         ??Name$ 
BackButton??5    %   $??
Назад??6     PurpleButton#??[ 69   ?? 5!      -   5        $ 
SaveButton??5!   9   $??Сохранить??6   $??2??6)   #??[ 6M   5"      5$      5%      