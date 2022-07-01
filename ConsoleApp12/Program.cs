using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lengthstring;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lengthhelper helpher = new Lengthhelper();

            string input = Console.ReadLine();

            Console.WriteLine(helpher.findlength(input));
        }
    }
}
