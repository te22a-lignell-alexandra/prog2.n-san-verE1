// for (int i = 0; i < 5; i++)
// {
//     string num = Console.ReadLine();
//     int numInt;
//     bool valid = int.TryParse(num, out numInt);
//     while (valid == false)
//     {
//         System.Console.WriteLine("Nej, igen.");
//         num = Console.ReadLine();
//         valid = int.TryParse(num, out numInt);
//     }

//     if (numInt > 5) System.Console.WriteLine("Högre än 5!");
//     else System.Console.WriteLine(":(");
// }

int secretNumber = Random.Shared.Next(100);

while (true)
{
    System.Console.WriteLine("Guess a number between 0-100\n");
    string guess = Console.ReadLine();
    int guessedNumber = 0;
    bool valid = int.TryParse(guess, out guessedNumber);

    while (valid == false)
    {
        System.Console.WriteLine("\nNo. A number between 0-100");
        guess = Console.ReadLine();
        valid = int.TryParse(guess, out guessedNumber);
    }

    if (guessedNumber < secretNumber)
    {
        System.Console.WriteLine("Too low. Try again");
    }
    else if (guessedNumber > secretNumber)
    {
        System.Console.WriteLine("Too high. Try again");
    }
    else if (guessedNumber == secretNumber)
    {
        System.Console.WriteLine("Correct!");
        break;
    }
}

Console.ReadLine();