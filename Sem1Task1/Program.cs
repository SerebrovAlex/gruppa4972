Console.WriteLine("Введите число А, ");
int numA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число B, ");
int numB = int.Parse(Console.ReadLine() ?? "0");
if (numB * numB == numA)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}