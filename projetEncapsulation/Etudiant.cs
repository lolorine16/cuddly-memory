using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetEncapsulation
{
    internal class Etudiant
    {
        // Creer un attribut prive nom de type string
        private string nom;
        // Creer un attribut publique prenom de type string
        public string prenom;

        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }

        //Constructeur sans parametre
        public Etudiant()
        {
            
        }

        // Creation de la methode AfficherInformation()
        public static string AfficherInformation(Etudiant etudiant)
        {
            return "Nom: " + etudiant.Nom;
        }

    }
}
