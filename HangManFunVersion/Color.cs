using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManFunVersion;
internal class Color
{
    public void Black(string input)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        //Console.Write(input);
        //Console.ResetColor();
    }
    public void White(string input)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(input);
        //Console.ResetColor();

    }
}
