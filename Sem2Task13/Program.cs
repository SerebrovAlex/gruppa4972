// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//Вводим число
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine() ?? "0");
//Проверяем что число трехзначное
if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
} 
else
{ //Представляем число в виде массива
    char[] digitChar = num.ToString().ToCharArray();
    Console.WriteLine(digitChar[2]);
}
