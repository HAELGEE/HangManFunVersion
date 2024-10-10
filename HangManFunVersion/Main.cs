using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManFunVersion;
internal class Main
{
    public void MainMenu()
    {

        string[] menuChoice = {
            "Start game",
            "Scoreboard",
            "Quit"
        };
        int menuSelecter = 0;
        bool loop = true;
        while (loop)
        {
            // För att skapa en ny person för varje gång man går in och spelar.
            Person person = new Person();
            // För att skapa ett nytt ord för varje gång man går in och spelar.
            Word word = new Word();
            Console.Clear();
            Console.WriteLine("Fun version of Hangman by #Christofer Hägg");

            for (int i = 0; i < menuChoice.Length; i++)
            {
                if (i == menuSelecter)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"---> \t {menuChoice[i]}");
                    Console.ResetColor();
                    Console.CursorVisible = false;
                }
                else
                    Console.WriteLine(menuChoice[i]);
            }

            var key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.DownArrow && menuSelecter < menuChoice.Length - 1)
            {
                menuSelecter++;
            }
            else if (key == ConsoleKey.UpArrow && menuSelecter >= 1)
            {
                menuSelecter--;
            }
            else if (key == ConsoleKey.Enter)
            {
                switch (menuSelecter)
                {
                    case 0:
                        word.TheMaskedWord();
                        //person.GetPlayerName();
                        word.GuessTheWord();
                        break;
                    case 1:
                        person.GetScoreboard();
                        break;
                    case 2:
                        loop = false;
                        break;
                }
            }
        }
    }
}
