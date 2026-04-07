using System;
using Spectre.Console;
using Cowsay;
using System.Runtime.Intrinsics.Arm;
using System.Linq.Expressions;

namespace cursed_calculator
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Spectre.Console.AnsiConsole.MarkupLine("[bold red]Lass die Kuh dir helfen, sonst ist sie traurig, okay?[/]");

            var staticCow = await DefaultCattleFarmer.RearCowWithDefaults("default");

            Console.WriteLine(staticCow.Speak("Muh soll ich dir in Mathe helfen? Ich bin sehr gut darin! Sag einfach muuh!", cowEyes: "^^"));
            Console.WriteLine("Drücke eine Taste...");
            Console.ReadKey(true);
            Console.WriteLine("Schön, dann lass uns mal rechnen. Auch, wenn du nicht willst (mach es für deine Kuh)");

            Console.WriteLine("Gib die erste Zahl ein:");
            string num1 = Console.ReadLine();

            Console.WriteLine("Gib die zweite Zahl ein:");
            string num2 = Console.ReadLine();

            Console.WriteLine("Alles klar, willst du addieren, subtrahieren, multiplizieren oder dividieren? (+, -, *, /):");
            string antwort = Console.ReadLine();
            AnsiConsole.Progress()
    .Start(ctx =>
    {
        var task = ctx.AddTask("Deine Kuh denkt nach...");

        while (!ctx.IsFinished)
        {
            task.Increment(1.5);
            Thread.Sleep(20);
        }
    });

            if (antwort == "+")
            {
                double result = Convert.ToDouble(num1) + Convert.ToDouble(num2);
                Console.WriteLine(staticCow.Speak("Das Ergebnis ist: " + result, cowEyes: "o<"));
            }
            else if (antwort == "-")
            {
                double result = Convert.ToDouble(num1) - Convert.ToDouble(num2);
                Console.WriteLine(staticCow.Speak("Das Ergebnis ist: " + result, cowEyes: "o<"));
            }
            else if (antwort == "*")
            {
                double result = Convert.ToDouble(num1) * Convert.ToDouble(num2);
                Console.WriteLine(staticCow.Speak("Das Ergebnis ist: " + result, cowEyes: "o<"));
            }
            else if (antwort == "/")
            {
                double result = Convert.ToDouble(num1) / Convert.ToDouble(num2);
                Console.WriteLine(staticCow.Speak("Das Ergebnis ist: " + result, cowEyes: "o<"));
            }
            Console.ReadKey(true);   // damit Konsole nach Abschluss nicht automatisch beendet wird
        }
    }
}