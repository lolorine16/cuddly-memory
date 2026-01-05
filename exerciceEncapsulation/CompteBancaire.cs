using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceEncapsulation
{
    internal class CompteBancaire
    {
        // Attributs
        private string proprietaire;
        private int numeroCompte;
        private double solde;
        // Constructeur
        public CompteBancaire(string proprietaire, int numeroCompte, double soldeInitial)
        {
            this.proprietaire = proprietaire;
            this.numeroCompte = numeroCompte;
            this.solde = soldeInitial;
        }
        // Méthodes
        public void Crediter(double montant)
        {
            if (montant > 0)
            {
                solde += montant;
                Console.WriteLine($"Dépôt de {montant} effectué. Nouveau solde : {solde}");
            }
            else
            {
                Console.WriteLine("Le montant du dépôt doit être positif.");
            }
        }
        public void Debiter(double montant)
        {
            if (montant > 0 && montant <= solde)
            {
                solde -= montant;
                Console.WriteLine($"Retrait de {montant} effectué. Nouveau solde : {solde}");
            }
            else
            {
                Console.WriteLine("Fonds insuffisants ou montant invalide pour le retrait.");
            }
        }
        public void AfficherSolde()
        {
            Console.WriteLine($"Le solde du compte {numeroCompte} de {proprietaire} est : {solde}");
        }
    }
}
