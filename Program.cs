﻿Random rand = new Random();
int randomNumber;
int numberOfTry;
int currentTry;
randomNumber = rand.Next(1, 50);
numberOfTry = rand.Next(1, 10);
currentTry = 0;
Console.WriteLine($"Salut ! J'ai dans ma tête un nombre entre 1 et 50. Devine lequel. Tu as {numberOfTry} essais");
while(true)
{
    if(numberOfTry == currentTry)
    {
        Console.WriteLine("Dommage, tu n'as plus d'essais");
        break;
    }

    int answer = int.Parse(Console.ReadLine());
    if (answer > randomNumber)
    {
        Console.WriteLine("C’est plus petit");
    }
    else if (answer < randomNumber)
    {
        Console.WriteLine("C’est plus grand");
    }
    else if(answer == randomNumber)
    {
        Console.WriteLine($"Bravo vous avez trouvé en {currentTry} essais.");
        break;
    }
    currentTry++;
}




