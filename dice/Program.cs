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
            Dice[] dices = new Dice[3];
            for (int i = 0; i < dices.Count(); i++)
            {
                dices[i] = new Dice();
            }
            while (true) {
                string line = Console.ReadLine();
                switch (line)
                {
                    case "q":
                        Quit();
                        break;
                    case "h":
                        Console.WriteLine(dices[0].getHisotry());
                        break;
                    default:
                        foreach (var dice in dices)
                        {
                            Console.Write(dice.Roll());
                        }
                        break;
                }                
            }
        }

        static void Quit()
        {
            Console.WriteLine("終了します");
            Console.Read();
            Environment.Exit(0);
        }
    }
}
