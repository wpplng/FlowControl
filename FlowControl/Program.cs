using Microsoft.VisualBasic;
using System;
using System.Runtime.ConstrainedExecution;

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
                Console.WriteLine("1: Ungdom eller pensionär");
                Console.WriteLine("2: Upprepa tio gånger");
                Console.WriteLine("3: Det tredje ordet");
            switch (Console.ReadLine())
            {
                case "0":
                    Console.WriteLine("Programmet avslutas.");
                    isRunning = false;
                    break;
                case "1":
                    Console.WriteLine("Ungdom eller pensionär.");
                    break;
                case "2":
                    Console.WriteLine("Upprepa tio gånger.");
                    break;
                case "3":
                    Console.WriteLine("Det tredje ordet.");
                    break;
                default:
                    Console.WriteLine("Felaktig input, försök igen.");
                    break;
            }
                
            }
        }
    }
}