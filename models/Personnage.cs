using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesVsMonster.models.heros;
using HeroesVsMonster.models.monstre;

namespace HeroesVsMonster.models
{
    internal class Personnage
    {
  

        public Personnage(string name, De de6  , De de4)
        {
            var rand = new Random();
            De6Face = de6;
            De4Face = de4;
            Name = name;
            Force = CalculStat()+ ModiForce();
            Endu = CalculStat() + ModifEndu();
            PV = CalculModificateur(Endu);
            X = rand.Next(0,14);
            Y = rand.Next(0,14);
        }

     
        public int X {  get; set; }
        public int Y { get; set; }
        public De De6Face { get; set; }
        public De De4Face { get; set; }

        public string Name { get; set; }
        public int Endu {  get;  }
        public int Force { get;  }
        public int PV { get;  }

        public int Or { get; set; }
        public int Cuir { get; set; }

        public int ModifEndu() { 
       
            switch (this.GetType()) {
                case typeof(Humain): return 1;
                    break;
                case typeof(Dragonnet): return 1;
                    break;
                case typeof(Nain):  return 2;
                    break;

                default: return 0;
                    break;
            }
        }
        public int ModiForce() {
            switch (this.GetType())
            {
                case typeof(Humain): return 1;
                    break;
                case typeof(Orc): return 1;
                    break;
                default:
                    return 0;
                    break;
            }
        }
        public int Frappe() {           
            return De4Face.Lancer() + CalculModificateur(Force); ;
        }
        public int CalculModificateur(int stat) {
            switch (stat) {
                case <5: stat -= 1;
                    break;                
                case < 10 and < 15 : stat+=1;
                    break;
                default : stat+=2;
                    break;
            
            }
            return stat;
        }
        public int CalculStat()
        {
            int stat = 0;
            int[] nbr = new int[4];
            for (int i = 0; i <= 3; i++)
            {
                nbr[i] = De6Face.Lancer();
            }
            Array.Sort(nbr);
            for (int i = 1; i <= 3; i++)
            {
                stat += nbr[i];
            }
            return stat;
        }


    }
}
