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
        static private int seed = Environment.TickCount;
        private Random rand;
        static private List<int> history = new List<int>();
        static private int[] stat = new int[7];

        public Dice(){
            rand = new Random(seed++);
        }

        public string Roll()
        {
            int result = rand.Next(1, 7);
            history.Add(result);
            stat[result]++;
            return result + " ";
        }
        public string getHisotry()
        {
            string msg = "--- 履歴 ---\n";
            foreach (var item in history)
            {
                msg += " " + item;
            }
            msg += "\n--- 統計 ---\n";
            double total = 0;
            for (int i = 1; i < 7; i++)
            {
                total += i * stat[i];
                double ratio = (double)stat[i] / history.Count;
                msg += String.Format("{0} : {1}({2:P1})\n", i, stat[i], ratio);
            }
            msg += String.Format("平均 {0:F2}" , (total / history.Count));
            return msg;
        }
    }
}
