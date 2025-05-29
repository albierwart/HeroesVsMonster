using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster.models.heros
{
    internal class Nain : Heros
    {
        public Nain(string name, De de6, De de4) : base(name, de6, de4)
        {
            
        }

        public override string ToString()
        {
            return $"{this.Name} est un heros nain qui a une force de {this.Force} et une endu de {this.Endu} " +
                $"il possede {this.Or} or et {this.Cuir}";
        }
    }
}
