using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {
            // Välkommen till programmet och huvudmenyn
            Console.WriteLine("Välkommen! Ni är nu på huvudmenyn och kommer navigera genom att skriva in siffror för olika funktioner.");
            bool isRunning = true;

            // Huvudmeny som körs tills användaren väljer att avsluta programmet
            while (isRunning)
            {
                Console.WriteLine("\n=== HUVUDMENY ===");
                Console.WriteLine("0: Avsluta programmet");
                Console.WriteLine("1: Biljettpris - Ungdom eller pensionär");
                Console.WriteLine("2: Räkna ut totalpris");
                Console.WriteLine("3: Upprepa tio gånger");
                Console.WriteLine("4: Det tredje ordet");
                switch (Console.ReadLine())
                {
                    case "0":
                        Console.WriteLine("Programmet avslutas.");
                        isRunning = false;
                        break;
                    case "1":
                        Console.WriteLine("Biljettpris - Ungdom eller pensionär.");
                        ShowTicketPrice();
                        break;
                    case "2":
                        Console.WriteLine("Räkna ut totalpris.");
                        CountTotalPrice();
                        break;
                    case "3":
                        Console.WriteLine("Upprepa tio gånger.");
                        RepeatTenTimes();
                        break;
                    case "4":
                        Console.WriteLine("Det tredje ordet.");
                        GetThirdWord();
                        break;
                    default:
                        Console.WriteLine("Felaktig input, försök igen.");
                        break;
                }       
            }
        }

        // Menyval 1: Ungdom eller pensionär
        private static void ShowTicketPrice()
        {
            // Visa pris baserat på ålder användaren anger
            Console.WriteLine("Var vänlig och ange din ålder:");
            string ageInput = Console.ReadLine()!;

            if (int.TryParse(ageInput, out int age))
            {
                if (age < 5 || age > 100)
                {
                    Console.WriteLine("Gratis inträde!");
                }
                else if (age < 20)
                {
                    Console.WriteLine("Ungdomspris: 80kr");
                }
                else if (age > 64)
                {
                    Console.WriteLine("Pensionärspris: 90kr");
                }
                else
                {
                    Console.WriteLine("Standardpris: 120kr");
                }
            }
            else
            {
                Console.WriteLine("Felaktig ålder, var vänlig försök igen.");
            }
        }

        // Menyval 2: Räkna ut totalpris
        private static void CountTotalPrice()
        {
            // Räkna ut totalpris baserat på antal personer och deras ålder utifrån användarens input
            Console.Write("Hur många är ni i sällskapet? ");
            string countInput = Console.ReadLine()!;

            if (int.TryParse(countInput, out int count) && count > 0)
            {
                int totalPrice = 0;

                for (int i = 1; i <= count; i++)
                {
                    Console.Write($"Ange ålder för person {i} i siffror: ");
                    string ageInput = Console.ReadLine()!;

                    if (int.TryParse(ageInput, out int age))
                    {
                        if (age < 5 || age > 100)
                        {
                            totalPrice += 0;
                        }
                        else if (age < 20)
                        {
                            totalPrice += 80;
                        }
                        else if (age > 64)
                        {
                            totalPrice += 90;
                        }
                        else
                        {
                            totalPrice += 120;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Felaktig ålder, räknas som standardpris (120kr).");
                        totalPrice += 120;
                    }
                }
                Console.WriteLine($"\nAntal personer: {count}");
                Console.WriteLine($"Totalkostnad: {totalPrice}kr");
            }
            else
            {
                Console.WriteLine("Felaktigt antal, försök igen!");
            }

        }

        // Menyval 3: Upprepa tio gånger
        private static void RepeatTenTimes()
        {
            // Användaren anger en text som ska upprepas 10 gånger
            Console.WriteLine("Var vänlig ange en text som programmet ska upprepa:");
            string textToRepeat = Console.ReadLine()!;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}: {textToRepeat} ");
            }
        }

        // Menyval 4: Det tredje ordet
        private static void GetThirdWord()
        {
            // Användaren anger en mening och programmet skriver ut det tredje ordet
            Console.WriteLine("Var vänlig ange en mening med minst tre ord: ");
            string input = Console.ReadLine()!;
            var words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (words.Length >= 3)
            {
                Console.WriteLine($"Det tredje ordet är: {words[2]}");
            }
            else
            {
                Console.WriteLine("Det finns inget tredje ord.");
            }            
        }
    }
}