// Напишите программу, которая принимает на вход координаты точки
// (Х и У), причём х не= 0 или У не= 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

int InputInt(string message)
{
    System.Console.WriteLine($"{message}>");
    // bool isCorrect = int.TryParse(Console.ReadLine(), out value);
    // if(isCorrect) - это присваивание в if bool значения
    if(int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    System.Console.WriteLine("Its not a number");
    Environment.Exit(1);
    return 0;
}

bool ValidateCoords(int x, int y)
{
    if(x==0 || y == 0)
    {
        System.Console.WriteLine(("One of coords is on coordline"));
        return false;
    }
    return true;
}

int GetQuorter(int x, int y)
{
    if(x>0 && y>0)
    {
        return 1;
    }
    if(x<0 && y>0)
    {
        return 2;
    }
    if(x<0 && y<0)
    {
        return 3;
    }
    return 4;
}

int x =InputInt("Input x");
int y =InputInt("Input y");

if(ValidateCoords(x, y))
{
    System.Console.WriteLine($"Coords {x}, {y} in {GetQuorter(x, y)} quorter");
}