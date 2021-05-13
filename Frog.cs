using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeelingFroggy
{
    public class Frog
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        private string Froggy;
        private ConsoleColor FrogColor;
        public Frog(int initialX, int initialY, int width)
        {
            X = initialX;
            Y = initialY;
            Froggy = "\u03A9";
            FrogColor = ConsoleColor.Green;
            Width = width;
        }
        public void Draw()
        {
            Console.ForegroundColor = FrogColor;
            Console.SetCursorPosition(X, Y);
            Console.Write(Froggy);
            Console.ResetColor();

        }

    }
    public class Enemy1
    {
        private int _speed;
        public int PosX { get; set; }
        public int PosY { get; set; }
        public string Car { get; set; }
        public int Speed { get; set; } // 1 (slowest to 10 (fastest)
        public ConsoleColor Color { get; set; }


        public Enemy1() { }
        public Enemy1(int x, int y, int z, string car, ConsoleColor color)
        {
            PosX = x;
            PosY = y;
            Speed = z;
            Car = car;
            Color = color;
        }
        public void MoveRight(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
            x++;
            Console.SetCursorPosition(x, y);
            Console.Write(">");

        }
        //public void MoveLeft(int x, int y)
        //{


        //    Console.SetCursorPosition(x, y);
        //    Console.Write(" ");
        //    x--;
        //    Console.SetCursorPosition(x, y);
        //    Console.Write("<");

        //}

        public void Stay(int x, int y, string car)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(car);
        }

    }
    public class Enemy2
    {
        //        //private int _speed;
        public int PosX { get; set; }
        public int PosY { get; set; }
        public string Car { get; set; }
        public int Speed { get; set; } // 1 (slowest to 10 (fastest)
        public ConsoleColor Color { get; set; }


        public Enemy2() { }
        public Enemy2(int x, int y, int z, string car, ConsoleColor color)
        {
            PosX = x;
            PosY = y;
            Speed = z;
            Car = car;
            Color = color;
        }
        //public void MoveRight(int x, int y)
        //{
        //    Console.SetCursorPosition(x, y);
        //    Console.Write(" ");
        //    x++;
        //    Console.SetCursorPosition(x, y);
        //    Console.Write(">");

        //}
        public void MoveLeft(int x, int y)
        {


            Console.SetCursorPosition(x, y);
            Console.Write(" ");
            x--;
            Console.SetCursorPosition(x, y);
            Console.Write("<");

        }

        public void Stay(int x, int y, string car)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(car);
        }

    }
    public class Enemy3
    {
                //private int _speed;
        public int PosX { get; set; }
        public int PosY { get; set; }
        public string Car { get; set; }
        public int Speed { get; set; } // 1 (slowest to 10 (fastest)
        public ConsoleColor Color { get; set; }


        public Enemy3() { }
        public Enemy3(int x, int y, int z, string car, ConsoleColor color)
        {
            PosX = x;
            PosY = y;
            Speed = z;
            Car = car;
            Color = color;
        }
        public void MoveRight(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
            x++;
            Console.SetCursorPosition(x, y);
            Console.Write(">");

        }
        //public void MoveLeft(int x, int y)
        //{


        //    Console.SetCursorPosition(x, y);
        //    Console.Write(" ");
        //    x--;
        //    Console.SetCursorPosition(x, y);
        //    Console.Write("<");

        //}

        public void Stay(int x, int y, string car)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(car);
        }

    }
    public class Enemy4
    {
                //private int _speed;
        public int PosX { get; set; }
        public int PosY { get; set; }
        public string Car { get; set; }
        public int Speed { get; set; } // 1 (slowest to 10 (fastest)
        public ConsoleColor Color { get; set; }


        public Enemy4() { }
        public Enemy4(int x, int y, int z, string car, ConsoleColor color)
        {
            PosX = x;
            PosY = y;
            Speed = z;
            Car = car;
            Color = color;
        }
        public void MoveRight(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
            x++;
            Console.SetCursorPosition(x, y);
            Console.Write(">");

        }
        //public void MoveLeft(int x, int y)
        //{


        //    Console.SetCursorPosition(x, y);
        //    Console.Write(" ");
        //    x--;
        //    Console.SetCursorPosition(x, y);
        //    Console.Write("<");

        //}

        public void Stay(int x, int y, string car)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(car);
        }

    }
    public class Enemy5
    {
                //private int _speed;
        public int PosX { get; set; }
        public int PosY { get; set; }
        public string Car { get; set; }
        public int Speed { get; set; } // 1 (slowest to 10 (fastest)
        public ConsoleColor Color { get; set; }


        public Enemy5() { }
        public Enemy5(int x, int y, int z, string car, ConsoleColor color)
        {
            PosX = x;
            PosY = y;
            Speed = z;
            Car = car;
            Color = color;
        }
        //public void MoveRight(int x, int y)
        //{
        //    Console.SetCursorPosition(x, y);
        //    Console.Write(" ");
        //    x++;
        //    Console.SetCursorPosition(x, y);
        //    Console.Write(">");

        //}
        public void MoveLeft(int x, int y)
        {


            Console.SetCursorPosition(x, y);
            Console.Write(" ");
            x--;
            Console.SetCursorPosition(x, y);
            Console.Write("<");

        }

        public void Stay(int x, int y, string car)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(car);
        }

    }
    public class Enemy6
    {
                //private int _speed;
        public int PosX { get; set; }
        public int PosY { get; set; }
        public string Car { get; set; }
        public int Speed { get; set; } // 1 = slowest, 10=fastest
        public ConsoleColor Color { get; set; }


        public Enemy6() { }
        public Enemy6(int x, int y, int z, string car, ConsoleColor color)
        {
            PosX = x;
            PosY = y;
            Speed = z;
            Car = car;
            Color = color;
        }
        public void MoveRight(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
            x++;
            Console.SetCursorPosition(x, y);
            Console.Write(">");

        }
        //public void MoveLeft(int x, int y)
        //{


        //    Console.SetCursorPosition(x, y);
        //    Console.Write(" ");
        //    x--;
        //    Console.SetCursorPosition(x, y);
        //    Console.Write("<");

        //}

        public void Stay(int x, int y, string car)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(car);
        }

    }

}
