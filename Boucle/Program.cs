// See https://aka.ms/new-console-template for more information

string[] fruits = new string[3];

// parcourir avec for
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Entrez le nom du fruit N*{i + 1}: ");
    string? input = Console.ReadLine();
    fruits[i] = input ?? string.Empty;
}

Console.WriteLine("-----");
Console.WriteLine("Voici la liste des fruits:");

// parcourir avec foreach
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

Console.WriteLine("-----");
Console.WriteLine("Voici la liste des fruits triés (ordre croissant):");

// Affichage des fruits par ordre croissant
Array.Sort(fruits);
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

Console.WriteLine("-----");
Console.WriteLine("Voici la liste des fruits triés (ordre décroissant):");

// Affichage des fruits par ordre décroissant
Array.Reverse(fruits);
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

// choix d'un fruit par son index
Console.WriteLine("-----");
Console.WriteLine("Entrer votre fruit preferer: ");
string? choiceInput = Console.ReadLine();
int index = Array.IndexOf(fruits, choiceInput);

Console.WriteLine("L'index du fruit choisi est: ");
Console.WriteLine(index);