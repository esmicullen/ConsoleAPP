using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAPP
{
    internal class Program
    {
        private const int CHAR_STARS_TOTAL = 3;
        private const int CHAR_STARS1 = 0;
        private const int CHAR_STARS2 = 1;
        private const int CHAR_STARS3 = 2;
        private const int ROW = 5;
        private const int COL_START = 1;
        private const int COL_END = 50;


        static void Main(string[] args)
        {
            int x = COL_START;
            while (x <COL_END)
            {
                Console.Clear();
                Console.SetCursorPosition(x, ROW);

                switch (x % CHAR_STARS_TOTAL)
                {
                    case CHAR_STARS1 :
                        Console.WriteLine("__@");
                        break;
                    case CHAR_STARS2 :
                        Console.WriteLine("_^@");
                        break;
                    case CHAR_STARS3 :
                        Console.WriteLine("^_@");
                        break;
                }

                /* if(x%3 == 0)
                {
                    Console.WriteLine("__@");

                } else if (x % 3 == 1)
                {
                    Console.WriteLine("_^@");

                } else
                {
                    Console.WriteLine("^_@");
                } */

                Thread.Sleep(1000);
                x++;
            }
        }
    }
}
