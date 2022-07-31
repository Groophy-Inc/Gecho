# GECHO

Gecho helps you write colorful texts in one line with low ms guarantee. 


Note: 
	**Because of cmd's rules, you must enclose the string in double quotes for the command to work properly.**

AUTHOR: 
	Gecho has been written by Groophy Lifefor and helped by MBausson. \
	Discord: Groophy#1966
	

### Syntax:
```
	call gecho "<COLORS> TEXT"

	call gecho "This is a <r>Red<gn>Green<gray>Grey<Bk>Black<B>Blue"
```

### Where:
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
	
	\- call gecho <bgbk>black backgrounded text

        <bg#??????> = Custom color by hex (E.G.)
                                        \- call gecho <bg#BC8F8F>hello

      External

        +log              Enable the log mode.
        -log              Enable the log mode.

        /L:<filename>     Save log file
``` 

## Demonstration
In the Gecho plugin, you can write colorful texts in one line without rewriting the command multiple times. We can use Gecho either by writing the color name before the text in angular brackets or writing the code of the respected color. Below, we will demonstrate the flexibility of the plugin with the provided example.

### Writing the name of color

<!-- wp:code -->
<pre class="wp-block-code"><code>gecho "this is &lt;red&gt;red and &lt;blue&gt;blue&lt;nl&gt;this is &lt;green&gt;green and &lt;magenta&gt;magenta"</code></pre>
<!-- /wp:code -->

![image](https://user-images.githubusercontent.com/82807654/176985623-b030f02d-2725-4ae5-b722-5b35dfec5019.png)

### Writing the code of the color
`gecho "this is <r>red and <b>blue<nl>this is <gn>green and <dk>darkyellow"`

![image](https://user-images.githubusercontent.com/82807654/176985698-1564a383-8cfa-49d4-8183-b24481924a8d.png)

```
gecho  "--- Everything at oneline<nl>
	<red>red
	<#B0171F>,Indian red(#B0171F)
	<-80-white>high opacity(80) 
	<-50-white>Half opacity(50)
	<-20-white> less opacity(20),
    <-/>
    	<bg#BC8F8F>rosybrown hex(#BC8F8F)
    	<bgred>just red
   <bg/>
   <nl>
   	<+*>Bold<nl>
	<+~>Italic<nl>
	<+_>Underlined<nl>
	<+:>Inverted<nl>
	<+->StrikeThrough<nl>
	<+^>Overlined<nl>
	<+$https://www.google.com>CTRL + Click me<!$> for open google" 
```
**Space for readable, if you copy text, output will be different!**

![ever3](https://user-images.githubusercontent.com/77299279/182014626-2fca6a39-4ffa-4810-9bf0-7184305d8f5a.png)



#### Article- https://batch-man.com/write-colorful-text-in-one-line/
#### Video- https://youtu.be/R7kHVFEgjRg

#BeHappy #ThinkNo
