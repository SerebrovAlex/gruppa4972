Console.WriteLine("Введите число, ");
int num = int.Parse(Console.ReadLine() ?? "0");
if (num % 2 == 0)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}
