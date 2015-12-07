using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace dice
{
    
    class Dice
    {
        private Random rand = new Random();
        private List<int> history = new List<int>();
        private int[] stat = new int[7];

        public int Roll()
        {
            int result = rand.Next(1, 7);
            history.Add(result);
            stat[result]++;
            return result;
        }
        public string getHisotry()
        {
            string msg = "--- 履歴 ---\n";
            foreach (var item in history)
            {
                msg += " " + item;
            }
            msg += "\n--- 統計 ---\n";
            for (int i = 1; i < 7; i++)
            {
                msg += i + " : " + stat[i] + "回\n";
            }
            return msg;
        }
    }
}
