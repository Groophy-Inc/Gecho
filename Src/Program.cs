using System;
using System.IO;
using System.Diagnostics;
using System.Linq;
using ANSIConsole;

namespace Groophy.Gecho
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length > 0)
            {
                if (args[0] == "/h" || args[0] == "/?" || args[0] == "-h" || args[0] == "--help" || args[0] == "help")
                {
                    h();
                }
                else if (args[0] == "RAIN!!")
                {
                    string[] lines = File.ReadAllLines("rainn.txt");

                    string[] reverse = Enumerable.Reverse(lines).ToArray();

                    int tick = 300;

                    if (args.Length == 2)
                    {
                        tick = Convert.ToInt32(args[1]);
                    }

                    Console.WriteLine("Colored foreground and background Tick: " + tick.ToString() + "\r\n");
                    for (int p = 0; p < 15000; p++)
                    {
                        for (int i = 0; i < lines.Length; i++)
                        {
                            string splitted2 = lines[i].Split('#')[1].Substring(0, 6);

                            string splittedrev = reverse[i].Split('#')[1].Substring(0, 6);

                            Console.Write("╬".Color("#" + splitted2).Background(splittedrev));

                            var sw = Stopwatch.StartNew();
                            while (sw.ElapsedTicks < tick) { }
                        }
                    }
                }
                else
                {
                    System.Text.StringBuilder logs = new System.Text.StringBuilder();
                    bool logsave = false; string savefilename = string.Empty;
                    if (!ANSIInitializer.Init(false)) ANSIInitializer.Enabled = false;
                    ConsoleColor consoleColor = Console.ForegroundColor; Coologs c = new Coologs(false);
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    for (int i = 0; i < args.Length; i++) { if (args[i] == "-log") { c = new Coologs(false); }
                        else if (args[i] == "+log") { c = new Coologs(true); }
                        else if (args[i].ToUpper().StartsWith("/L:")) { logsave = true; savefilename = args[i].Substring(3); }
                        else { sb.Append(args[i] + " "); }} sb.Remove(sb.Length - 1, 1);
                    string[] lns = sb.ToString().Split(new[] { "<nl>" }, StringSplitOptions.None);
                    for (int i = 0; i < lns.Length; i++) { logs.Append(c.Print(lns[i])); Console.Write(Environment.NewLine); }
                    Console.ForegroundColor = consoleColor;
                    if (logsave) { File.WriteAllText(savefilename, logs.ToString()); }
                }
            }
            else
            {
                h();
            }
        }

        static void h()
        {
            Console.WriteLine(@"
THE SOFTWARE IS PROVIDED 'AS IS', WITHOUT WARRANTY OF ANY
KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE
AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
DEALINGS IN THE SOFTWARE.
This program is distributed under the following license: Apache-2.0 license
================================================================================
Apache License 2.0 - https://opensource.org/licenses/Apache-2.0
BSD 3-Clause 'New' or 'Revised' license - https://opensource.org/licenses/BSD-3-Clause
BSD 2-Clause 'Simplified' or 'FreeBSD' license - https://opensource.org/licenses/BSD-2-Clause
GNU General Public License (GPL) - https://opensource.org/licenses/gpl-license
GNU Library or 'Lesser' General Public License (LGPL) - https://opensource.org/licenses/lgpl-license
MIT license - https://opensource.org/licenses/MIT
Mozilla Public License 2.0 - https://opensource.org/licenses/MPL-2.0
Common Development and Distribution License - https://opensource.org/licenses/CDDL-1.0
Eclipse Public License version 2.0 - https://opensource.org/licenses/EPL-2.0
================================================================================
================= ABOUT THE PROGRAM =================
This program is created by Groophy at 'Cum 22.07.2022 - 10:39'
This program can _______________________________________________________
For More Visit: www.batch-man.com

Gecho helps you write colorful texts in one line with low ms guarantee. In the Gecho plugin, you can write colorful texts in one line without rewriting the command multiple times. 
We can use Gecho either by writing the color name before the text in angular brackets or writing the code of the respected color. Below, 
we will demonstrate the flexibility of the plugin with the provided examples.
Syntax: 
	call gecho" + " \"<COLORS> TEXT\"" + @"
	call gecho " + "\"This is a <r>Red<gn>Green<gray>Grey<Bk>Black<B>Blue\"" + @"
Note:
	Because of cmd's rules, you must enclose the string in double quotes for the command to work properly.
Where:
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
        
AUTHOR:
	Gecho has been written by Groophy Lifefor and helped by MBausson and WilliamRagstad.
	Discord: Groophy#1966

www.batch-man.com
#batch-man
");
        }
    }

    public class Coologs
    {
        public Coologs(bool logmode=false)
        {
            isLog = logmode;

        }

        public static bool isLog = false;
        /// <summary>
        /// Prints a text and applies foreground changes with &lt;colors&gt; tags in it.
        /// </summary>
        /// <param name="text_code">Text desired with print styling code</param>
        /// <param name="endwith">Character at the end of the print -- default is a line break</param>
        /// <example>Coologs.Print("&lt;red&gt;Red text<blue> Blue text</blue> Normal text");</example>
        /// <remarks>You can escape the character '&lt;' with '&lt;' (Example: '&lt;&lt;test&gt;'</remarks>
        public string Print(string text_code, string endwith = "\r\n")
        {
            string log = string.Empty;
            bool parsing_tag = false;
            string tag = "";
            bool isPastel = false;
            bool isPastelBg = false;
            string lastesthex = string.Empty;
            string lastesthexbg = string.Empty;
            bool isBold = false; //dolgulu
            bool isItalic = false; //eğik
            bool isUnderlined = false; //altı çizgili
            bool isInverted = false; //ters
            bool isStrikeThrough = false; //ortadan çizgili
            bool isOverlined = false; //üstü çizgili

            bool isHyperLink = false; //clickable link for new console
            string LastestHyperLink = string.Empty;


            int Opacity = 100;

            for (int i = 0; i < text_code.Length; i++)
            {
                if (parsing_tag)
                {

                    if (text_code[i] == '>')
                    {
                        parsing_tag = false;
                        tag = tag.ToLower();
                        tag = tag.Substring(1);

                        if (tag.Length == 0)
                        {
                            continue;
                        }

                        //  Check for escape character '<'
                        if (tag[0] == '<')
                        {
                            Console.Write(tag + '>');   //  We rebuild inital escaped tag because we previously remove the last '>'
                            tag = "";
                            continue;
                        }

                        //  A </> closure tag resets color
                        if (tag[0] == '/')
                        {
                            Console.ForegroundColor = ConsoleColor.Gray ;
                            isPastel = false;
                            lastesthex = "#FFFFFF";
                        }
                        else if (tag == "bg/")
                        {
                            isPastelBg = false;
                            lastesthexbg = "";
                        }
                        else if (tag == "-/")
                        {
                            Opacity = 100;
                        }
                        //  Sets desired color
                        else
                        {
                            if (tag.StartsWith("bg"))
                            {
                                string withoutbg = tag.Substring(2);
                                if (withoutbg.StartsWith("#"))
                                {
                                    isPastelBg = true;
                                    lastesthexbg = withoutbg;
                                }
                                else
                                {

                                    //  If the color code is incorrect, we don't raise any error -- just let it go
                                    string fullName = getColorHex(withoutbg);

                                    isPastelBg = true;
                                    lastesthexbg = "#" + fullName;
                                }
                            }
                            else if (tag.StartsWith("+"))
                            {
                                char prefix = tag[1];
                                if (prefix == '*')
                                {
                                    isBold = true;
                                }
                                else if (prefix == '~')
                                {
                                    isItalic = true;
                                }
                                else if (prefix == '_')
                                {
                                    isUnderlined = true;
                                }
                                else if (prefix == ':')
                                {
                                    isInverted = true;
                                }
                                else if (prefix == '-')
                                {
                                    isStrikeThrough = true;
                                }
                                else if (prefix == '^')
                                {
                                    isOverlined = true;
                                }
                                else if (prefix == '$')
                                {
                                    string link = tag.Substring(2);

                                    isHyperLink = true;
                                    LastestHyperLink = link;
                                }
                            }
                            else if (tag.StartsWith("!"))
                            {
                                char prefix = tag[1];
                                if (prefix == '*')
                                {
                                    isBold = false;
                                }
                                else if (prefix == '~')
                                {
                                    isItalic = false;
                                }
                                else if (prefix == '_')
                                {
                                    isUnderlined = false;
                                }
                                else if (prefix == ':')
                                {
                                    isInverted = false;
                                }
                                else if (prefix == '-')
                                {
                                    isStrikeThrough = false;
                                }
                                else if (prefix == '^')
                                {
                                    isOverlined = false;
                                }
                                else if (prefix == '$')
                                {
                                    isHyperLink = false;
                                    LastestHyperLink = string.Empty;
                                }
                            }
                            else
                            {
                                string lastesttag = tag;

                                string opac = "";
                                if (lastesttag.StartsWith("-"))
                                {
                                    lastesttag = lastesttag.Substring(1);
                                    for (int t = 0; t < 3; t++)
                                    {
                                        if (lastesttag[t] == '-')
                                        {
                                            break;
                                        }
                                        opac += lastesttag[t].ToString();
                                    }

                                    Opacity = Convert.ToInt32(opac);
                                    lastesttag = lastesttag.Substring(opac.Length + 1);
                                }

                                if (lastesttag.StartsWith("#"))
                                {
                                    isPastel = true;
                                    lastesthex = lastesttag;
                                }
                                else
                                {

                                    //  If the color code is incorrect, we don't raise any error -- just let it go
                                    lastesthex = "#"+getColorHex(lastesttag);
                                    isPastel = true;

                                }
                            }

                        }

                        tag = "";
                        continue;
                    }

                    tag += text_code[i];
                    continue;
                }

                if (text_code[i] == '<')
                {
                    parsing_tag = true;
                    tag += "<";
                    continue;
                }


                ANSIString text = text_code[i].ToString().Opacity(Opacity);

                if (isPastel) text = text.Color(lastesthex);

                if (isPastelBg) text = text.Background(lastesthexbg);

                if (isBold) text = text.Bold();

                if (isItalic) text = text.Italic();

                if (isUnderlined) text = text.Underlined();

                if (isInverted) text = text.Inverted();

                if (isStrikeThrough) text = text.StrikeThrough();

                if (isOverlined) text = text.Overlined();

                if (isHyperLink) text = text.SetHyperlink(LastestHyperLink);

                Console.Write(text);


                if (isLog) Console.WriteLine("\r\nText: " + text_code[i] + ", IsPastel: " + isPastel.ToString() + ", hex: " + lastesthex + ", hexbg: " + lastesthexbg + ", opacity: " + Opacity + ", tag: " + tag + ", FullText: " + text);

                log += "\r\nText: " + text_code[i] + ", IsPastel: " + isPastel.ToString() + ", hex: " + lastesthex + ", hexbg: " + lastesthexbg + ", opacity: " + Opacity + ", tag: " + tag + ", FullText: " + text + "\r\n";

            }

            //Console.Write(endwith);
            return log;
        }
        /// <summary>
        /// Returns color's int code based on its string representation
        /// </summary>
        /// <param name="code">Color's string code</param>
        /// <remarks>Returns -1 if the input doesn't match any color.</remarks>
        private static string getColor(string code) // b -> blue
        {
            if (code == "b") code = "blue";
            else if (code == "c") code = "cyan";
            else if (code == "bk") code = "black";
            else if (code == "db") code = "darkblue";
            else if (code == "dc") code = "darkcyan";
            else if (code == "dgn") code = "darkgreen";
            else if (code == "dgy") code = "darkgray";
            else if (code == "dm") code = "darkmagenta";
            else if (code == "dr") code = "darkred";
            else if (code == "dy") code = "darkyellow";
            else if (code == "gy") code = "gray";
            else if (code == "gn") code = "green";
            else if (code == "m") code = "magenta";
            else if (code == "r") code = "red";
            else if (code == "w") code = "white";
            else if (code == "y") code = "yellow";

            foreach (int i in Enum.GetValues(typeof(ConsoleColor)))
            {
                if (((ConsoleColor)i).ToString().ToLower() == code) //max 15
                {
                    return i.ToString();
                }
            }

            return "-1";
        }


        private static string gethexbycode(string code) //blue -> 0000FF
        {
            if (code == "blue") return "0000FF";
            else if (code == "cyan") return "00FFFF";
            else if (code == "black") return "000000";
            else if (code == "darkblue") return "00008B";
            else if (code == "darkcyan") return "008080";
            else if (code == "darkgreen") return "006400";
            else if (code == "darkgray") return "A9A9A9";
            else if (code == "darkmagenta") return "8B008B";
            else if (code == "darkred") return "8B0000";
            else if (code == "darkyellow") return "F6BE00";
            else if (code == "gray") return "808080";
            else if (code == "green") return "008000";
            else if (code == "magenta") return "FF00FF";
            else if (code == "red") return "FF0000";
            else if (code == "white") return "FFFFFF";
            else if (code == "yellow") return "FFFF00";
            else return "000000";
        }

        private static string getColorHex(string code) //b -> blue -> 0000FF
        {
            code = code.ToLower();
            if (code == "b") code = "blue";
            else if (code == "c") code = "cyan";
            else if (code == "bk") code = "black";
            else if (code == "db") code = "darkblue";
            else if (code == "dc") code = "darkcyan";
            else if (code == "dgn") code = "darkgreen";
            else if (code == "dgy") code = "darkgray";
            else if (code == "dm") code = "darkmagenta";
            else if (code == "dr") code = "darkred";
            else if (code == "dy") code = "darkyellow";
            else if (code == "gy") code = "gray";
            else if (code == "gn") code = "green";
            else if (code == "m") code = "magenta";
            else if (code == "r") code = "red";
            else if (code == "w") code = "white";
            else if (code == "y") code = "yellow";

            return gethexbycode(code);
        }
    }
}