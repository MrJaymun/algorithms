using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmFirstWork
{
    public class InsertSorter : ISorter
    {
        public int[] Sort(int[] unsorted)
        {
            int currentValue;
            int j;
            int buf;
            for (int i = 1; i < unsorted.Length; i++)
            {
                currentValue = unsorted[i];
                j = i;
                while (j > 0 && unsorted[j - 1] > currentValue)
                {
                    buf = unsorted[j];
                    unsorted[j] = unsorted[j-1];
                    unsorted[j-1] = buf;
                    j -= 1;
                }
                unsorted[j] = currentValue;
            }
            int[] sorted = unsorted; 
            return sorted;
        }
    }
}
