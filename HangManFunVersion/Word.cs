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

    public string? GuessedLetter;
    public List<string> GuessedLetterToList = new List<string>();

    public List<char> SecretWord = new List<char>();
    public string? SecretWordString;

    public List<string>? MaskedWord = new List<string>();
    public string? MaskedWordString;

    public int Guesses = 0;
    public int Points = 100;

    public List<string> KeyBoard = new List<string> {"Q ", "W ", "E ", "R ", "T ", "Y ", "U ", "I ", "O ", "P ", "Å", " " +
        " \n", "A ", "S ", "D ", "F ", "G ", "H ", "J ", "K ", "L ", "Ö ", "Ä", " " +
        " \n    ", "Z ", "X ", "C ", "V ", "B ", "N ", "M", "\n"};

    public void TheMaskedWord()
    {
        // Rensar konsolen för att få det mer "Clear"
        Console.Clear();
        string? validWord;
        while (true)
        {
            Console.Clear();

            Console.WriteLine("Please enter a word u want other to guess on");
            validWord = Console.ReadLine()!.ToUpper();
            SecretWordString = validWord;
            if (validWord == null)
            {
                Console.WriteLine("You need to enter a letter");
                Console.ReadKey();
            }
            else if (validWord.Length < 2)
            {
                Console.WriteLine("The word can't be shorter then TWO letters");
                Console.ReadKey();
            }
            else
                break;
        }

        for (int i = 0; i < validWord!.Length; i++)
        {
            // Lägger in ordet som andra skall gissa på i Lisan
            SecretWord.Add(validWord[i]);
            // Denna sätter hur långt det maskerade ordet är som man skall gissa på
            MaskedWord!.Add("_");
        }

    }

    public void GuessTheWord()
    {
        // Sätter en while-loop för att få spelaren till att fortsätta gissa tills ordet är klart
        while (true)
        {
            Console.Clear();
            Console.Write($"The Secretword: ");
            foreach (string c in MaskedWord!)
            { Console.Write(c); }

            // För att skapa ett mellanrum i runtime
            Console.WriteLine("\n");

            foreach (string c in KeyBoard)
            {
                Console.Write(c);
            }

            // När spelaren har gissat rätt skrivs det i if-satsen ut
            if (MaskedWordString == SecretWordString)
            {
                Console.WriteLine("\nYou have now guessed the Word. Congratulations :)");
                Console.WriteLine($"Total attempts to finish the word: {Guesses} wich gave you {Points}.Points");
                Console.ReadKey();
                break;
            }

            bool loop = true;
            // Sätter en while-loop för att få spelaren till att skriva in rätt inmatning
            while (loop)
            {
                Console.Write("Enter a letter to the guess: ");
                GuessedLetter = Console.ReadLine()!.ToUpper();
                if (GuessedLetter == null || GuessedLetter == "")
                    Console.WriteLine("You need to enter a letter");
                else if (GuessedLetter.Length > 1)
                    Console.WriteLine("The guess can't be longer then ONE letter.");
                else if (GuessedLetterToList.Contains(GuessedLetter))
                    Console.WriteLine("You have already guessed on this letter.");
                else
                {
                    /* ska ersätta _ med den angivna bokstaven om den är korrekt
                     * MaskedWord innehåller _ 
                     */
                    for (int i = 0; i < SecretWord.Count; i++)
                    {
                        if (SecretWord[i] == Convert.ToChar(GuessedLetter))
                        {
                            MaskedWord[i] = GuessedLetter;
                            MaskedWordString = MaskedWordString + GuessedLetter;
                        }
                    }

                    GuessedLetterToList.Add(GuessedLetter);
                    for (int i = 0; i < KeyBoard.Count; i++)
                    {
                        if (KeyBoard[i].Contains(GuessedLetter))
                        {
                            KeyBoard[i] = "  ";

                        }
                    }

                    // Skall dra av 10 poäng vid varje misslyckat försök men behålla samma vid rätt bokstav
                    if (!SecretWordString!.Contains(GuessedLetter))
                        if (Points != 0)
                            Points -= 10;


                    Guesses++;
                    loop = false;
                }
            }
        }
    }
}
