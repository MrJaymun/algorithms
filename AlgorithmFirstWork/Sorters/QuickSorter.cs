using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmFirstWork
{
    class QuickSorter : ISorter
    {
        static Random rnd = new Random();
        
        public int[] Sort(int[] unsorted)
        {
            return QuickSort(unsorted, 0, unsorted.Length - 1);
        }
        
        int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {

            if(minIndex > maxIndex)
            {
                return array;
            }

            int x = array[rnd.Next(minIndex, maxIndex+1)];
            int i = minIndex;
            int j = maxIndex-1;
            do
            {
                while (array[i] < x)
                {
                    i++;
                }
                while (array[j] > x)
                {
                    j--;
                }
                if(i <= j)
                {
                    int buf;
                    buf = array[i];
                    array[i] = array[j];
                    array[j] = buf;
                    i++;
                    j--;
                }

            }
            while (i < j);

            if (i < maxIndex)
            {
                QuickSort(array, i, maxIndex);
            }
               
            if (minIndex < j)
            {
                QuickSort(array, minIndex, j);
            }

            return array;
        }
        

    }
}
