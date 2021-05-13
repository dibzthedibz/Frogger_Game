using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeelingFroggy
{
    public class Game
    {
        public int _lane1Counter = 0;
        private World MyWorld;
        private Frog CurrentFrog;
        public int Window_Height = 12;
        public int Window_Width = 19;
        //public int BuffW = 24;
        //public int BuffH = 30;


        public void Start()
        {             
            Console.BufferHeight =
            Console.BufferHeight = Console.WindowHeight = Window_Height;
            Console.BufferWidth = Console.WindowWidth = Window_Width;
            Console.Title = "Feeling Froggy";
            Console.CursorVisible = false;
            Console.WriteLine("    Welcome");
            Console.WriteLine("      To   ");
            Console.WriteLine("  Ben And Ryan's");
            Console.WriteLine("  Rendition Of");
            Console.WriteLine("    Frogger!  ");
            Console.WriteLine("              ");
            Console.WriteLine("  Please Press");
            Console.WriteLine("     Any Key");
            Console.WriteLine("     To Be");
            Console.WriteLine("     Amazed");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("       _  _");
            Console.WriteLine("       (.)(.)");
            Console.WriteLine("   ,-.(.____.),-.  ");
            Console.WriteLine("  (\\ \\ '--' / / )");
            Console.WriteLine("  \\ \\ / ,.\\ / / ");
            Console.WriteLine("    ) '| || |' (   ");
            Console.WriteLine(" oO'- OoO''OoO -'Oo");
            Console.ReadKey();
            MyWorld = new World(GetGrid());
            CurrentFrog = new Frog(8, 10, 1);

            GameLoop();

        }

        public void PlayerInput()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            ConsoleKey key = keyInfo.Key;
            World safe = new World(GetGrid());
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (safe.IsSafe(CurrentFrog.X, CurrentFrog.Y - 1))
                    {
                        CurrentFrog.Y -= 1;
                        break;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (safe.IsSafe(CurrentFrog.X, CurrentFrog.Y + 1))
                    {
                        CurrentFrog.Y += 1;
                        break;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (safe.IsSafe(CurrentFrog.X - 1, CurrentFrog.Y))
                    {
                        CurrentFrog.X -= 1;
                        break;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (safe.IsSafe(CurrentFrog.X + 1, CurrentFrog.Y))
                    {
                        CurrentFrog.X += 1;
                        break;
                    }
                    break;
                default:
                    break;
            }
        }

        private void DrawFrame()
        {
            Console.Clear();
            MyWorld.Draw();
            CurrentFrog.Draw();
        }

        public void GameLoop()
        {
            Enemy1 CarLane1 = new Enemy1(3, 9, 6, ">", ConsoleColor.Red);
            Enemy2 CarLane2 = new Enemy2(2, 8, 9, ">", ConsoleColor.Red);
            Enemy3 CarLane3 = new Enemy3(5, 7, 3, "<#>", ConsoleColor.Red);
            Enemy4 CarLane4 = new Enemy4(8, 4, 8, "<", ConsoleColor.Red);
            Enemy5 CarLane5 = new Enemy5(13, 3, 3, "<<", ConsoleColor.Red);
            Enemy6 CarLane6 = new Enemy6(3, 2, 6, ">", ConsoleColor.Red);


            while (true)
            {
                DrawFrame();

                Random speed = new Random();
                int speedCheck = speed.Next(0, 10);
                if (CarLane1.Speed > speedCheck)
                {
                    CarLane1.MoveRight(CarLane1.PosX, CarLane1.PosY); // Taking the car's speed (1-10), and seeing if its bigger than a number from random 0-10              

                    CarLane1.PosX += 1;             //  lower the speed the lower the times it will hit 
                    CollisionCheck(CarLane1.PosX, CarLane1.PosY);
                    if (CarLane1.PosX > 15) { CarLane1.PosX = 0; }
                }
                else CarLane1.Stay(CarLane1.PosX, CarLane1.PosY, CarLane1.Car);

                speedCheck = speed.Next(1, 4);
                if (CarLane2.Speed > speedCheck)
                {
                    CarLane2.MoveLeft(CarLane2.PosX, CarLane2.PosY);
                    CarLane2.PosX -= 1;
                    CollisionCheck(CarLane2.PosX, CarLane2.PosY);
                    if (CarLane2.PosX <= 2) { CarLane2.PosX = 15; }
                }
                else CarLane2.Stay(CarLane2.PosX, CarLane2.PosY, CarLane2.Car);

                speedCheck = speed.Next(0, 10);
                if (CarLane3.Speed > speedCheck)
                {
                    CarLane3.MoveRight(CarLane3.PosX, CarLane3.PosY);
                    CarLane3.PosX += 1;
                    CollisionCheck(CarLane3.PosX, CarLane3.PosY);
                    if (CarLane3.PosX > 15) { CarLane3.PosX = 0; }
                }
                else CarLane3.Stay(CarLane3.PosX, CarLane3.PosY, CarLane3.Car);

                speedCheck = speed.Next(2, 4);
                if (CarLane4.Speed > speedCheck)
                {
                    CarLane4.MoveRight(CarLane4.PosX, CarLane4.PosY);
                    CarLane4.PosX += 1;
                    CollisionCheck(CarLane4.PosX, CarLane4.PosY);
                    if (CarLane4.PosX > 15) { CarLane4.PosX = 0; }
                }
                else CarLane4.Stay(CarLane4.PosX, CarLane4.PosY, CarLane4.Car);

                speedCheck = speed.Next(0, 10);
                if (CarLane5.Speed > speedCheck)
                {
                    CarLane5.MoveLeft(CarLane5.PosX, CarLane5.PosY);
                    CarLane5.PosX -= 1;
                    CollisionCheck(CarLane5.PosX, CarLane5.PosY);
                    if (CarLane5.PosX <= 2) { CarLane5.PosX = 15; }
                }
                else CarLane5.Stay(CarLane5.PosX, CarLane5.PosY, CarLane5.Car);

                speedCheck = speed.Next(1, 4);
                if (CarLane6.Speed > speedCheck)
                {
                    CarLane6.MoveRight(CarLane6.PosX, CarLane6.PosY);
                    CarLane6.PosX += 1;
                    CollisionCheck(CarLane6.PosX, CarLane6.PosY);
                    if (CarLane6.PosX > 15) { CarLane6.PosX = 0; }
                }
                else CarLane6.Stay(CarLane6.PosX, CarLane6.PosY, CarLane6.Car);


                while (Console.KeyAvailable) { PlayerInput(); }
                //Check if player hit To do
                System.Threading.Thread.Sleep(60);

            }
        }

        public string[,] GetGrid()
        {
            
            string[,] grid = {
                {"~" , "~" , "~" , "~" , "~" , "~" , "~" , "~" , "~" , "~" ,"~" , "~" , "~" , "~" , "~" , "|" }, //  16x12
                {"|" , "=" , "=" , "$" , "$" , "=" , "=" , "$" , "$" , "=" ,"=" , "$" , "$" , "=" , "=" , "|" }, // End
                {"|" , " " , " " , " " , " " , " " , " " , " " , " " , " " ," " , " " , " " , " " , " " , "|" }, // Danger
                {"|" , " " , " " , " " , " " , " " , " " , " " , " " , " " ," " , " " , " " , " " , " " , "|" }, // Danger
                {"|" , " " , " " , " " , " " , " " , " " , " " , " " , " " ," " , " " , " " , " " , " " , "|" }, // Danger
                {"|" , " " , " " , " " , " " , " " , " " , " " , " " , " " ," " , " " , " " , " " , " " , "|" }, // Safe
                {"|" , " " , " " , " " , " " , " " , " " , " " , " " , " " ," " , " " , " " , " " , " " , "|" }, // Safe
                {"|" , " " , " " , " " , " " , " " , " " , " " , " " , " " ," " , " " , " " , " " , " " , "|" }, // Danger
                {"|" , " " , " " , " " , " " , " " , " " , " " , " " , " " ," " , " " , " " , " " , " " , "|" }, // Danger
                {"|" , " " , " " , " " , " " , " " , " " , " " , " " , " " ," " , " " , " " , " " , " " , "|" }, // Danger
                {"|" , " " , " " , " " , " " , " " , " " , " " , " " , " " ," " , " " , " " , " " , " " , "|" }, // Start 
                {"=" , "=" , "=" , "=" , "=" , "=" , "=" , "=" , "=" , "=" ,"=" , "=" , "=" , "=" , "=" , "|" },

            };
            return grid;
        }
        public void CollisionCheck(int x, int y)
        {
            Game newgame = new Game();
            if (x == CurrentFrog.X && y == CurrentFrog.Y)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\n\n***************OH NO, a bird got you. Better luck next time.**********");
                Console.ResetColor();
                newgame.Start();
            }
        }



    }

}
