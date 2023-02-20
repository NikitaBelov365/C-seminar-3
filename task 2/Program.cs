int InputInt(string message)
{
    System.Console.WriteLine($"{message}>");
    int value;
    if (int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Its not a number");
    Environment.Exit(1);
    return 0;
}

bool ValidateQuoter(int quoterNumber)
{
    if (quoterNumber > 4 || quoterNumber < 1)
    {
        System.Console.WriteLine("There is no quoter after 4 or less than 1, sorry.");
        return false;
    }
    return true;
}

(int, int) GetCoordinateInterval(int quoterNumber) 
{
    switch(quoterNumber)
    {
        case 1: return (1, 1);
        case 2: return (-1, 1);
        case 3: return (-1, -1);
        default: return (1, -1);
    }
}

int quoterInput = InputInt("Input quoter number");
if (ValidateQuoter(quoterInput))
{
    (int x, int y) = GetCoordinateInterval(quoterInput);
    System.Console.WriteLine($"Coordinates of {quoterInput} quoter is: {x}, {y}");
}