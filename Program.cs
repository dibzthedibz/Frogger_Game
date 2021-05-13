using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeelingFroggy
{
    class Program
    {
        static void Main(string[] args)
        {

            Game newGame = new Game();
            newGame.SetScreenSize();
            newGame.MenuScreen();            
            newGame.InstructionScreen();
            newGame.PreGameSplashScreen();
            newGame.Start();
               
        }
    }
}
