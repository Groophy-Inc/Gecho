@echo off

echo --- Color name based (gecho "This is a <r>Red<gn>Green<gray>Grey<Bk>Black</>reset<B>Blue")

gecho "This is a <r>Red<gn>Green<gray>Grey<Bk>Black</>reset<B>Blue"

echo.

echo --- hex based (gecho "this <#B0171F>Indian red color")

gecho "this <#B0171F>Indian red color"

echo.

echo --- MultiLine in oneline (gecho "hello<nl>world")

gecho "hello<nl>world"

echo.

echo --- Custom opacity (gecho "<-80-white>high opacity <-50-white>Half opacity<-20-white> less opacity") 

gecho "<-80-white>high opacity <-50-white>Half opacity<-20-white> less opacity"

echo.

echo --- Custom modify (gecho "<+*>bold text<!*>, bold disabled<+~> Italic enabled.")

gecho "<+*>bold text<!*>, bold disabled<+~> Italic enabled."
gecho "<+*>Bold"
gecho "<+~>Italic"
gecho "<+_>Underlined"
gecho "<+:>Inverted"
gecho "<+->StrikeThrough"
gecho "<+^>Overlined"
gecho "<+$https://www.google.com>CTRL + Click me<!$> for open google"

echo.

echo --- Custom Hex and color based BackGround (gecho "<bg#BC8F8F>rosybrown hex<bgred>just red")

gecho "<bg#BC8F8F>rosybrown hex<bgred>just red"

echo.

echo --- Everything at oneline

gecho "<red>red<#B0171F>,Indian red(#B0171F)<-80-white>high opacity(80) <-50-white>Half opacity(50)<-20-white> less opacity(20),<-/><bg#BC8F8F>rosybrown hex(#BC8F8F)<bgred>just red<bg/><nl><+*>Bold<nl><+~>Italic<nl><+_>Underlined<nl><+:>Inverted<nl><+->StrikeThrough<nl><+^>Overlined<nl><+$https://www.google.com>CTRL + Click me<!$> for open google"

pause>nul