using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeelingFroggy
{
    public class World
    {
        private string[,] Grid;
        private int Rows;
        private int Cols;

        public World(string [,] grid)
        {
            Grid = grid;
            Rows = Grid.GetLength(0);
            Cols = Grid.GetLength(1);            
        }

        public void Draw ()
        {
            for(int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Cols; x++)
                {
                    //Console.CursorVisible = false;
                    //Console.ForegroundColor = ConsoleColor.Blue;
                    string element = Grid[y, x];
                    Console.SetCursorPosition(x, y);
                    Console.Write(element);
                    //Console.ForegroundColor = ConsoleColor.DarkGreen;
                    //Console.SetCursorPosition(3,1);
                    //Console.Write("$");
                    //Console.SetCursorPosition(4,1);
                    //Console.Write("$");
                    //Console.SetCursorPosition(7,1);
                    //Console.Write("$");
                    //Console.SetCursorPosition(8,1);
                    //Console.Write("$");
                    //Console.SetCursorPosition(11,1);
                    //Console.Write("$");
                    //Console.SetCursorPosition(12,1);
                    //Console.Write("$");
                    //Console.ResetColor();
                }
            }
            
        }

        public bool IsSafe(int x, int y)
        {
                Game newgame = new Game();

            if (Grid[y, x] == "|" || y <= 0 || x <= 0 || Grid[y,x] == "=")
            {
                Console.Clear();
                Console.SetCursorPosition(0,0);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Youu flew off \nthe Map! \nGame Over");
                Console.ResetColor();
                Console.ReadKey();
                newgame.Start();
                return false;
            }
            else if(Grid[y, x] == "$")
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations, \nyou WON!");
                Console.ResetColor();
                Console.ReadKey();
                newgame.Start();
                return false;
            }

            return true;
            
        }
    }
}
