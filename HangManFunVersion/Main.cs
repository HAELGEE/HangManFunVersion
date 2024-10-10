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
        Person person = new Person();
        Word word = new Word();

        string[] menuChoice = {
            "Start game",
            "Scoreboard",
            "Quit"
        };
        int menuSelecter = 0;
        bool loop = true;
        while (loop)
        {
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
                        word.GuessTheWord();
                        break;
                    case 1:
                        person.Scoreboard();
                        break;
                    case 2:
                        loop = false;
                        break;
                }
            }
        }
    }
}
