using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice
{
    class Player
    {
        public int Point { get; set; }
        public Player()
        {
            Point = 1000;
        }
        public string setResult(int[] diceResult)
        {
            string msg = "";
            Array.Sort(diceResult);
            if (diceResult[0] == diceResult[1] && diceResult[1] == diceResult[2])
            {
                Point += 150;
                msg += "ぞろ目";
            }
            else if (diceResult[0] == 1 && diceResult[1] == 2 && diceResult[2] == 3) // 1,2,3
            {
                Point -= 100;
                msg += "　123 ";
            }
            else if (diceResult[0] == 4 && diceResult[1] == 5 && diceResult[2] == 6) // 4,5,6
            {
                Point += 250;
                msg += "　456 ";
            }
            else
            {
                Point -= 50;
                msg += "　負け";
            }
            msg += Point + "点";
            return msg;
        }
    }
}
