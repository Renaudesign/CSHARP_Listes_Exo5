using System;
using System.Collections.Generic;

namespace CSHARP_Listes_Exo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> fujita =
                new Dictionary<string, string>();
            fujita.Add("F0", "\nDégâts légers : certains dommages sont subis par les cheminées, les antennes de télévision, les bardeaux, les arbres, les enseignes et les fenêtres.");
            fujita.Add("F1", "\nDégâts modérés : les automobiles sont renversées, les abris pour automobiles détruits et les arbres déracinés.");
            fujita.Add("F2", "\nDégâts importants : les toits sont arrachés par le vent, les hangars et les dépendances sont démolies et les maisons mobiles sont renversées.");
            fujita.Add("F3", "\nDégâts considérables : les murs extérieurs et les toits sont projetés dans les airs, les maisons et les bâtiments de métal s'effondrent ou subissent des dégâts| importants, les forêts et les récoltes sont abattues.");
            fujita.Add("F4", "\nDégâts dévastateurs : même dans les habitations solides, l'essentiel des murs, sinon tous, s'effondrent ; tels des missiles, de gros objets en acier ou en béton sont projetés à grandes distances.");
            fujita.Add("F5", "\nDégâts incroyables : les maisons sont rasées ou projetées sur de grandes distances. Les tornades F5 peuvent causer des dommages très importants à de grosses structures telles que les écoles et les motels et peuvent arracher les murs extérieurs et les toits(parfois surnommé « le doigt de Dieu ».");
            

            Console.WriteLine("Utilisateur, veuillez indiquer le type de tornade dont vous souhaitez avec une description de dégâts, selon le tableau Fujita." +
                                "Les types de tornades sont F0, F1, F2, F3, F4 et F5");

            string input = Console.ReadLine();
            Console.WriteLine(fujita[input]);
        }
    }
}

