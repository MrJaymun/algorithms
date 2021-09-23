using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmFirstWork
{
    public class BubbleSorter : ISorter
    {
        public int[] Sort(int[] unsorted)
        {
            int buf;
            
            
           
            for (int i = 0; i < unsorted.Length - 1; i++)
            {
                //Тут вычитается i потому что i последних элементов уже на месте
                for (int j = 0; j < unsorted.Length - i - 1; j++)
                {
                   
                    if (unsorted[j] > unsorted[j + 1])
                    {
                        buf = unsorted[j];
                        unsorted[j] = unsorted[j + 1];
                        unsorted[j + 1] = buf;
                    }
                    
                }
            }
            
            int[] sorted = unsorted;
            return sorted;
        }
    }
}
