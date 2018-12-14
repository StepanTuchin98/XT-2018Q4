namespace Task1.CustomSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CustomSort
    {
        public static void Sort<T>(ref T[] col, Func<T, T, bool> compare)
        {
            for (int i = 0; i < col.Length; i++)
            {
                for (int j = 0; j < col.Length - 1; j++)
                {
                    
                    if (compare.Invoke(col[j], col[j + 1]))
                    {
                        T temp = col[j];
                        col[j] = col[j + 1];
                        col[j + 1] = temp;
                    }
                }
            }
        }
    }
}
