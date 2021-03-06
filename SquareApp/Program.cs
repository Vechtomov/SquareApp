﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SquareLibrary;

namespace SquareApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckValue();
        }

        private static void CheckValue()
        {
            double a = 0.3;
            double b = 0.4;
            double c = 0.5;

            Console.WriteLine(Square.GetSquareOfRightTriangle(a, b, c));
        }

        private static void Test()
        {
            while (true) {
                try {
                    double a, b, c;
                    Console.WriteLine("Enter three sides of a right triangle: ");
                    string line = Console.ReadLine();

                    a = Double.Parse(line.Split(' ')[0]);
                    b = Double.Parse(line.Split(' ')[1]);
                    c = Double.Parse(line.Split(' ')[2]);

                    Console.WriteLine(Square.GetSquareOfRightTriangle(a, b, c));
                    Console.WriteLine();
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
