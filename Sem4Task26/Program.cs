// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
int numDigits(int num)
{
    int count = 0;
    while (num > 0)
    {
        count++;
        num = num / 10;
    }
    return count;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int n = ReadData("Введите число: ");

PrintResult("Количество цифр в данном числе: "+ numDigits(n+1));
