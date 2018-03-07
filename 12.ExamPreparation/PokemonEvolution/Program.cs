using System;
using System.Linq;
using System.Collections.Generic;

namespace PokemonEvolution
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string EvolutionType { get; set; }
        public int EvolutionIndex { get; set; }
    }


    public class Program
    {
        public static void Main()
        {
            Dictionary<string, List<Pokemon>> dictPokemons = new Dictionary<string, List<Pokemon>>();
            string input = Console.ReadLine();
            while (input!= "wubbalubbadubdub")
            {
                string[] tokens = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                if(tokens.Length>1)
                {
                    string pokemonName = tokens[0];
                    string pokemonType = tokens[1];
                    int evolutionIndex = int.Parse(tokens[2]);

                    Pokemon currentPokemon = new Pokemon();
                    currentPokemon.Name = pokemonName;
                    currentPokemon.EvolutionType = pokemonType;
                    currentPokemon.EvolutionIndex = evolutionIndex;

                    if(! dictPokemons.ContainsKey(pokemonName))
                    {
                        dictPokemons[pokemonName] = new List<Pokemon>();
                    }

                    dictPokemons[pokemonName].Add(currentPokemon);
                }

                else
                {
                    string pokemonName = tokens[0];
                    if(dictPokemons.ContainsKey(pokemonName))
                    {
                        Console.WriteLine("# "+pokemonName);
                        foreach (var item in dictPokemons[pokemonName])
                        {
                            Console.WriteLine($"{item.EvolutionType} <-> {item.EvolutionIndex}");
                        }
                    }
                }


                input = Console.ReadLine();
            }

            foreach (var item in dictPokemons.OrderBy(x=>x))
            {
                Console.WriteLine($"# {item.Key}");
                foreach (var pair in dictPokemons[item.Key].OrderByDescending(item.Value.))
                {

                }
            }
        }
    }
}
