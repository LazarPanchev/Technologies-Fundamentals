using System;
using System.Collections.Generic;
using System.Linq;

namespace Files
{
    class File
    {
        public string Root { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<File>> filesPerRoot = new Dictionary<string, List<File>>();
            int numberOfFiles = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfFiles; i++)
            {

                string[] fileInfo = Console.ReadLine().Split(new char[] { '\\', ';' }, StringSplitOptions.RemoveEmptyEntries);
                string fileRoot = fileInfo[0];
                string fileName = fileInfo[fileInfo.Length - 2];
                long fileSize = long.Parse(fileInfo[fileInfo.Length - 1]);

                if (!filesPerRoot.ContainsKey(fileRoot))
                {
                    filesPerRoot[fileRoot] = new List<File>();

                }

                List<File> filesInCurrentRoot = filesPerRoot[fileRoot];

                File existingFile = filesInCurrentRoot.FirstOrDefault(f => f.Name == fileName);

                if (existingFile == null)
                {
                    File file = new File
                    {
                        Name = fileName,
                        Root = fileRoot,
                        Size = fileSize
                    };

                    filesInCurrentRoot.Add(file);
                    //filesPerRoot[fileRoot].Add(file)  the same
                  }
                else
                {
                    existingFile.Size = fileSize;
                }
            }
            string[] query = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string ext = query[0];
            string root = query[2];

            if(! filesPerRoot.ContainsKey(root))
            {
                Console.WriteLine("No");
                return;
            }

            List<File> result = filesPerRoot[root]
                .Where(f=>f.Name.EndsWith(ext))
                .OrderByDescending(f => f.Size)
                .ThenBy(f => f.Name)
                .ToList();

            if (! result.Any())
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var file in result)
                {
                    Console.WriteLine($"{file.Name} - {file.Size} KB");
                }
            }
        }
    }
}
