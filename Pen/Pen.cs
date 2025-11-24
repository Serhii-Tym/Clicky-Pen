using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pen
{
    internal class Pen
    {
        public ConsoleColor color = ConsoleColor.Green;
        double inkLevel = 100;
        bool clicked = false;


        public void Click()
        {
            if (clicked)
            {
                Console.WriteLine("*Click Click*");
                clicked = false;
            }
            else
            {
                Console.WriteLine("*Click*");
                clicked = true;
            }
        }

        public void WriteLine(string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
