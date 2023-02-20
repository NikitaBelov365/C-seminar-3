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

double distance (int x1, int y1, int x2, int y2)
{
    int deltaX = x2 - x1;
    int deltaY = y2 - y1;
    return Math.Sqrt (deltaX*deltaX + deltaY*deltaY);
}

int x1 = InputInt ("Input X1 coord");
int y1 = InputInt ("Input y1 coord");
int x2 = InputInt ("Input x2 coord");
int y2 = InputInt ("Input y2 coord");

System.Console.WriteLine($"Distance between coords is: {distance(x1, y1, x2, y2)}");