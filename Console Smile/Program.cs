using System;

namespace Smile
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            int x = 0;
            int y = 0;
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.Write(" ");

                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }

                if (key.Key == ConsoleKey.LeftArrow)
                {
                    x--;
                }

                else if (key.Key == ConsoleKey.RightArrow)
                {
                    x++;

                }

                else if (key.Key == ConsoleKey.UpArrow)
                {
                    y--;
                }

                else
                {
                    y++;
                }

                if (x == Console.WindowWidth)
                {
                    x--;
                }

                else if (x < Console.WindowLeft)
                {
                    x++;
                }

                else if (y > Console.WindowHeight)
                {
                    y--;
                }

                else if (y < Console.WindowTop)
                {
                    y++;
                }

                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.Write((char)1);
            }
        }
    }
}
