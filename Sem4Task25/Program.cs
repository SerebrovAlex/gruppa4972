// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

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

long MyPow(int a, int b)
{
    long res = 1;
    while (b > 0)
    {
        res = res * a;
        b = b - 1;
    }
    return res;
}
int a = ReadData("Введите число A: ");
int b = ReadData("Введите число B: ");
PrintResult("Число A в степени B равно: " + MyPow(a, b));
