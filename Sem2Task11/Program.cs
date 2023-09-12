//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

//Генерируем трехзначное число
System.Random numberGenerator = new System.Random();
int number = numberGenerator.Next(100, 1000);
Console.WriteLine(number);
//Определяем первую цифру
int firstDigit = number / 100;
//Определяем вторую цифру
int lastDigit = number % 10;
//Собираем число
number = firstDigit * 10 + lastDigit;
//Выводим число
Console.WriteLine(number);
