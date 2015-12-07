using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            Console.WriteLine(dice.roll());
        }
    }
}
