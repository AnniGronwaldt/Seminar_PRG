using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[,] track = {
                {"Player:","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-"},
                {"Lewis:","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-"},
                {"Max:","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-"},
                {"Nico:","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-"},
            };

            Random rnd = new Random();
            int x = rnd.Next(1, 8);
            int y = rnd.Next(1, 8);

            if (x == 0)
            {
                x = 1;
            }
            if (y == 0)
            {
                y = 1;
            }
            if (x > y)
            {
                x = 1;
            }
            if (x == y)
            {
                y = 7;
            }


            Console.WriteLine("Welcome to the Racing Simulator. Here are the rules. Read them carefully!");

            Console.WriteLine("You can choose your speed from " + x + " to " + y + " However!! If you choose your speed to be below 4, you might get a double speed boost... on the other hand, if your speed is faster than 4, you can end up with a speed that equals 2 less than your chosen speed.");
            bool blbuvzdor1 = false;
            int speed = Convert.ToInt32(Console.ReadLine());
            while (blbuvzdor1 == false)
            {

                if (speed > y || speed < x)
                {
                    Console.WriteLine("You can choose your speed from " + x + " to " + y + " However!! If you choose your speed to be below 4, you might get a double speed boost... on the other hand, if your speed is faster than 4, you can end up with a speed that equals 2 less than your chosen speed.");
                    speed = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    blbuvzdor1 = true;
                }

            }

            Console.WriteLine("Now, choose your symbol");
            string playerSymbol = Console.ReadLine();

            Random l = new Random();
            Random m = new Random();
            Random n = new Random();

            Vehicle npc = new Vehicle(l.Next(x, y), "L");
            Vehicle npc2 = new Vehicle(m.Next(x, y), "M");
            Vehicle npc3 = new Vehicle(n.Next(x, y), "N");

            Console.WriteLine("Now, everything is ready for your race to start! Press any key to start the game");

            Vehicle player = new Vehicle(speed, playerSymbol);


            //GAMEPLAY STARTS

            bool winnerPresent = false;

            while (winnerPresent == false)
            {
                for (int j = speed; j > 0; j++)
                {
                    track[1 + j, 1] = playerSymbol;
                    Console.Write(track);
                    Console.ReadKey();
                }

                for (int k = l.Next(x, y); k > 0; k++)
                {
                    track[2 + k, 2] = "L";
                    Console.Write(track);
                    Console.ReadKey();
                }

                for (int q = m.Next(x, y); q > 0; q++)
                {
                    track[2 + q, 3] = "M";
                    Console.Write(track);
                    Console.ReadKey();
                }

                for (int r = n.Next(x, y); r > 0; r++)
                {
                    track[2 + r, 4] = "N";
                    Console.Write(track);
                    Console.ReadKey();
                }

                bool playerWin = false;
                bool nPCWin = false;

                if (track[15, 1] == playerSymbol)
                {
                    playerWin = true;
                }
                else if (track[15, 2] == "L")
                {
                    nPCWin = true;
                }
                else if (track[15, 3] == "M")
                {
                    nPCWin = true;
                }
                else if (track[15, 4] == "N")
                {
                    nPCWin = true;
                }


                if (playerWin = true)
                {
                    if (nPCWin = true)
                    {
                        Console.WriteLine("It seems its a tie!");
                        Console.ReadKey();
                    }
                    else if (nPCWin = false)
                    {
                        Console.WriteLine("Congratulations, you won the race!");
                        Console.ReadKey();
                    }

                    winnerPresent = true;
                    break;
                }
                else if (nPCWin = true)
                {
                    if (playerWin = true)
                    {
                        Console.WriteLine("It seems its a tie!");
                        Console.ReadKey();
                    }
                    else if (playerWin = false)
                    {
                        Console.WriteLine("Unfortunately, you have lost :(");
                        Console.ReadKey();
                    }

                    winnerPresent = true;
                    break;

                }


                
            }
               
            
        }
    }
}

