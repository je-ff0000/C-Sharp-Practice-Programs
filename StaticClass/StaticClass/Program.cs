using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
   public static class MinMaxCalc
    {
        public static int CalculateMax(int[] arrNum)
        {
            int max = arrNum[0];

            for(int i = 1; i < arrNum.Length; i++)
            {
                if (arrNum[i] > max)
                    max = arrNum[i];
            }
            return max;
        }

        public static int CalculateMin(int[] arrNum)
        {
            int min = arrNum[0];

            for (int i = 1; i < arrNum.Length; i++)
            {
                if (arrNum[i] < min)
                    min = arrNum[i];
            }
            return min;
        }
        static void Main(string[] args)
        {
            int[] arr = { 31, 23, 29, 32, 22, 7, 47 };

            int max = MinMaxCalc.CalculateMax(arr);
            int min = MinMaxCalc.CalculateMin(arr);

            Console.WriteLine("Max value: {0} Min value: {1}", max, min);

            Console.ReadKey();
        }
    }
}
