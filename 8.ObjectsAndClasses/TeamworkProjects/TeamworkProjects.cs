using System;
using System.Linq;
using System.Collections.Generic;

namespace TeamWork
{
    public class Team
    {
        public string Name { get; set; }
        public List<string> MembersInTheTeam { get; set; }
        public string CreatorName { get; set; }
    }

    public class TeamWork
    {
        public static void Main()
        {
            List<Team> teams = new List<Team>();
            int countOfTeams = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfTeams; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string name = input[0];
                string teamName = input[1];

                if (teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");

                }
                else
                {
                    if (teams.Any(x => x.CreatorName == name))
                    {
                        Console.WriteLine($"{name} cannot create another team!");

                    }

                    else
                    {
                        Team team = new Team();
                        team.CreatorName = name;
                        team.Name = teamName;
                        List<string> members = new List<string>();
                        team.MembersInTheTeam = members;
                        teams.Add(team);
                        Console.WriteLine($"Team {team.Name} has been created by {team.CreatorName}!");
                    }

                }
            }

            string secInput = Console.ReadLine();
            string nameJoiners;
            string teamToJoin;
            while (secInput != "end of assignment")
            {
                string[] joiners = secInput.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                nameJoiners = joiners[0];
                teamToJoin = joiners[1];
                if (!teams.Any(x => x.Name == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else if (teams.Any(x => x.MembersInTheTeam.Contains(nameJoiners)) || teams.Any(x => x.CreatorName == nameJoiners))
                {
                    Console.WriteLine($"Member {nameJoiners} cannot join team {teamToJoin}!");
                }

                else
                {
                    foreach (var squad in teams.Where(x => x.Name == teamToJoin))
                    {
                        squad.MembersInTheTeam.Add(nameJoiners);
                    }
                }

                secInput = Console.ReadLine();
            }


            foreach (var squad in teams.Where(x => x.MembersInTheTeam.Count != 0)
                .OrderByDescending(x => x.MembersInTheTeam.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{squad.Name}");
                Console.WriteLine($"- {squad.CreatorName}");
                foreach (var member in squad.MembersInTheTeam.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var squad in teams.Where(x => x.MembersInTheTeam.Count == 0).OrderBy(x => x.Name))
            {
                Console.WriteLine($"{squad.Name}");
            }
        }

    }

}