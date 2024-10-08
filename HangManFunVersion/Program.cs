namespace HangManFunVersion;

internal class Program
{
    static void Main(string[] args)
    {
        Main main = new Main();
        Word word = new Word();
        Color color = new Color();
        //main.MainMenu();

        string test = "A";
        for (int i = 0; i < word.keyBoard.Count; i++)
        {

        }

        foreach (string c in word.keyBoard)
        {
            if (c.Contains(test))
            {
                color.Gray(c);
            }
            else
                color.White(c);

            //Console.WriteLine(c);

        }


    }
}
