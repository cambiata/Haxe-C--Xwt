mkdir bin-cs\bin\

copy Svg.dll bin-cs\bin\Svg.dll
copy Xwt.dll bin-cs\bin\Xwt.dll
copy Xwt.Gtk.dll bin-cs\bin\Xwt.Gtk.dll

cd bin-cs\

"C:\Program Files (x86)\Mono\bin\mcs"  /platform:x86 /nologo /optimize+ /debug- /unsafe- /warn:0 /out:bin/Main.exe /target:exe /main:EntryPoint__Main  /reference:System.Drawing.dll  /reference:System.Xaml.dll /reference:bin/Svg.dll /reference:bin/Xwt.dll /reference:bin/Xwt.Gtk.dll src\cs\Boot.cs src\Std.cs src\haxe\lang\Null.cs src\Array.cs src\cs\internal\Function.cs src\Type.cs src\Reflect.cs src\cs\internal\StringExt.cs src\cs\internal\Runtime.cs src\cs\Lib.cs src\cs\internal\HxObject.cs src\cs\internal\Exceptions.cs src\cs\internal\FieldLookup.cs src\Main.cs src\haxe\Log.cs