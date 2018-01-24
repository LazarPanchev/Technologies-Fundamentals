namespace TrackDownloader
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class TrackDownloader
    {
        public static void Main()
        {

            string[] blackList = Console.ReadLine().Split();
            string fileNames = Console.ReadLine(); 

            List<string> result = new List<string>();
            
            while(fileNames != "end")
            {
                bool inBlackList = false;
                foreach (var blackListedWord in blackList)
                {
                    if (fileNames.Contains(blackListedWord)) 
                    {
                        inBlackList = true;
                        break;
                    }            
                }

                if(!inBlackList)
                {
                    result.Add(fileNames);
                }

                fileNames = Console.ReadLine();
            }

            result.Sort();
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}
