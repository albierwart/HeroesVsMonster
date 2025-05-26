using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster.models
{
    internal class Personnage
    {
        
        public Personnage(string name)
        {
            Name = name;
            Force = CalculStat();
            Endu = CalculStat();
            PointDeVie = Endu+
        }
        public string Name { get; set; }
        public int Endu {  get; set; }
        public int Force { get; set; }

        public int PointDeVie { get; set; }

        public int CalculStat()
        {
            int stat=0;
            var rand = new Random();
            int [] nbr = new int [4];
            for (int i = 0; i < 4; i++) {
                nbr[i] = rand.Next(1, 7);
            }          
            Array.Sort(nbr);
            for (int i = 1; i < 4; i++)
            {
                stat +=nbr[i];
            }
                return stat;
        }

        public int CalculModificateur(int stat) {
            switch (stat) {
                case <5: stat -= 1;

                    break;
            
            
            }
            return stat;
        }
       


    }
}
