string[] tabAmis = new string[3];
List<string> amis = new List<string>();

Console.WriteLine("Entrez le nom de 3 amis :");
for (int i = 0; i < 3; i++)
{
    Console.Write($"Ami {i + 1} : ");
    tabAmis[i] = Console.ReadLine();
    amis.Add(tabAmis[i]);
}

Console.WriteLine("Liste des amis :");
foreach (string ami in amis)
{
    Console.WriteLine(ami);
}

// arranger la liste
amis.Sort();
Console.WriteLine("\nListe des amis triée :");
foreach (string ami in amis)
{
    Console.WriteLine(ami);
}
