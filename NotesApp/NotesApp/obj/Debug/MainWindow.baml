   M S B A M L   `   `   `  ????C  ?NotesApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:NotesAppNotesApp  5   	       NotesApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:NotesApp     5   	      OrangeWindow#??[  5        ? Title$  
MainWindow??5   	   $	??600??6   $	??500??6)    ? WindowStyle$
 None=?65   $	??600??6H   $	??500??6X   '  !System.Windows.Shell.WindowChrome   WindowChrome 5
        5   
      CornerRadius$ 0??6      GlassFrameThickness$ 0q?6(      ResizeBorderThickness$ 6q?6@      CaptionHeight$ 30Q?6Z   .??5      ? $??5q?6    ? RowDefinitions 5   
   ?? 5      ?? 5      $	??100 ?6   .+?5   
   ?? -   5         ??Name$ 	NotesList??5   W   
?????? $??0q?6,   	 ?? SelectionMode$	 Single=?6@   $??Center=?6j   $??Disabled=?6?   $??2??6?   $??0,0,0.333,0.333q?6?   ??5      ?? 5      .R?5      ? 
 ? Orientation$
 
Horizontal=?6    $??Center=?69   5      ??5      ?? 5      .R?5      ??  ?? CornerRadius$ 5??6     OrangeBrush#??[ 6.   $??10q?6X   $	??200??6d   $	??200??6q    J? Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q?6/      Opacity$	 0.5Q?6?      ShadowDepth$ 0Q?6M   ._?5      ?? .+?5      ?? $??Center=?6>   ??6(   ?? *Date+6>   ?? 5       $??Center=?6@   $
??Bold"?6]   ??6(   ?? *Header+6]   5!      5"      5#      5%      ? 5'   
   $??1??6    ? ColumnDefinitions 5(      ?? 5)      $
??1.5* ?6#   ?? 5*      $??* ?6#   ?? 5+      $
??1.5* ?6#   .+?5-      ?? $??Удалить??67   $??5q?6I     PurpleButton#??[ 6T   ??6   ?? *DeleteCommand+6T   ?? 5.      $??1??64   $??5q?6D     
PlusButton#??[ 6O   ??6   ?? *
AddCommand+6O   ?? 5/      $??2??66   $??5q?6F   $??Открыть??6Q   #??[ 6c   ??6   ?? *CheckCommand+6c   50      51      52      