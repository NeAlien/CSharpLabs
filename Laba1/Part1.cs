using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type sbyte: min value is {0} and max value is {1}", SByte.MinValue, SByte.MaxValue);
            Console.WriteLine("Type byte: min value is {0} and max value is {1}", Byte.MinValue, Byte.MaxValue);
            Console.WriteLine("Type char: min value is {0} and max value is {1}", (int)Char.MinValue, (int)Char.MaxValue);
            Console.WriteLine("Type decimal: min value is {0} and max value is {1}", Decimal.MinValue, Decimal.MaxValue);
            Console.WriteLine("Type double: min value is {0} and max value is {1}", Double.MinValue, Double.MaxValue);
            Console.WriteLine("Type single: min value is {0} and max value is {1}", Single.MinValue, Single.MaxValue);
            Console.WriteLine("Type int16: min value is {0} and max value is {1}", Int16.MinValue, Int16.MaxValue);
            Console.WriteLine("Type int32: min value is {0} and max value is {1}", Int32.MinValue, Int32.MaxValue);
            Console.WriteLine("Type int64: min value is {0} and max value is {1}", Int64.MinValue, Int64.MaxValue);
            Console.WriteLine("Type uint16: min value is {0} and max value is {1}", UInt16.MinValue, UInt16.MaxValue);
            Console.WriteLine("Type uint32: min value is {0} and max value is {1}", UInt32.MinValue, UInt32.MaxValue);
            Console.WriteLine("Type uint64: min value is {0} and max value is {1}", UInt64.MinValue, UInt64.MaxValue);
            Console.WriteLine("Type bool: min value is {0} and max value is {1}", Boolean.FalseString, Boolean.TrueString);
            Console.WriteLine("Type datetime: min value is {0} and max value is {1}", DateTime.MinValue, DateTime.MaxValue);
        }
    }
}
