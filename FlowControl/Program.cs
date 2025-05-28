using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Berätta för användaren att de har kommit till huvudmenyn och de kommer navigera genom att skriva in siffror för att testa olika funktioner.
            Console.WriteLine("Välkommen! Ni är nu på huvudmenyn och kommer navigera genom att skriva in siffror för olika funktioner.");
            // 3.Skapa en oändlig iteration, alltså något som inte tar slut innan vi säger till att den ska ta slut.Detta löser ni med att skapa en egen bool med tillhörande while-loop.
            bool isRunning = true;
            while (isRunning)
            {
                // 2.Skapa skalet till en Switch-sats som till en början har Två Cases.Ett för ”0” som stänger ner programmet och ett default som berättar att det är felaktig input.
                Console.WriteLine("\n=== HUVUDMENY ===");
                Console.WriteLine("0: Avsluta programmet");
                // 4.Bygg ut menyn med val att exekvera de övriga övningarna.
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
                    Console.WriteLine("Biljettpris - Ungdom eller pensionär");
                    ShowTicketPrice();
                    break;
                case "2":
                    Console.WriteLine("Räkna ut totalpris");
                    CountTotalPrice();
                    break;
                case "3":
                    Console.WriteLine("Upprepa tio gånger.");
                    break;
                case "4":
                    Console.WriteLine("Det tredje ordet.");
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
                // För att exemplifiera if-satser skall ni implementera, på uppdrag av en teoretisk lokal bio, ett program som kollar om en person är pensionär eller ungdom vid angiven ålder. För attkomma till denna funktion skall ett case i huvudmenyn skapas för ”1”, detta skall även framgå i texten som förklarar menyn. För att göra detta skall ni använda er av en nästlad if-sats.Det skall ske enligt följande förlopp:
                Console.WriteLine("Var vänlig och ange din ålder:");
                // 1.Användaren anger en ålder i siffror 
                string ageInput = Console.ReadLine()!;
                int age;
                // 2.Programmet konverterar detta från en sträng till en int
                if (int.TryParse(ageInput, out age))
                {
                    // 3.Programmet ser om personen är ungdom(under 20 år)
                    if (age < 20)
                    {
                        // 4.Om det ovanstående är sant skall programmet skriva ut: Ungdomspris: 80kr
                        Console.WriteLine("Ungdomspris: 80kr");
                    }
                    // 5.Annars kollar programmet om personen är en pensionär(över 64 år)
                    else if (age > 64)
                    {
                        // 6.Om ovanstående är sant skall programmet skruva ut: Pensionärspris: 90kr
                        Console.WriteLine("Pensionärspris: 90kr");
                    }
                    else
                    {
                        // 7.Annars skall programmet skriva ut: Standardpris: 120kr
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
            // Vi vill även få möjlighet att kunna räkna ut priset för ett helt sällskap.Lägg till det alternativet i huvudmenyn(ett case “2”). Det är även ok att ha alternativet i en undermeny. Vi anger då först hur många vi är som ska gå på bio.Frågar sedan efter ålder på var och en och skriver sedan ut en sammanfattning i konsolen som ska innehålla följande:
            // ● Antal personer
            Console.Write("Hur många är ni i sällskapet? ");
            string countInput = Console.ReadLine()!;

            if (int.TryParse(countInput, out int count) && count > 0)
            {
                // ● Samt totalkostnad för hela sällskapet
                int totalPrice = 0;

                for (int i = 1; i <= count; i++)
                {
                    Console.Write($"Ange ålder för person {i}: ");
                    string ageInput = Console.ReadLine()!;

                    if (int.TryParse(ageInput, out int age))
                    {
                        if (age < 20)
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
    }
}