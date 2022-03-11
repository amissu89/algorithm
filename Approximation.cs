using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Approximation
    {
        public void find()
        {
            HashSet<String> states_needed = new HashSet<String>()
            {
                "mt", "wa", "or", "id", "nv", "ut", "ca", "az"
            };
            Console.WriteLine(states_needed.ToString());

            Dictionary<String, HashSet<String>> stations
                = new Dictionary<String, HashSet<String>>()
                {
                    {"one",     new HashSet<String>(){"id", "nv", "ut"} },
                    {"two",     new HashSet<String>(){"wa", "id", "mt"} },
                    {"three",   new HashSet<String>(){"or", "nv", "ca"} },
                    {"four",    new HashSet<String>(){"nv", "ut"} },
                    {"five",    new HashSet<String>(){"ca", "az"} }
                };
            HashSet<String> finalStations = new HashSet<String>();
           
            while(states_needed.Count > 0)
            {
                HashSet<String> states_covered = new HashSet<String>();
                string bestStation = "";

                foreach (KeyValuePair<String, HashSet<String>> item in stations)
                {
                    HashSet<String> covered = new HashSet<string>(states_needed);

                    covered.IntersectWith(item.Value);
                    if (covered.Count > states_covered.Count)
                    {
                        bestStation = item.Key;
                        foreach (var name in covered)
                        {
                            states_covered.Add(name);
                        }
                    }
                }
                states_needed.ExceptWith(states_covered);
                finalStations.Add(bestStation);
            }
            foreach(var name in finalStations)
            {
                Console.WriteLine(name + ", " );
            }
           
        }
    }
}
