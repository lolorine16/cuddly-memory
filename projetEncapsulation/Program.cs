using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace projetEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creation d'un objet etudiant
            Etudiant etudiant1 = new Etudiant();
            etudiant1.Nom = "Dupont";
            etudiant1.prenom = "Jean";
            // Affichage des informations de l'etudiant
            Console.WriteLine(Etudiant.AfficherInformation(etudiant1));

        }
    }
}
