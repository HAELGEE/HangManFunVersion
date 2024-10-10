using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManFunVersion;
internal class Person
{
    public string? Name;
    public List<string> HighScore = new List<string>();
    public void GetPlayerName()
    {
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
        foreach (var name in HighScore)
            Console.WriteLine(name);

        Console.ReadKey();
    }
    public void SetScoreboard(string name, int points)
    {
        HighScore.Add($"Name: {name}, Points: {points}");
        Console.WriteLine($"Name: {name}, Points: {points} added to Highscore");
        Console.ReadKey();
    }

}
