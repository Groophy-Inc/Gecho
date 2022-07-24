
# Gecho - by Groophy
## Description
This program can Gecho helps you write colorful texts in one line with low ms guarantee. 

Author: Groophy Lifefor and helped by MBausson and WilliamRagstad. 

## Usage
Syntax: 
```
	call gecho "<COLORS> TEXT"

	call gecho "This is a <r>Red<gn>Green<gray>Grey<Bk>Black<B>Blue"
```

Note: \
	**Because of cmd's rules, you must enclose the string in double quotes for the command to work properly.**

Where:
```
      ForeGround

        <Black> = Black(bk)       <Gray> = Gray(g)
        <Blue> = Blue(b)          <DarkBlue> = Dark Blue(db)
        <Green> = Green(gn)       <DarkCyan>  = Dark Cyan(dc)
        <Cyan> = Cyan(c)          <DarkGray> = Dark Gray(dgy)
        <Red> = Red(r)            <DarkGreen> = Dark Green(dgn)
        <White> = White(w)        <DarkMagenta> = Dark Magenta(dm)
        <Yellow> = Yellow(y)      <DarkRed> = Dark Red(dr)
        <Magenta> = Magenta(m)    <DarkYellow> = Dark Yellow(dy)
        </> = Reset Color(white) 
        
        <#??????> = Custom color by hex (E.G.)
                                        \- call gecho <#BC8F8F>hello

        <nl> = NewLine without reset color
        <-/> = Reset Opacity     

        <-value-> = Opacity (E.G.)
                            \- call gecho <-50-#BC8F8F>hello

        <+*> = Bold Text          <+~> = Italic Text
        <+_> = Underlined Text    <+:> = Inverted Text
        <+-> = StrikeThrough Text <+^> = Overlined Text
        <+$?????...> = HyperLink (Clickable link for new console)


          Disable

        <!*> = Bold Text          <!~> = Italic Text
        <!_> = Underlined Text    <!:> = Inverted Text
        <!-> = StrikeThrough Text <!^> = Overlined Text
        <!$> = Disable HyperLink

      BackGround

        <bgBlack> = Black(bk)       <bgGray> = Gray(g)
        <bgBlue> = Blue(b)          <bgDarkBlue> = Dark Blue(db)
        <bgGreen> = Green(gn)       <bgDarkCyan>  = Dark Cyan(dc)
        <bgCyan> = Cyan(c)          <bgDarkGray> = Dark Gray(dgy)
        <bgRed> = Red(r)            <bgDarkGreen> = Dark Green(dgn)
        <bgWhite> = White(w)        <bgDarkMagenta> = Dark Magenta(dm)
        <bgYellow> = Yellow(y)      <bgDarkRed> = Dark Red(dr)
        <bgMagenta> = Magenta(m)    <bgDarkYellow> = Dark Yellow(dy)
        <bg/> = Reset Color(white)


        <bg#??????> = Custom color by hex (E.G.)
                                        \- call gecho <bg#BC8F8F>hello

      External

        +log              Enable the log mode.
        -log              Enable the log mode.

        /L:<filename>     Save log file
``` 



www.batch-man.com
