// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int SumDigit(int num)
{
    int res = 0;
    while (num > 0)
    {
        res = res + num % 10;
        num = num / 10;
    }
    return res;
}

int n = ReadData("Введите число: ");
PrintResult("Сумма цифр в числе равна: " + SumDigit(n));
