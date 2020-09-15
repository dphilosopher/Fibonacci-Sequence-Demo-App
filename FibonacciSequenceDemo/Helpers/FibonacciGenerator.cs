using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequenceDemo.Helpers
{
    public static class FibonacciGenerator
    {
        public static int[] GenerateSequence(int maxValue)
        {
            List<int> sequences = new List<int>();
            int a = 0, b = 1, c = 0;

            sequences.Add(a);
            sequences.Add(b);

            for (int i = 2; i < maxValue; i++)
            {
                c = a + b;                
                a = b;
                b = c;
                
                if (c == maxValue)
                {
                    sequences.Add(c);
                    break;
                }
                    

                sequences.Add(c);
            }

            return sequences.ToArray();
        }

        public static int[] GenerateSequence(string maxValue)
        {
            int value = Convert.ToInt32(maxValue);

            List<int> sequences = new List<int>();
            int a = 0, b = 1, c = 0;

            sequences.Add(a);
            sequences.Add(b);

            for (int i = 2; i < value; i++)
            {
                c = a + b;
                a = b;
                b = c;

                if (c >= value)
                {
                    sequences.Add(c);
                    break;
                }

                sequences.Add(c);
            }

            return sequences.ToArray();
        }
    }
}
