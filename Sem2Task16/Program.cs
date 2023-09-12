// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.WriteLine("Введите ДВА числа!");
Console.WriteLine("Введите число А");
int numA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число B");
int numB = int.Parse(Console.ReadLine() ?? "0");
//Проверяем соответствие
bool test1 = (numA == numB * numB);
bool test2 = (numB == numA * numA);

if (test1) Console.WriteLine("Первое число квадрат второго");
if (test2) Console.WriteLine("Второе число квадрат первого");
if (!test1 || test2) Console.WriteLine("Числа не квадрат друг друга");
