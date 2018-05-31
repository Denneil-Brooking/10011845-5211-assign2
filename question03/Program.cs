using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace question03
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] fruitsArray = new string[] { "Banana", "Grapefruit", "Tomato", "Oranges", "Apple", "Cherry", "Mango", "Pear", "Apricot", "Plum", "Feijoa", "Watermelon", "Cranberry", "Grape", "Pomegranate", "Jujube", "Nectarine", "Raspberry", "Dragonfruit", "Kiwifruit", "Strawberry", "Olive", "Lemon", "Lychee", "Blackcurrant", "Passionfruit", "Guava", "Nance"};

            //List<string> fruitsArray = new List<string> { "Banana", "Grapefruit", "Tomato", "Oranges, "Apple", "Cherry", "Mango", "Pear", "Apricot", "Plum", "Feijoa", "Watermelon", "Cranberry", "Grape", "Pomegranate", "Jujube", "Nectarine", "Raspberry", "Dragonfruit", "Kiwifruit", "Strawberry", "Olive", "Lemon", "Lychee", "Blackcurrant", "Passionfruit", "Guava", "Nance""};
            
            Stopwatch sw = Stopwatch.StartNew();
            foreach (var fruit in fruitsArray)
            {
                Console.WriteLine(fruit);
            }
            sw.Stop();
            Console.WriteLine("Operation took {0}Ticks", sw.ElapsedTicks);
        }
    }
}
