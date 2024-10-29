using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercice2Vacance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quelle action souhaiter vous faire (ajouter, modifier, afficher, fermer): ");
            string action = Console.ReadLine();
            do
            {
                if (action == "ajouter")
                {
                    Console.WriteLine("tu es dans ajouter");
                    Console.Write('\n');

                    Console.Write("quel est le numéro de table : ");
                    int table = Convert.ToInt32(Console.ReadLine());

                    Console.Write("combien il y a de plat : ");
                    int nbPlatTable = Convert.ToInt16(Console.ReadLine());
                    double addition = 0;

                    for (int i = 1; i < (nbPlatTable + 1); i++ )
                    {
                        Console.Write("nom du plat : ");
                        string plat/*i*/ = Console.ReadLine();

                        Console.Write("nom du prix : ");
                        double prix/*i*/ = Convert.ToDouble(Console.ReadLine());

                        Console.Write("quantité de ce plat : ");
                        int quantité/*i*/ = Convert.ToInt16(Console.ReadLine());

                        addition += prix * quantité;
                        
                    }
                    Console.WriteLine(addition);

                    Console.Write('\n');
                    Console.Write("Quelle action souhaiter vous faire (ajouter, modifier, afficher, fermer): ");
                    action = Console.ReadLine();
                }
                else if (action == "modifier")
                {
                    Console.WriteLine("tu es dans modifier");

                    Console.Write("Quelle action souhaiter vous faire (ajouter, modifier, afficher, fermer): ");
                    action = Console.ReadLine();
                }
                else if (action == "afficher")
                {
                    Console.WriteLine("tu es dans afficher");

                    Console.Write("Quelle action souhaiter vous faire (ajouter, modifier, afficher, fermer): ");
                    action = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("l'action saisie n'est pas reconnue");

                    Console.Write("Quelle action souhaiter vous faire (ajouter, modifier, afficher, fermer): ");
                    action = Console.ReadLine();
                }
            } while (action != "fermer");
            



            Console.ReadLine();
        }
    }
}
