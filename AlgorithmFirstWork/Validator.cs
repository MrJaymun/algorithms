using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmFirstWork
{
    class Validator
    {
  
        public string CheckFileName(string fileName)
        {
            if (fileName.EndsWith(".txt"))
            {
                return fileName;
            }
            else
            {
                return fileName + ".txt";
            }

        }

        public bool IsFileExist(string fileName)
        {
            if (File.Exists(fileName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
     

    }
}
