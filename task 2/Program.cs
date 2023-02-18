int InputInt(string message)
{
    System.Console.WriteLine($"{message}>");
    if (int.TryParse(Console.ReadLine(), out int value))
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
        System.Console.WriteLine(("There is no quoter after 4 or less than 1, sorry."));
        return false;
    }
    return true;
}

string GetCoordinateInterval(int quoterNumber) 
{
    switch(quoterNumber)
    {
        case 1: return "x > 0, y > 0";
        case 2: return "x < 0, y > 0";
        case 3: return "x < 0, y < 0";
        default: return "x > 0, y < 0";
    }
}

int quoterInput = InputInt("Input quoter number");
if (ValidateQuoter(quoterInput))
{
    System.Console.WriteLine($"Coordinates of {quoterInput} quoter is: {GetCoordinateInterval}");
}