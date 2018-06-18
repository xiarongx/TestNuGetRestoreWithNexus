using System;
using ACReditPlus.TestLib1;
namespace TestNuGetRestore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ReturnString returnString = new ReturnString();
            Console.WriteLine(returnString.TimeAndLocation());
            Console.Read();
        }
    }
}
