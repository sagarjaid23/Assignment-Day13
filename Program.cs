using System;

namespace Find_Max_Problem_using_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Max Number");
            int output = MaxInt.MaxIntNumber(20, 25, 30);
            Console.WriteLine(output);

            Console.WriteLine("Max Number");
            double Voutput = MaxFloat.MaxFloatNum("20.2, 25.5, 30.56");
            Console.WriteLine(Voutput);

            Console.WriteLine("Max Number");
            string Vaoutput = MaxString.MaxstringNumber("111.3", "120.5", "125.3");
            Console.WriteLine(Vaoutput);
        }
    }
}


        
