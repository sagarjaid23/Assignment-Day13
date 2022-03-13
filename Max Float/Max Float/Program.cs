using System;

namespace Max_Float
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Max Number");
            double output = MaxFloat.MaxFloatNumber(20.2, 25.5, 30.56);
            Console.WriteLine(output);
        }
    }
}
