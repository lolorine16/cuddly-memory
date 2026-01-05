int nombre = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Table de multiplication de " + nombre);

// Avec For

for (int i = 0; i <= 12; i++)
{
    int resultat = nombre * i;
    Console.WriteLine(nombre + " x " + i + " = " + resultat);
}


// Avec While
int j = 0;
while (j <= 12)
{
    int resultat = nombre * j;
    Console.WriteLine(nombre + " x " + j + " = " + resultat);
    j++;
}