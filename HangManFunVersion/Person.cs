using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManFunVersion;
internal class Person
{
    // Skapar en statisk instans utav personklassen för att inte skapa nya "personer" i varje klass
    public static Person Instance = new Person();

    // Sätter "originalet" utav Person klassen som privat så inget utifrån ändras i denna konstruktorn
    private Person()
    {
    }

    public string? Name { get; set; }
    public List<string> HighScore = new List<string>();

    public void GetPlayerName()
    {
        Console.Clear();
        while (true)
        {
            Console.Write("Please enter Your name: ");
            var validPlayerName = Console.ReadLine();

            if (validPlayerName == null || validPlayerName == "")
                Console.WriteLine("Invalid input, try again.");
            else
            {
                Name = validPlayerName;
                break;
            }
        }
    }
    public void GetScoreboard()
    {        
        // Fixa så denna är sorterad.
        foreach (var name in HighScore)
        {
            Console.WriteLine(name);            
        }

        Console.ReadKey();
    }
    public void SetScoreboard(string name, int points)
    {
        HighScore.Add($"Name: {name}, Points: {points}");
        Console.WriteLine($"Name: {name}, Points: {points} - Added to Highscore");        
    }

}
