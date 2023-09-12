//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
Console.WriteLine("Введите ДВА числа!");
Console.WriteLine("Введите число А");
int numA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число B");
int numB = int.Parse(Console.ReadLine() ?? "0");
if (numB % numA == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine("Второе число не кратно первому, остаток " + numB % numA);
}