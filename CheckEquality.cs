using System;
using System.Collections.Generic;
using System.Text;

namespace Day8
{
    class CheckEquality
    {

        public static void checkEquality()
        {
            Console.WriteLine(" please enter the value of line1 co-ordinates");
            int X1 = 1;
            int Y1 = 2;
            int X2 = 3;
            int Y2 = 4;

            Console.WriteLine(" please enter the value of line2 co-ordinates");
            int P1 = 8;
            int Q1 = 7;
            int P2 = 5;
            int Q2 = 4;

            float length1 = (float)Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            float length2 = (float)Math.Sqrt(Math.Pow(P2 - P1, 2) + Math.Pow(Q2 - Q1, 2));
            Console.WriteLine(length1);
            Console.WriteLine(length2);

            if (length1 == length2)
            {
                Console.WriteLine(" L1 Equal to L2 ");

            }
            else
            {
                Console.WriteLine(" both are not equal  ");


            }


        }
    }
}

