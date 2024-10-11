using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
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
            Console.WriteLine("S kolika čísly chcete pracovat? (1/2/3)");
            string number = Convert.ToString(Console.ReadLine());
            if (number == "1")
            {
                Console.WriteLine("Napište číslo");
                double solo = Convert.ToDouble(Console.ReadLine());
                double result = 0;
                Console.WriteLine("Napište, kterou operaci chcete provést (mocnina, mocnina3, odmocnina, sinus, cosinus, tangens)");
                string operation2 = Convert.ToString(Console.ReadLine());
                if (operation2 == "mocnina")
                {
                    result = solo * solo;
                    Console.WriteLine("Druhá mocnina je " + result);
                }
                else if (operation2 == "mocnina3")
                {
                    result = solo * solo * solo;
                    Console.WriteLine("Třetí mocnina je " + result);
                }
                else if (operation2 == "odmocnina")
                {
                    result = Math.Sqrt(solo);
                    Console.WriteLine("Odmocnina je " + result);
                }
                else if (operation2 == "sinus")
                {
                    result = Math.Sin(solo);
                    Console.WriteLine("Sinus je " + result);
                }
                else if (operation2 == "cosinus")
                {
                    result = Math.Cos(solo);
                    Console.WriteLine("Cosinus je " + result);
                }
                else if (operation2 == "tangens")
                {
                    result = Math.Tan(solo);
                    Console.WriteLine("Tangens je " + result);
                }
                else
                {
                    Console.WriteLine("???");
                }
            }
            else if (number == "2")
            {
                Console.WriteLine("zadejte první číslo");
                double number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("zadejte druhé číslo");
                double number2 = Convert.ToDouble(Console.ReadLine()); ;
                Console.WriteLine("Napište, kterou operaci chcete provést (soucet, rozdil, soucin, podil)");
                string operation = Convert.ToString(Console.ReadLine());
                double result = 0;
                if (operation == "soucet")
                {
                    result = number1 + number2;
                    Console.WriteLine("Součet dvou čísel je " + result);
                }
                else if (operation == "rozdil")
                {
                    result = number1 - number2;
                    Console.WriteLine("Součet dvou čísel je " + result);
                }

                else if (operation == "soucin")
                {
                    result = number1 * number2;
                    Console.WriteLine("Součin dvou čísel je " + result);
                }
                else if (operation == "podil")
                {
                    if (number2 == 0)
                    {
                        Console.WriteLine("Nulou nelze dělit! >:(");
                    }
                    else
                    {
                        result = number1 / number2;
                        Console.WriteLine("Podil dvou čísel je " + result);
                    }
                }
                else
                {
                    Console.WriteLine("Tohle není operace");
                }
            }
            else if (number == "3")
                {
                    Console.WriteLine("zadejte první číslo");
                    double number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("zadejte druhé číslo");
                    double number2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("zadejte třetí číslo");
                    double number3 = Convert.ToDouble(Console.ReadLine());
                    double result = 0;
                    Console.WriteLine("Napište, kterou operaci chcete provést (soucet, rozdil, soucin, podil, diskriminant");
                    string operation3 = Convert.ToString(Console.ReadLine());
                if (operation3 == "soucet")
                {
                    result = number1 + number2 + number3;
                    Console.WriteLine("Součet je " + result);
                }
                else if (operation3 == "rozdil")
                {
                    result = number1 - number2 - number3;
                    Console.WriteLine("Rozdíl je " + result);
                }
                else if (operation3 == "soucin")
                {
                    result = number1 * number2 * number3;
                    Console.WriteLine("Součin tří čísel je " + result);
                }
                else if (operation3 == "podil")
                {
                    if (number2 == 0 | number3 == 0)
                    {
                        Console.WriteLine("Nulou nelze dělit! >:(");
                    }
                    else
                    {
                        result = number1 / number2 / number3;
                        Console.WriteLine("Podil tří čísel je " + result);
                    }
                }
                else
                {
                    Console.WriteLine("Co to sem píšeš?!");
                }
                }
            else
            {
                while (number != "1" | number != "2" | number != "3")
                {
                    Console.WriteLine("S kolika čísly chcete pracovat? (1/2/3)");
                    number = Convert.ToString(Console.ReadLine());
                    if (number == "1" | number == "2" | number == "3")
                    {
                        if (number == "1")
                        {
                            Console.WriteLine("Napište číslo");
                            double solo = Convert.ToDouble(Console.ReadLine());
                            double result = 0;
                            Console.WriteLine("Napište, kterou operaci chcete provést (mocnina, mocnina3, odmocnina, sinus, cosinus, tangens)");
                            string operation2 = Convert.ToString(Console.ReadLine());
                            if (operation2 == "mocnina")
                            {
                                result = solo * solo;
                                Console.WriteLine("Druhá mocnina je " + result);
                            }
                            else if (operation2 == "mocnina3")
                            {
                                result = solo * solo * solo;
                                Console.WriteLine("Třetí mocnina je " + result);
                            }
                            else if (operation2 == "odmocnina")
                            {
                                result = Math.Sqrt(solo);
                                Console.WriteLine("Odmocnina je " + result);
                            }
                            else if (operation2 == "sinus")
                            {
                                result = Math.Sin(solo);
                                Console.WriteLine("Sinus je " + result);
                            }
                            else if (operation2 == "cosinus")
                            {
                                result = Math.Cos(solo);
                                Console.WriteLine("Cosinus je " + result);
                            }
                            else if (operation2 == "tangens")
                            {
                                result = Math.Tan(solo);
                                Console.WriteLine("Tangens je " + result);
                            }
                            else
                            {
                                Console.WriteLine("???");
                            }
                        }
                        else if (number == "2")
                        {
                            Console.WriteLine("zadejte první číslo");
                            double number1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("zadejte druhé číslo");
                            double number2 = Convert.ToDouble(Console.ReadLine()); ;
                            Console.WriteLine("Napište, kterou operaci chcete provést (soucet, rozdil, soucin, podil)");
                            string operation = Convert.ToString(Console.ReadLine());
                            double result = 0;
                            if (operation == "soucet")
                            {
                                result = number1 + number2;
                                Console.WriteLine("Součet dvou čísel je " + result);
                            }
                            else if (operation == "rozdil")
                            {
                                result = number1 - number2;
                                Console.WriteLine("Součet dvou čísel je " + result);
                            }

                            else if (operation == "soucin")
                            {
                                result = number1 * number2;
                                Console.WriteLine("Součin dvou čísel je " + result);
                            }
                            else if (operation == "podil")
                            {
                                if (number2 == 0)
                                {
                                    Console.WriteLine("Nulou nelze dělit! >:(");
                                }
                                else
                                {
                                    result = number1 / number2;
                                    Console.WriteLine("Podil dvou čísel je " + result);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Tohle není operace");
                            }
                        }
                        else if (number == "3")
                        {
                            Console.WriteLine("zadejte první číslo");
                            double number1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("zadejte druhé číslo");
                            double number2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("zadejte třetí číslo");
                            double number3 = Convert.ToDouble(Console.ReadLine());
                            double result = 0;
                            Console.WriteLine("Napište, kterou operaci chcete provést (soucet, rozdil, soucin, podil, diskriminant");
                            string operation3 = Convert.ToString(Console.ReadLine());
                            if (operation3 == "soucet")
                            {
                                result = number1 + number2 + number3;
                                Console.WriteLine("Součet je " + result);
                            }
                            else if (operation3 == "rozdil")
                            {
                                result = number1 - number2 - number3;
                                Console.WriteLine("Rozdíl je " + result);
                            }
                            else if (operation3 == "soucin")
                            {
                                result = number1 * number2 * number3;
                                Console.WriteLine("Součin tří čísel je " + result);
                            }
                            else if (operation3 == "podil")
                            {
                                if (number2 == 0 | number3 == 0)
                                {
                                    Console.WriteLine("Nulou nelze dělit! >:(");
                                }
                                else
                                {
                                    result = number1 / number2 / number3;
                                    Console.WriteLine("Podil tří čísel je " + result);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Co to sem píšeš?!");
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}