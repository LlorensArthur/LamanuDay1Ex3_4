Random rand = new Random();
int randomNumber;
int numberOfTry;
int currentTry;
randomNumber = rand.Next(1, 50);
numberOfTry = rand.Next(1, 10);
currentTry = 0;
// Annonce des règles du jeu
Console.WriteLine($"Salut ! J'ai dans ma tête un nombre entre 1 et 50. Devine lequel. Tu as {numberOfTry} essais");
// Boucle du jeu
while(true)
{
    // Game over
    if (numberOfTry == currentTry)
    {
        Console.WriteLine("Dommage, tu n'as plus d'essais");
        break;
    }
    // Vérification de la saisie. Tant que l'utilisateur ne rentre pas un nombre, affiche un message demandant un nombre.
    int answer = 0;
    while (!int.TryParse(Console.ReadLine(), out answer))
    {
        Console.WriteLine("Veuillez entrer uniquement un nombre.");
    }
    // Vérifie si le nombre utilisateur est supérieur puis inférieur au nombre choisi par le programme
    if (answer > randomNumber)
    {
        Console.WriteLine("C’est plus petit");
      }
    else if (answer < randomNumber)
    {
        Console.WriteLine("C’est plus grand");
    }
    // Condition de victoire : le nombre utlilisateur est égal au nombre choisi par le programmer
    else if (answer == randomNumber)
    {
        Console.WriteLine($"Bravo vous avez trouvé en {currentTry} essais.");
        break;
    }
    currentTry++;
}




