using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmFirstWork
{
    public class SelectionSorter : ISorter
    {
        public int[] Sort(int[] unsorted)
        {
            int buf;
            int index; 
            for (int i = 0; i < unsorted.Length; i++)
            {
                index = i;
                for (int j = i; j < unsorted.Length; j++)
                {
                    if (unsorted[j] < unsorted[index])
                    {
                        index = j;
                    }
                }
                buf = unsorted[i];
                unsorted[i] = unsorted[index];
                unsorted[index] = buf;
            }
            int[] sorted = unsorted;
           
            return sorted;
        }
    }
}
