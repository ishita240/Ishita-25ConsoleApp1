using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishita_25ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] strings = { "Actions speak louder than words", "Hello!", "Python.",
                           "PHP.", "random" };
            foreach (var value in strings)
            {
                bool endsInPeriod = value.EndsWith(".");
                Console.WriteLine();
                Console.WriteLine("'{0}' ends in a period: {1}",
                                  value, endsInPeriod);
            }
        }
    }
}
    