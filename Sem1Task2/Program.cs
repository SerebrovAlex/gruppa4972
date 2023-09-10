//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите два числа!");
Console.WriteLine("Введите число А, ");
int numA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число B, ");
int numB = int.Parse(Console.ReadLine() ?? "0");
if (numA > numB)
{
    Console.WriteLine("Max " + numA + "," + " Min "
    + numB);
}
else
{
    Console.WriteLine("Max " + numB + "," + " Min "
    + numA);
}