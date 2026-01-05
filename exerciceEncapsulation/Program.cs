using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire compte = new CompteBancaire("Alice", 123455, 1000.0);

            compte.AfficherSolde();
            compte.Crediter(500);
            compte.Debiter(200);
            //compte.Debiter(2000);
            compte.AfficherSolde();
        }
    }
}
