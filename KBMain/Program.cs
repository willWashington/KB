using System;

namespace KBMain
{
    class Program
    {
        static void Main(string[] args)
        {
            string venue = args[0];
            string bandArgument = args[1];
            int bands = 0;
            // First, create an if condition...
            bands = bandArgument.TryParse();
            Console.WriteLine(venue + " will have " + bands + " bands performing tonight!");

            // Also, create an else condition...
            Console.WriteLine("Hello World!");
        }
    }
}

