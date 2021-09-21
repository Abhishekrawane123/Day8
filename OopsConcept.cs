using System;

namespace Day8
{
    class OopsConcept
    {
        int X1, X2, Y1, Y2, P1, P2, Q1, Q2;
        static double status;
        public OopsConcept(int X1, int X2, int Y1, int Y2, int P1, int P2, int Q1, int Q2)
        {
            this.X1 = X1;
            this.X2 = X2;
            this.Y1 = Y1;
            this.Y2 = Y2;

            this.P1 = P1;
            this.P2 = P2;
            this.Q1 = Q1;
            this.Q2 = Q2;


        }

        public double Result(int X1, int X2, int Y1, int Y2, int P1, int P2, int Q1, int Q2)
        {
            float length1 = (float)Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));

            float length2 = (float)Math.Sqrt(Math.Pow(P2 - P1, 2) + Math.Pow(Q2 - Q1, 2));
             status = length1.CompareTo(length2);

            return status;
           
  }

        public string toString()
        {
            if (status > 0)
            {

                return ("Length1 is greater than Length2");


            }

            else if (status < 0)
            {
                return ("Length2 is greater than Length1");

            }

            else
            {
                return (" otherwise both Lengths of line are Equal ");

            }


        }


    }
}