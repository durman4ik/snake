using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLine hLine1 = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine hLine2 = new HorizontalLine(0, 78, 24, '+');
            VerticalLine vLine1 = new VerticalLine(0, 0, 24, '+');
            VerticalLine vLine2 = new VerticalLine(78, 0, 24, '+');
            hLine1.Drow();
            hLine2.Drow();
            vLine1.Drow();
            vLine2.Drow();

            Point p1 = new Point(4, 5, '*');
            p1.Draw();

            Console.ReadLine();
        }
    }
}