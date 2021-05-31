using DllVersioning;
using System;
using SecondDependency;

namespace MultiVersionDependency
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var c1 = new Class1();
            var c2 = new Class2();
            Console.WriteLine(c1.GetVersionNumber());
            Console.WriteLine(c2.GetAnotherVersion());
            Console.WriteLine();
            Console.Read();
        }
    }
}
