using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging_Demo_Code
{
    public class VerdiantComputer
    {
        public static bool ComputeVerdiance(int a)
        {
            int b = 0;
            int c = 0;
            int d = a;

            for (int i = 0; i < a; i++)
            {
                c = a / 3;
                b = ((i+1) * c) / a;
                if (isHalfVerdiant(b, c))
                {
                    d -= 10;
                    if (d <= 0)
                    {
                        d = a;
                    }
                }
            }

            if (d % a == b % a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool isHalfVerdiant(int b, int c)
        {
            for (int j = 1; j <= c; j=j*2)
            {
                if (c % j == b * j)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
