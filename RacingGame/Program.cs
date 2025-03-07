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
        static void Print2DArray(string[,] arrayToPrint)
        {
            for (int i = 0; i < arrayToPrint.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToPrint.GetLength(1); j++)
                {
                    Console.Write(arrayToPrint[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

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

            Random test = new Random();

            int l = test.Next(x, y);
            int m = test.Next(x, y);
            int n = test.Next(x, y);

            Vehicle npc = new Vehicle(l, "L");
            Vehicle npc2 = new Vehicle(m, "M");
            Vehicle npc3 = new Vehicle(n, "N");

            Console.WriteLine("Now, everything is ready for your race to start! Press any key to start the game");

            Vehicle player = new Vehicle(speed, playerSymbol);


            //GAMEPLAY STARTS

            bool winnerPresent = false;

            int start = 0;


            while (winnerPresent == false)
            {
                bool playerWin = false;
                bool nPCWin = false;

                track[0, start++ + speed] = playerSymbol;
                if (start++ + speed > 15)
                {
                    playerWin = true;
                    Console.WriteLine("Congratulations, you won the race!");
                    Console.ReadKey();
                    winnerPresent = true;
                    break;
                }
                else
                {
                    Print2DArray(track);
                }
                Console.ReadKey();

                track[1, start++ + npc.speed] = "L";
                if (start++ + npc.speed > 15)
                {
                    nPCWin = true;
                    Console.WriteLine("It seems you have lost the race :(");
                    Console.ReadKey();
                    winnerPresent = true;
                    break;
                }
                else
                {
                    Print2DArray(track);
                }
                Console.ReadKey();

                track[2, start++ + npc2.speed] = "M";
                if (start++ + npc2.speed > 15)
                {
                    nPCWin = true;
                    Console.WriteLine("It seems you have lost the race :(");
                    Console.ReadKey();
                    winnerPresent = true;
                    break;
                }
                else
                {
                    Print2DArray(track);
                }
                Console.ReadKey();

                track[3, start++ + npc3.speed] = "N";
                if (start++ + npc3.speed > 15)
                {
                    nPCWin = true;
                    Console.WriteLine("It seems you have lost the race :(");
                    Console.ReadKey();
                    winnerPresent = true;
                    break;
                }
                else
                {
                    Print2DArray(track);
                }
                Console.ReadKey();

                

                if (track[0, 15] == playerSymbol)
                {
                    playerWin = true;
                    if (track[1, 15] != "-" || track[2, 15] != "-" || track[3, 15] != "-")
                    {
                        nPCWin = true;
                        Console.WriteLine("It seems its a tie!");
                        Console.ReadKey();
                        winnerPresent = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Congratulations, you won the race!");
                        Console.ReadKey();
                        winnerPresent = true;
                        break;
                    }
                }
                else if (track[1, 15] != "-" || track[2, 15] != "-" || track[3, 15] != "-")
                {
                    nPCWin = true;
                    Console.WriteLine("Unfortunately, you have lost :(");
                    Console.ReadKey();
                    winnerPresent = true;
                    break;
                }
                else
                {
                    playerWin = false;
                    nPCWin = false;
                    winnerPresent = false;
                }

                //Děkuji za trpělivost
                //Zdroje: https://stackoverflow.com/questions/2706500/how-do-i-generate-a-random-integer-in-c a battleships :)

            }

        }
    }
}

