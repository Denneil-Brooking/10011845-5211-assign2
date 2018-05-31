using System;

namespace question04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print out the reverse timestables (highest number first) for:");

            var number = int.Parse(Console.ReadLine());

            for(var i = 12; i > 0; i--) {

                Console.WriteLine($"{i} x {number} = {i * number}");
            }
        }
    }
}
