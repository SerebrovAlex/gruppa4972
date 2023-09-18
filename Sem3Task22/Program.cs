// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
// Находим квадрат числа N
string BuildLine(int n, int Pow)
{
    string res = "";
    for (int i = 1; i <= n; i++)
    {
        res = res + Math.Pow(i, Pow) + " ";
    }
    return res;
}
// Выводим результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int n = ReadData("Введите число N: ");

PrintResult(BuildLine(n, 1));
PrintResult(BuildLine(n, 2));
