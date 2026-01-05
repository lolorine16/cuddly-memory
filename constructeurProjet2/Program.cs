using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructeurProjet2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Etudiant etudiant1 = new Etudiant();
            etudiant1.nom = "MOROU";
            etudiant1.prenom = "Fadilou";
            etudiant1.age = 25;

            Console.WriteLine("Etudiant 1 a pour nom : " + etudiant1.nom + " pour prenom : " + etudiant1.prenom + " et pour age : " + etudiant1.age);

            Etudiant etudiant2 = new Etudiant("EKON", "Laureen");
            etudiant2.age = 22;
            Console.WriteLine("Etudiant 2 a pour nom : " + etudiant2.nom + " pour prenom : " + etudiant2.prenom + " et pour age : " + etudiant2.age);

            Etudiant etudiant3 = new Etudiant("DIOP", "Aliou", 18);
            Console.WriteLine("Etudiant 3 a pour nom : " + etudiant3.nom + " pour prenom : " + etudiant3.prenom + " et pour age : " + etudiant3.age);

        }
    }
}
