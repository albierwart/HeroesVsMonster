using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster
{
    internal class De
    {
        public De(int nbrFace)
        {
            Min = 1;
            Max = nbrFace;
        }

        public int Min { get; }
        public int Max { get;  }

        public int Lancer() {
            var rand = new Random();
            return rand.Next(1, this.Max+1);
        }
        

    }
}
