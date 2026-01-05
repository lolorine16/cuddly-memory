using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetPolymorphisme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création d'une instance de Cercle
            Forme.Cercle cercle = new Forme.Cercle();
            cercle.rayon = 5;

            //Console.WriteLine("Rayon du cercle: " + cercle.rayon);

            // Création d'une instance de Rectangle
            Forme.Rectangle rectangle = new Forme.Rectangle();
            rectangle.longueure = 10;
            rectangle.largeure = 5;

            //Console.WriteLine("Longueur du rectangle: " + rectangle.longueure);
            //Console.WriteLine("Largeur du rectangle: " + rectangle.largeure);
            
            // Création d'une instance de Triangle
            Forme.Triangle triangle = new Forme.Triangle();
            triangle.baseT = 8;
            triangle.hauteur = 6;

            //Console.WriteLine("Base du triangle: " + triangle.baseT);
            //Console.WriteLine("Hauteur du triangle: " + triangle.hauteur);

            // Calcule de l'aire des formes avec calculAire()
            CalculAire calculAire = new CalculAire();
            double aireCercle = calculAire.CalculerAireCercle(cercle.rayon);



        }
    }
}
