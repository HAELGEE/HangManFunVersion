using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManFunVersion;
internal class Word
{
    public List<char> SecretWord = new List<char>();
    public string MaskedWord;
    public List<string> KeyBoard = new List<string> {"Q ", "W ", "E ", "R ", "T ", "Y ", "U ", "I ", "O ", "P ", "Å\n" +
        "A ", "S ", "D ", "F ", "G ", "H ", "J ", "K ", "L ", "Ö ", "Ä\n" +
        "    Z ", "X ", "C ", "V ", "B ", "N ", "M\n" };

    public void GuessTheWord()
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
    }
        
}
