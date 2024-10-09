using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManFunVersion;
internal class Word
{
    public Color color = new Color();

    public string GuessedLetter;
    public List<char> GuessedLetterToList = new List<char>();

    public List<char> SecretWord = new List<char>();
    public string MaskedWord;
    public List<string> KeyBoard = new List<string> {"Q ", "W ", "E ", "R ", "T ", "Y ", "U ", "I ", "O ", "P ", "Å\n" +
        "A ", "S ", "D ", "F ", "G ", "H ", "J ", "K ", "L ", "Ö ", "Ä\n" +
        "    Z ", "X ", "C ", "V ", "B ", "N ", "M\n" };

    public void TheMaskedWord()
    {
        Console.WriteLine("Please enter a word u want other to guess on");
        string validWord = Console.ReadLine();

        for (int i = 0; i < validWord.Length; i++)
        {
            // Lägger in ordet som andra skall gissa på i Lisan
            SecretWord.Add(validWord[i]);
            // Denna sätter hur långt det maskerade ordet är som man skall gissa på
            MaskedWord = "_" + MaskedWord;
        }
        Console.WriteLine(MaskedWord);
    }

    public void GuessTheWord()
    {
        foreach (string c in KeyBoard)
        {
            Console.Write(c);
        }

        while (true)
        {
            Console.Write("Enter a letter to the guess: ");
            GuessedLetter = Console.ReadLine();
            if (GuessedLetter == null)
                Console.WriteLine("You need to enter a letter");
            else if (GuessedLetter.Length > 1)
                Console.WriteLine("The guess cant be longer then ONE letter.");
            //else if ()
            //    break;
            foreach (var arg in GuessedLetterToList)
            {
                // Här vill jag testa mig fram för att se om jag kan
                // köra en .Contain på GuessedLetterToList.ToString()
                // utan att använda mig av foreach?
                if (GuessedLetter == GuessedLetterToList.ToString())
                {
                    foreach (string c in KeyBoard)
                    {
                        // Här ändras färgen beroende på gissade bokstäver
                        if (c.Contains(GuessedLetter))
                            color.Black(c);
                    }
                }
            }

        }
    }

}
