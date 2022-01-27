using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Game
    {
        static void Main(string[] args)
        
            public List<string> Players { get; set; }
            public string Name { get; set; }
            public string Dealer { get; set; }

            public void ListPlayers()
            {
                foreach (string player in Players)
                {
                    Console.WriteLine(player);
                }
            
        }
    }
}
