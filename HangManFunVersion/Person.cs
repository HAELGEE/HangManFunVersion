using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManFunVersion;
internal class Person
{
    public string Name;
    public void Player()
    {
        while (true)
        {
            Console.Write("Please enter Your name: ");
            if(Console.ReadLine() == null)
                Console.WriteLine("Invalid input, try again.");
            else
            {
                Name = Console.ReadLine();
                break;
            }
        }
    }
    public void Scoreboard()
    {

    }
}
