﻿// Напишите прграмму, которая будет принимать 2 числа А и В
// возведите А в степень В с помощью рекурсии

// вводим данные
int ReadData(string msg) 
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
// возведение  А в степень В
long DigitPower(int n, int p)
{
    if(p == 1) return n;
    if(p == 2) return n*n;
    if(p > 0){
    return DigitPower(n, p/2)*DigitPower(n, p - p/2);
    } else return 1;
}
int n = ReadData("Введите основание");
int m = ReadData("Введите степень");
Console.WriteLine($"Возведение в степень { DigitPower(n,m)}");