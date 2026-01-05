// See https://aka.ms/new-console-template for more information

// declaration des variables
int a = 5;
int b = 10;


// opeations arithmetiques
int somme = a + b;
int produit = a * b;
int difference = b - a;
double moyenne = (a + b) / 2.0;

// somme
Console.WriteLine($"La somme est {somme}");
// produit
Console.WriteLine($"Le produit est {produit}");
// difference
Console.WriteLine($"La difference est {difference}");
// moyenne
Console.WriteLine($"La moyenne est {moyenne}");


// modulo

if (a > b)
{ 
    double modulo = a % b;
    Console.WriteLine("a est plus grand que b");
    Console.WriteLine($"le reste de la division est {modulo}");
}
else
{ 
    double modulo = b % a;
    Console.WriteLine("a est plus petit que b");
    Console.WriteLine($"le reste de la division esr {modulo}");
}
