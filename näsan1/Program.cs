for (int i = 0; i < 5; i++)
{
    string num = Console.ReadLine();
    int numInt;
    bool valid = int.TryParse(num, out numInt);
    while (valid == false)
    {
        System.Console.WriteLine("Nej, igen.");
        num = Console.ReadLine();
        valid = int.TryParse(num, out numInt);
    }

    if (numInt > 5) System.Console.WriteLine("Högre än 5!");
    else System.Console.WriteLine(":(");
}