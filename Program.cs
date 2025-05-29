using HeroesVsMonster.models;
using HeroesVsMonster.models.heros;
using HeroesVsMonster.models.monstre;

namespace HeroesVsMonster
{
    internal class Program
    {
        static void Main(string[] args)
        {
             De de6face = new De(6);
             De de4face = new De(4);
            /*
             Nain gimli = new Nain("gimli", de6face, de4face);
             Nain ungrim = new Nain("ungrim", de6face, de4face);
             Nain thorgrim = new Nain("thorgrim", de6face, de4face);
             Humain aragorn = new Humain("aragorn", de6face, de4face);
             Humain boromir = new Humain("boromir", de6face, de4face);
             Orc grimgor = new Orc("grimgor", de6face, de4face);
             Loup oeilDeNuit = new Loup("oeilDeNuit", de6face, de4face);
             Dragonnet dragon = new Dragonnet("dragon", de6face, de4face);

             Console.WriteLine(gimli);
             Console.WriteLine(ungrim);
             Console.WriteLine(thorgrim);
             Console.WriteLine(aragorn);
             Console.WriteLine(boromir);
             Console.WriteLine(oeilDeNuit);
             Console.WriteLine(grimgor);
             Console.WriteLine(dragon);*/

            Humain aragorn = new Humain("aragorn", de6face, de4face);
            char[,] tab = new char[15,15];
            Map map = new Map(tab);
            map.RemplirMap();
            aragorn.PlacerOnMap(tab);
            map.AfficherMap();

        }
    }
}
