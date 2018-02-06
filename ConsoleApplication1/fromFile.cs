using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class FromFile
    {
        public int[] getNumb() {
           string text= readFromFile();
            string[] str = text.Split('|');
            int[] arr = Array.ConvertAll<string, int>(str, int.Parse);
            return arr;
      }
            
        public string readFromFile()
        {
            string fileStr = "";
            using (StreamReader sr = new StreamReader("f.txt"))
                fileStr = sr.ReadLine();
            return fileStr;
                }
        
    }
}


