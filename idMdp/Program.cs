
//Authentification

/*
Console.WriteLine("Veuillez entrer votre identifiant :");
string identifiant = Console.ReadLine();

Console.WriteLine("Veuilez entrer votre mot de passe :");
string motDePasse = Console.ReadLine();

if (identifiant == "admin" && motDePasse == "admin123")
{
    Console.WriteLine("Connexion réussie !");
}
else
{
    Console.WriteLine("Échec de connexion.");
}
*/

// Verifation de majorite

Console.WriteLine("Enter votre age :");
int age = Convert.ToInt32(Console.ReadLine());

if(age == 0)
{
    Console.WriteLine("Age incorrecte");
}
else if (age <= 18)
{
    Console.WriteLine("Vous n'etes pas majeur");
}
else
{
    Console.WriteLine("Vous etes majeur");
}