using System;
using SchiffeVersenken.Conntroller;
using SchiffeVersenken.Data;

namespace SchiffeVersenken_Console
{
    class Program
    {
        private static ConsoleColor bg_default = Console.BackgroundColor;

        //isRunning enscheidet ob das spiel weiterläuft.
        private static bool isRunning = true;

        //Anzahl der benötgigten Treffens um zu gewinnen.
        private static int maxHits = 30;
        
        //Anzahl der maximalen Versuchen.
        private static int maxShots = 55;
        private static int firedShots = 0;
        private static int hits = 0;
 
        static void Main(string[] args)
        {
            while (isRunning)
            { 
                try
                {
                    Console.Clear();
                    StartMatch();
                    
                } catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~      Falsche Eingabe :(!   ~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~    Neues Spiel starten :)  ~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
                    Console.ReadKey();
                }
                
            }
        }

        private static void StartMatch()
        {
            Conntroller gameLogic = new Conntroller();
            Map map = gameLogic.GetMap();
            int[,] spielFeld = new Int32[10,10];
            
            while (firedShots < maxShots && hits < maxHits)
            {
                Console.WriteLine("\n\n\n\n");
                DrawMap(map);
                Console.WriteLine("_____ Treffer: " + hits + "/" + maxHits + " __________ Kanonenkugeln: " + (maxShots - firedShots) + " _____");
                int x, y;
                Console.Write("Wir brauchen die Koordinaten Kaept'n!\nX:");
                x = Int32.Parse(Console.ReadLine());
                Console.Write("Y:");
                y = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Arrrr! Feuer auf [" + x + " , " + y + "]!");
                firedShots++;
                switch (map[y, x])
                {
                    case 0:
                        map[y, x] = -2;
                        Console.WriteLine("Verfehlt!");
                        break;
                    case 1:
                        hits++;
                        map[y, x] = -1;
                        Console.WriteLine("Treffer!");
                        break;
                    case -1:
                        Console.WriteLine("Kaept'n, da hatten wir bereits getroffen...");
                        break;
                    case -2:
                        Console.WriteLine("Kaept'n, da ist immer noch nur Wasser...");
                        break;
                }
                Console.Clear();
            }
            if( hits == maxHits)
            {
                Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine(drawSmile());
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
            }
            else
            {
                Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~      NIEDERLAGE :(!   ~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("~~~~~~~~~~~~~~~~~    Vseruch aber wieder :)  ~~~~~~~~~~~~~~~~~");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
            }

        }

        private static void DrawMap(Map map)
        {
            Console.BackgroundColor = bg_default;
            Console.WriteLine("    0  1  2  3  4  5  6  7  8  9   X");
            for (int i = 0; i < map.Length; i++)
            {
                Console.BackgroundColor = bg_default;
                Console.Write(" " + i + " ");
                for (int j = 0; j < map.Height; j++)
                {
                    switch (map[i, j])
                    {
                        case -1:
                            Console.BackgroundColor = ConsoleColor.Red; break;
                        case -2:
                            Console.BackgroundColor = ConsoleColor.Blue; break;
                        default:
                            Console.BackgroundColor = ConsoleColor.Green; break;
                    }
                    Console.Write("   ");
                }
                Console.WriteLine();
            }
            Console.BackgroundColor = bg_default;
            Console.WriteLine(" Y");
        }

        private static string drawSmile()
        {
            return         @"000000000000000000000000################000000000000000000000000
                            0000000000000000000#####________________#####0000000000000000000
                            000000000000000####__________________________####000000000000000
                            0000000000000##__________________________________##0000000000000
                            0000000000###______________________________________###0000000000
                            000000000#____________________________________________#000000000
                            0000000##__________#####________________######_________##0000000
                            000000#___________#######______________########__________#000000
                            00000#___________#########____________##########__________#00000
                            0000#____________#########____________##########___________#0000
                            000#_____________#########____________##########____________#000
                            00#______________#########____________##########_____________#00
                            00#_______________#######______________########______________#00
                            0#_________________#####________________######________________#0
                            0#____________________________________________________________#0
                            0#____________________________________________________________#0
                            0#____________________________________________________________#0
                            00#______##__________________________________________##______#00
                            00#_______##________________________________________##_______#00
                            000#________###__________________________________###________#000
                            0000#__________######______________________######__________#0000
                            00000#_______________######################_______________#00000
                            000000#__________________________________________________#000000
                            0000000##______________________________________________##0000000
                            000000000#____________________________________________#000000000
                            0000000000###______________________________________###0000000000
                            0000000000000##__________________________________##0000000000000
                            000000000000000####__________________________####000000000000000
                            0000000000000000000#####________________#####0000000000000000000
                            000000000000000000000000################000000000000000000000000";
        }

        // optionale Funtion um alle Schiffe offen legen
        static void exposeShips()
        {

            Conntroller gameLogic = new Conntroller();
            Map map = gameLogic.GetMap();
            int[,] spielFeld = new Int32[10, 10];


            Console.BackgroundColor = bg_default;
            Console.WriteLine("    0  1  2  3  4  5  6  7  8  9   X");
            for (int i = 0; i < map.Length; i++)
            {
                Console.BackgroundColor = bg_default;
                Console.Write(" " + i + " ");
                for (int j = 0; j < map.Height; j++)
                {
                    switch (map[i, j])
                    {
                        case 1:
                            Console.BackgroundColor = ConsoleColor.Red; break;
                        default:
                            Console.BackgroundColor = ConsoleColor.Blue; break;
                    }
                    Console.Write("   ");
                }
                Console.WriteLine();
            }
            Console.BackgroundColor = bg_default;
            Console.WriteLine(" Y");

        }
    }
}
