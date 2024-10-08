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
        string Menu = "Start game" +
            "Scoreboard" +
            "Quit";
        bool loop = true;
        while (loop)
        {

            switch (0)
            {
                case 0:

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
