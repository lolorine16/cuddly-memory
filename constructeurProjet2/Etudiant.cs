using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructeurProjet2
{
    internal class Etudiant
    {
        public string nom;
        public string prenom;
        public int age;

        public Etudiant()
        {

        }
        public Etudiant(string nom)
        {
            this.nom = nom;
        }
        public Etudiant(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }
        public Etudiant(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }
    }
}

