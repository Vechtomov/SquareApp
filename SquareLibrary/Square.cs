using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary
{
    public static class Square
    {
        /// <summary>
        /// Calculates the area of a right triangle. Method automatically determines triangle cathetuses.
        /// </summary>
        /// <param name="a">side of a right triangle</param>
        /// <param name="b">side of a right triangle</param>
        /// <param name="c">side of a right triangle</param>
        /// <returns>Square of a right triangle</returns>
        public static double GetSquareOfRightTriangle(double a, double b, double c)
        {
            if (a <= 0) {
                throw new ArgumentOutOfRangeException(nameof(a), "Side length must be > 0");
            }
            if (b <= 0) {
                throw new ArgumentOutOfRangeException(nameof(b), "Side length must be > 0");
            }
            if (c <= 0) {
                throw new ArgumentOutOfRangeException(nameof(c), "Side length must be > 0");
            }
            
            SetCathetuses(ref a, ref b, ref c);

            if(!CheckPithagoreanTheorem(a, b, c)) {
                throw new ArgumentException("Sides of the triangle doesn't satisfy the Pithagorean theorem");
            }

            return a * b / 2;
        }

        private static void SetCathetuses(ref double a, ref double b, ref double c)
        {
            double[] sides = { a, b, c };
            Array.Sort(sides);

            if (sides[2] == sides[1]) {
                throw new ArgumentException("In a right triangle there can be only one largest side");
            }

            a = sides[0];
            b = sides[1];
            c = sides[2];
        }

        private static bool CheckPithagoreanTheorem(double firstCathetus, double secondCathteus, double hypotenuse)
        {
            double firstCathetusSquare = Math.Pow(firstCathetus, 2.0);
            double secondCathetusSquare = Math.Pow(secondCathteus, 2.0);
            double hypotenuseSquare = Math.Pow(hypotenuse, 2.0);
            double sum = firstCathetusSquare + secondCathetusSquare;

            return Math.Abs(sum - hypotenuseSquare) < 0.0000001;
        }
    }
}
