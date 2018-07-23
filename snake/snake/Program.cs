﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            // отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine( 0, 78, 0, '+' );
            HorizontalLine downLine = new HorizontalLine( 0, 78, 24, '+' );
            VerticalLine leftLine = new VerticalLine( 0, 24, 0, '+' );
            VerticalLine rightLine = new VerticalLine( 0, 24, 78, '+' );
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            // отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            Thread.Sleep(100);
            snake.Move();
            }


        }
    }
}