using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACReditPlus.TestLib1;
namespace TestNuGetRestore
{
    class Program
    {
        static void Main(string[] args)
        {
            ReturnString returnString = new ReturnString();
            Console.WriteLine(returnString.TimeAndLocation());
            Console.Read();
        }
    }
}
