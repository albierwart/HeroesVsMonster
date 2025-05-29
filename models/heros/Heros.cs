using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesVsMonster.models.monstre;

namespace HeroesVsMonster.models.heros
{
    internal class Heros : Personnage
    {
        public Heros(string name, De de6, De de4) : base(name, de6, de4)
        {
        }

        public void Depouiller(Monster monster) {
            this.Cuir += monster.Cuir;
            this.Or += monster.Or;
        }
    }
}
