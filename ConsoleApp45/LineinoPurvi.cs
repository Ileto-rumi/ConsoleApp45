using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    internal class LineinoPurvi
    {
        public static int LinearSearchWithTransposition(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    if (i > 0)
                    {
                        (arr[i], arr[i - 1]) = (arr[i - 1], arr[i]);
                    }
                    return i-1;
                }
            }
            return -1;
        }
    }
}
