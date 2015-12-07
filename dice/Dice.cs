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
        public int Roll()
        {
            int result = rand.Next(1, 7);
            history.Add(result);
            return result;
        }
        public string getHisotry()
        {
            string msg = "";
            foreach (var item in history)
            {
                msg += " " + item;
            }
            return msg;
        }
    }
}
