using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmFirstWork
{
    class FileWorker : IFileWorker
    {
        public int[] GetData(string fileName)
        {
            try
            {
                var file = new StreamReader(fileName);
                int size = Convert.ToInt32(file.ReadLine());
                string result = file.ReadLine();
                var allValues = result.Split(' ');
                int i = 0;
                int[] unsorted = new int[size];
                foreach (var value in allValues)
                {
                    unsorted[i] = Convert.ToInt32(value);
                    i++;
                }

                return unsorted;
            }
            catch(Exception e)
            {
                return null;
            }
           
        }

        public void SaveData(int[] sorted, string fileName)
        {
            var file = new StreamWriter(fileName);
            string str = "";
            for (int i = 0; i < sorted.Length; i++)
            {
                if(i != sorted.Length - 1)
                {
                    str = str + sorted[i] + " ";
                }
                else
                {
                    str = str + sorted[i];
                }
            }
            file.Write(str);
            file.Close();
        }
    }
}
