using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zadejte první číslo");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("zadejte druhé číslo");
            double number2 = Convert.ToDouble(Console.ReadLine()); ;
            

            Console.WriteLine("Napište, kterou operaci chcete provést (soucet, rozdil, soucin, podil, mocnina, odmocnina)");
            string operation = Convert.ToString(Console.ReadLine());
            double result = 0;
            if (operation == "soucet")
            {
                result = number1 + number2;
                Console.WriteLine("součet dvou čísel je " + result);
            }
            else if (operation == "rozdil")
            {
                result = number1 - number2;
                Console.WriteLine("součet dvou čísel je " + result);
            }
            else if (operation == "soucin")
            {
                result = number1 * number2;
                Console.WriteLine("součin dvou čísel je " + result);
            }
            else if (operation == "podil")
            {
                if (number2 == 0)
                {
                    Console.WriteLine("Nulou nelze dělit! >:(");
                }
                else
                    result = number1 / number2;
                    Console.WriteLine("podil dvou čísel je " + result);
            }
            else if (operation == "mocnina")
            {
                Console.WriteLine("chcete mocnit první číslo? (ano/ne)");
                string mocnina = Convert.ToString(Console.ReadLine());
                if (mocnina == "ano")
                {
                    Console.WriteLine("Mocním na druhou");
                    result = number1 * number1;
                    Console.WriteLine("druhá mocnina je " + result);
                    Console.WriteLine("Chete mocnit dále? (ano/ne)");
                    string naEntou = Convert.ToString(Console.ReadLine());
                    if (naEntou == "ano")
                    {
                        double m = result * number1;
                        Console.WriteLine(m);
                        Console.WriteLine("Chete mocnit dále? (ano/ne)");
                        naEntou = Convert.ToString(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Už dost mocnění");
                    }
                }
                    else
                    {
                    Console.WriteLine("???");
                    }
                }
            else if (operation == "odmocnina")
            {

            }
            else
            {
                Console.WriteLine("Nebyla zadaná operace (zadej operaci, hajzle)");
            }

            /*
             * Rozsireni programu pro rychliky / na doma (na poradi nezalezi):
             * 1) Vypis do konzole pred nactenim kazdeho uzivatelova vstupu co po nem chces (aby vedel, co ma zadat)
             * 2) a) Kontroluj, ze uzivatel do vstupu zadal, co mel (cisla, popr. ciselnou operaci). Pokud zadal neco jineho, napis mu, co ma priste zadat a program ukoncete.
             * 2) b) To same, co a) ale misto ukonceni programu opakovane cti vstup, dokud uzivatel nezada to, co ma
             *       - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement
             * 3) Umozni uzivateli zadavat i desetinna cisla, tedy prekopej kalkulacku tak, aby umela pracovat s floaty
             */

            Console.ReadKey(); //Toto nech jako posledni radek, aby se program neukoncil ihned, ale cekal na stisk klavesy od uzivatele.
        }
    }
}
