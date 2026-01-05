
Dictionary<string, string> bibliotheque = new Dictionary<string, string>();

// livre et genre
bibliotheque.Add("1984", "Roman");
bibliotheque.Add("Le Petit Prince", "Conte");
bibliotheque.Add("Harry Potter", "Fantasy");
bibliotheque.Add("Le Cid", "Tragédie");

foreach (var i in bibliotheque)
{
    Console.WriteLine($"Cle: '{i.Key}'Valeur: '{i.Value}'.");
}

//modification d'une valeure
bibliotheque["1984"] = "Dystopie";

foreach (var i in bibliotheque)
{
    Console.WriteLine($"Cle: '{i.Key}'Valeur: '{i.Value}'.");
}