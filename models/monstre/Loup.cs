using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster.models.monstre
{
    internal class Loup : Monster
    {
        public Loup(string name, De de6, De de4) : base(name, de6, de4)
        {
            Cuir = base.De4Face.Lancer();
        }
        public override string ToString()
        {
            return $"{this.Name} est un monstre Loup qui a une force de {this.Force} et une endu de {this.Endu} " +
                $"et il possede {this.Or} or et {this.Cuir}"; ;
        }
    }
}
