namespace HangManFunVersion;

internal class Program
{
    static void Main(string[] args)
    {
        Main main = new Main();
        Word word = new Word();
        Color color = new Color();
        
        //main.MainMenu();

        string test = "A"; // Ett test för att se om färgen ändras, vilket den nu gör!

        // Här ändras färgen beroende på gissade bokstäver
        foreach (string c in word.KeyBoard)
        {
            if (c.Contains(test))
                color.Gray(c);

            else
                color.White(c);
        }
        word.GuessTheWord();
        Console.WriteLine(word.MaskedWord);

    }
}
