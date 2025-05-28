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

        // Menyval 3: Upprepa tio gånger
        private static void RepeatTenTimes()
        {
            // För att använda en annan typ av iteration skall ni här implementera en for-loop. Detta ska ni skapa för att upprepa något en användare skriver in tio gånger. Det ska alltså inte skrivas via tio stycken ”Console.Write(Input);” utan via en loop som gör detta tio gånger.För att komma till den här funktionen skall ni lägga till ett case för ”3” i er huvudmeny samt text som förklarar detta. Händelseförloppet visas nedan:
            //1.Användaren anger en godtycklig text
            Console.WriteLine("Var vänlig ange en text som programmet ska upprepa:");
            // 2.Programmet sparar texten som en variabel
            string textToRepeat = Console.ReadLine()!;
            // 3.Programmet skriver, via en for-loop ut denna text tio gånger på rad, alltså UTAN radbrott. Exempel på output: 1.Input, 2.Input, 3.Input osv.
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}: {textToRepeat} ");
            }
        }

        // Menyval 4: Det tredje ordet
        private static void GetThirdWord()
        {
            /* Ni har tidigare lärt er hur vi omvandlar strängar till integers(tex int.Parse, int.TryParse)men
             nu ska vi dela upp en sträng. Användaren skall ange en mening, som programmet delar upp
             i ord via strängens .Split(char) - metod.Ni skall dela strängen på varje mellanslag. För att
             enkelt lagra detta bör input sparas som en var, då ni kommer få tillbaka mer än en sträng.
             För att testa det här skall ni skapa case ”4” i er huvudmeny samt skriva en förklaring i
             texten. Händelseförloppet förklaras nedan:*/

            // 1.Användaren anger en mening med minst 3 ord
            Console.WriteLine("Var vänlig ange en mening med minst tre ord: ");
            string input = Console.ReadLine()!;
            // 2.Programmet delar upp strängen med split - metoden på varje mellanslag
            var words = input.Split(' ');
            // 3.Programmet plockar ut den tredje strängen(ordet) ur input
            // 4.Programmet skriver ut den tredje strängen(ordet)
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