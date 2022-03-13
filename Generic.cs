using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Max_Problem_using_Generics
{
    internal class Generic<T> where T : IComparable
    {
        public T Value;
        public Generic(T[] value)
        {
            this.Value = Value;
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public void PrintMaxValue()
        {
            var max = MaxValue(this.Value);
            Console.WriteLine("Maximun Value is" + max);
        }
    }
}

