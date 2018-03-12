using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Demo
{
    public class Program
    {
        public static void Main()
        {
            string[] files = Directory.GetFiles("lazartext");
            double sum = 0;

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;

            }
            sum = sum / 1024 / 1024;
            File.WriteAllText("output.txt", sum.ToString());
        }
    }
}
