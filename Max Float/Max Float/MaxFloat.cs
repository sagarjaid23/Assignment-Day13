using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Float
{
    internal class MaxFloat
    {
        public static double MaxFloatNumber(double First, double Second, double Third)
        {
            if (First < 0 || First.CompareTo(Second) > 0 && First.CompareTo(Third) > 0)
            {
                return First;
            }
            if (Second.CompareTo(First) > 0 && Second.CompareTo(Third) > 0)
            {
                return Second;
            }
            if (Third.CompareTo(First) > 0 && Third.CompareTo(Second) > 0)
            {
                return Third;
            }
            throw new Exception("First,Second, Third are Same");
        }
    }
}
