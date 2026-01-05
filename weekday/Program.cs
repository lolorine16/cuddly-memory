
//

Console.WriteLine("Veuillez entrer un nombre (compris entre 1 et 7):");
int days = Convert.ToInt32(Console.ReadLine());

//jours de la semaine a partir du nombre

switch (days)
{
    case 1:
        Console.WriteLine("Lundi"); 
        break;
    case 2: 
        Console.WriteLine("Mardi");
        break;
    case 3: 
        Console.WriteLine("Mercredi");
        break;
    case 4: 
        Console.WriteLine("Jeudi");
        break;
    case 5: 
        Console.WriteLine("Vendredi");
        break;
    case 6: 
        Console.WriteLine("Samedi");
        break;
    case 7: 
        Console.WriteLine("Dimaanche");
        break;
    default: 
        Console.WriteLine("ne correspond a aucun jours de la semaine");
        break;
}