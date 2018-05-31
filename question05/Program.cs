using System;

namespace question05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print out the division table for:");

            var number = Convert.ToDouble(Console.ReadLine());

            for (var i = 0; i < 12; i++){
                var a = i + 1;
                var val = a / number;
                Console.WriteLine($"{a} / {number} = {val}");
            }
        }
    }
}
