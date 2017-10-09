using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {

            Random ran = new Random();

            int D4 = ran.Next(1, 7);
            int D6 = ran.Next(1, 7);
            int D8 = ran.Next(1, 7);
            int D10 = ran.Next(1, 7);
            int D12 = ran.Next(1, 7);
            int D20 = ran.Next(1, 7);

            Console.WriteLine("Welcome");

            Player stuff = new Player();
            stuff.Stuff();

                
            Console.WriteLine("Roll {0}", D4);
            Console.WriteLine("Roll {0}", D6);
            Console.WriteLine("Roll {0}", D8);
            Console.WriteLine("Roll {0}", D10);
            Console.WriteLine("Roll {0}", D12);
            Console.WriteLine("Roll {0}", D20);

            Console.WriteLine("The total score is {0}", D4 + D6 + D8 + D10 + D12 + D20);

           Console.ReadLine();    
    }
}
    }





