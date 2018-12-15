using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.NumberArraySum
{
    public static class ArrayHelper
    {
        public static int Sum(this int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }

            return sum;
        }

        public static double Sum(this double[] arr)
        {
            double sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }

            return sum;
        }
        public static long Sum(this long[] arr)
        {
            long sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }

            return sum;
        }

        public static float Sum(this float[] arr)
        {
            float sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }

            return sum;
        }

        public static decimal Sum(this decimal[] arr)
        {
            decimal sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }

            return sum;
        }
    }
}
