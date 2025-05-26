using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster.models.monstre
{
    internal class Dragonnet : Monster
    {
        public Dragonnet(string name, De de6, De de4) : base(name, de6, de4)
        {
            Or = base.De6Face.Lancer();
            Cuir = base.De4Face.Lancer();
            Endu = base.Endu + 1;
        }
        public override string ToString()
        {
            return $"{this.Name} est un monstre Dragonnet qui a une force de {this.Force} et une endu de {this.Endu} " +
                $"et il possede {this.Or} or et {this.Cuir}"; ;
        }
    }
}
