//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите ТРИ числа!");
Console.WriteLine("Введите число А, ");
int numA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число B, ");
int numB = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число C, ");
int numC = int.Parse(Console.ReadLine() ?? "0");
if (numA > numB)
{
    if (numA > numC)
        Console.WriteLine("Max " + numA);
    else Console.WriteLine("Max " + numC);
}
else
{
    if (numB > numC) Console.WriteLine("Max " + numB);
    else Console.WriteLine("Max " + numC);
}