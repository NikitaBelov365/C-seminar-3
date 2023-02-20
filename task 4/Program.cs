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
int number = InputInt("Specify the number of restrictions for calculating squares from 1");

for (int i = 1; i <= number; i++) // int i - инициализация, второе условие выполнения, третье - итерирование
{
    int square = i*i;
    System.Console.WriteLine($"{square}");
}