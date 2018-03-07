using System;
using System.Collections.Generic;
using System.Linq;


namespace EnduranceRally
{
    class Participant
    {
        public string Name { get; set; }
        public string Song { get; set; }
        public HashSet<string> Awards { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Participant> participantsList = new List<Participant>();
            string[] participants = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string[] availableSongs = Console.ReadLine().Split(',').Select(x=>x.Trim()).ToArray();
            string input = Console.ReadLine();
            while (input != "dawn")
            {
                string[] tokens = input.Split(',').Select(x => x.Trim()).ToArray();
                string performerName = tokens[0];
                string performedSong = tokens[1];
                string winAward = tokens[2];

                Participant currentParticipant = new Participant
                {
                    Name = performerName,
                    Song = performedSong,
                    Awards = new HashSet<string>()
                };


                
                if(participants.Contains(performerName))             
                {
                    if(availableSongs.Contains(performedSong))
                    {
                        Participant existedParticipant = participantsList
                        .FirstOrDefault(x => x.Name == performerName && x.Song == performedSong);
                        if(existedParticipant == null)
                        {
                            
                                currentParticipant.Awards.Add(winAward);
                                participantsList.Add(currentParticipant);
                            
                        }
                        else
                        {
                            if (existedParticipant.Name == performerName)
                            {
                                existedParticipant.Awards.Add(winAward);
                            }
                        }
                    }        
                }

                input = Console.ReadLine();
            }
            if (participantsList.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (Participant participant in participantsList.OrderByDescending(x => x.Awards.Count).ThenBy(x => x.Name))
                {
                    if(participant.Awards.Count==0)
                    {
                        Console.WriteLine("No awards");
                        break;
                    }
                    Console.WriteLine($"{participant.Name}: {participant.Awards.Count} awards");
                    foreach (var item in participant.Awards.OrderBy(x=>x))
                    {
                        Console.WriteLine($"--{item}");
                    }
                }

            }
        }
    }
}
