using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetPolymorphisme
{
    internal abstract class Forme
    {
        public string couleur { get; set; }

        class Cercle : Forme
        {
            public int rayon { get; set; }
            public override double CalculerAire()
            {
                return Math.PI * Math.Pow(rayon, 2);
            }
        }
        class Rectangle : Forme
        {

            public int longueure { get; set; }
            public int largeure { get; set; }
            public override double CalculerAire()
            {
                return longueure * largeure;
            }
        }
        class Triangle : Forme
        {
            public int baseT { get; set; }
            public int hauteur { get; set; }
            public override double CalculerAire()
            {
                return 0.5 * baseT * hauteur;
            }
        }

        //Constructeur de la classe Forme
        public string Cercle(double rayon)
        {
            base.couleur = couleur;
            return couleur;
        }


        //Méthode pour afficher les informations d'une forme
        public void Afficher()
        {
            Console.WriteLine("Couleur de la forme: " + couleur);
        }

        //Méthode pour calculer l'aire d'une forme avec un type abstrait
        public abstract double CalculerAire();
    }
}
