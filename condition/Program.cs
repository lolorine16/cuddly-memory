// See https://aka.ms/new-console-template for more information

int num;
Console.WriteLine("Entrez un nombre entier : ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0 && num != 0) // si le reste de la division du nombre est nulle
{
    Console.WriteLine("Ce nombre est paire");
}
else if (num == 0) // si le nombre est null 
{
    Console.WriteLine("Le nombre est nul");
}
else // au cas contraire
{
    Console.WriteLine("Ce nombre est impaire");
}