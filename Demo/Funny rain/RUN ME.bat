gecho RAIN!! 1000

REM 100 is tick delay so lower is faster (TICK DELAY IS NOT MILISECOND or SECOND)

pause




REM string[] lines = File.ReadAllLines("rainn.txt");
REM string[] reverse = Enumerable.Reverse(lines).ToArray();
REM int tick = 300;
REM if (args.Length == 2)
REM {
REM     tick = Convert.ToInt32(args[1]);
REM }
REM Console.WriteLine("Colored foreground and background Tick: " + tick.ToString() + "\r\n");
REM for (int p = 0; p < 15000; p++)
REM {
REM     for (int i = 0; i < lines.Length; i++)
REM     {
REM         string splitted2 = lines[i].Split('#')[1].Substring(0, 6);
REM         string splittedrev = reverse[i].Split('#')[1].Substring(0, 6);
REM         Console.Write("╬".Color("#" + splitted2).Background(splittedrev));
REM         var sw = Stopwatch.StartNew();
REM         while (sw.ElapsedTicks < tick) { }
REM     }
REM }