using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    internal class Vehicle
    {
        private string symbol;
        public int speed;

        public Vehicle(int speed, string symbol)
        {
            this.symbol = symbol;

            if (speed < 4)
            {
                Random rnd = new Random();
                int picker1 = rnd.Next(1, 5);
                if (picker1 == 2)
                {
                    this.speed = speed * 2;
                    Console.WriteLine("Look! You've got DRS!");
                }
                else
                {
                    this.speed = speed;
                } 
            }
            
            if (speed > 4)
            {
                Random rnd = new Random();
                int picker2 = rnd.Next(1, 5);
                if (picker2 == 3)
                {
                    this.speed = speed - 2;
                    Console.WriteLine("Oops! Seems like your tires are not in the best shape!");
                }
                else
                {
                    this.speed = speed;
                }

            }
        }



    }
}
