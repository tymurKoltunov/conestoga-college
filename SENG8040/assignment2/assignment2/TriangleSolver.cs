using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(int a, int b, int c)
        {
            string type = string.Empty;
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                if ((a == b) && (a == c) && (b == c))
                    type = "equilateral";
                else if ((a == b) || (a == c) || (b == c))
                    type = "isosceles";
                else
                    type = "scalene";
            }
            else
                type = "not possible";
            return type;
        }

    }
}
