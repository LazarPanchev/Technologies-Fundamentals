namespace NoteStatistics
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class NoteStatistics
    {
        public static void Main()
        {
            List<double> inputList = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            List<string> naturals = new List<string>();
            List<string> sharps = new List<string>();
            List<string> allNotes = new List<string>();
            string[] note = new string[12]
            { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

            double[] frequency = new double[]
            { 261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00,
            466.16, 493.88};

            for (int i = 0; i < inputList.Count; i++)
            {
                int index = Array.IndexOf(frequency, inputList[i]);
                string currentNote = note[index];
                allNotes.Add(currentNote);
                
                if (currentNote.Length>1)
                {
                    sharps.Add(currentNote);
                }

                else
                {
                    naturals.Add(currentNote);
                }
                
            }
            double sumNaturals= SumElements(naturals, note, frequency);
            double sumSharps= SumElements(sharps, note, frequency);

            Console.WriteLine("Notes: {0}",string.Join(" ", allNotes));
            Console.WriteLine("Naturals: {0}", string.Join(", ",naturals));
            Console.WriteLine("Sharps: {0}", string.Join(", ", sharps));
            Console.WriteLine("Naturals sum: {0}", sumNaturals);
            Console.WriteLine("Sharps sum: {0}", sumSharps);
        }

        private static double SumElements(List<string> list,string[] note, double[] frequency)
        {
            double sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                int index = Array.IndexOf(note, list[i]);
                double currentNum = frequency[index];
                sum += currentNum;
            }

            return sum;
        }
    }
}
