// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//Генерируем число
System.Random numberGenerator = new System.Random();
int number = numberGenerator.Next(100, 1000);
Console.WriteLine(number);
//Представляем число в виде массива 
char[] digitChar = number.ToString().ToCharArray();
Console.WriteLine(digitChar[1]);