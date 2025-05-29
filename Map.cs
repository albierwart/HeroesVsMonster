using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster
{
    internal class Map
    {
        public string Name { get; set; }
        public char[,] _map = new char[15,15];

        public Map(char[,] map)
        {
            this._map = map;
        }

        public void RemplirMap() {
            
            for (int i = 0; i < _map.GetLength(0); i++) {
                
                for (int j = 0; j < _map.GetLength(1); j++)
                {
                    _map[i, j] = '.';
                }
            
            }
        }

        public void AfficherMap()
        {
            for (int i = 0; i < _map.GetLength(0); i++)
            {
                for (int j = 0; j < _map.GetLength(1); j++)
                {
                    Console.Write(_map[i, j] + " "); 
                }
                Console.WriteLine();

            }
        }
    }
}
