using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicePropSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Random();
            Console.ReadKey();
        }
        public static int Outcome(int desire, Dice[] num)
        {
            int outcome = 0;
            for (int i = 0; i < num.Length; i++)
            {
                int value = num[i].Die1 + num[i].Die2;
                if (value==desire)
                {
                    outcome++;
                }
            }
            return outcome;
        }
        static void Random()
        {
            int x = 1;
            int y = 6;
            Dice[] num = new Dice[36];
            for (int i = 0; i < num.Length; i++)
            {
                if (i < 6)
                {
                    num[i] = new Dice { Die1 = x, Die2 = y };
                    x++;
                }else if (i < 12){
                    x--;
                    num[i] = new Dice { Die1 = x, Die2 = y - 1 };
                }
                else if (i < 18)
                {
                    num[i] = new Dice { Die1 = x, Die2 = y - 2 };
                    x++;
                }
                else if (i < 24)
                {
                    x--;
                    num[i] = new Dice { Die1 = x, Die2 = y - 3 };
                }
                else if (i < 30)
                {
                    num[i] = new Dice { Die1 = x, Die2 = y - 4 };
                    x++;
                }
                else if (i < 36)
                {
                    x--;
                    num[i] = new Dice { Die1 = x, Die2 = y - 5 };
                }
            }
            Random rand = new Random();
            int Die1 = rand.Next(1, 7);
            int Die2 = rand.Next(1,7);
            double sum = Outcome(Die1+Die2,num);
            double prop = sum/ 36.00*100.00;
            Console.WriteLine($"{Die1} + {Die2} = {Die1 + Die2}");
            Console.WriteLine($"{prop:N2} %");
        }
    }
    public class Dice
    {
        public int Die1 { get; set; }
        public int Die2 { get; set; }
    }
}
