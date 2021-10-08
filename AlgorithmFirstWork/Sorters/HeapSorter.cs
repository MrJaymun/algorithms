using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmFirstWork
{
    class HeapSorter : ISorter
    {
        public int[] Sort(int[] unsorted)
        {
            
            for (int i = unsorted.Length/2 - 1; i >= 0; i--)
            {
                Heapify(unsorted, unsorted.Length, i);
            }

            for (int i = unsorted.Length - 1; i >= 0; i--)
            {
               
                int buf = unsorted[0];
                unsorted[0] = unsorted[i];
                unsorted[i] = buf;
 
                Heapify(unsorted, i, 0);
            }
            return unsorted;
        }

        void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            
            int l = 2 * i + 1; 
            int r = 2 * i + 2; 

         
            if (l < n && arr[l] > arr[largest])
            {
                largest = l;
            }

            
            if (r < n && arr[r] > arr[largest])
            {
                largest = r;
            }

            if (largest != i)
            {
                int buf = arr[i];
                arr[i] = arr[largest];
                arr[largest] = buf;
    
                Heapify(arr, n, largest);
            }
        }
    }
}
