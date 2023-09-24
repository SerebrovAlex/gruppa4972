// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//Вводим данные
int ReadData(string msg)
{
Console.WriteLine(msg);
int num = int.Parse(Console.ReadLine() ?? "0");
return num;
}

//Печатаем результат
void PrintResult(string msg)
{
Console.WriteLine(msg);
}

long Factorial(int num)
{
    long res=1;
    for(int i=2; i<=num;i++)
    {
        res=res*i;
    }
    return res;
}

int n = ReadData("Введите число: ");
PrintResult("Произведение чисел от 1 до N равно: "+Factorial(n));