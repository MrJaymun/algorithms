using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmFirstWork
{
    interface IFileWorker
    {

        int[] GetData(string fileName);

        void SaveData(int[] sorted, string fileName);
    }
}
