Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine() ?? "0");
int count = 0;
if (num % 2 == 0)
{
    while (count < num)
    {
        count = count + 2;
        Console.Write((count) + ", ");
    }
}
else
if (num % 2 == 1)
    num = num - 1;
{
    while (count < num)
    {
        count = count + 2;
        Console.Write((count) + ", ");
    }
}

// Console.Write("Введите число: "); // Создаем строку ввода
// string? inputlineN = Console.ReadLine(); // Инициализируем сканер
// int startNumber = 2; // Переменна, с кот начинается отчет

// if (inputlineN != null) // Проверяем, что строка не пустая
// {
// int inputnumberN = int.Parse(inputlineN); // Парсим строку в инт
// while (startNumber <= inputnumberN - 2) // Условие завершения цикла
// {
// Console.Write(startNumber + ", "); // Если число делится - выводим в консоль
// startNumber = startNumber + 2; // прибавляем единицу к числу
// }

// if (startNumber % 2 == 0)
// {
//     Console.WriteLine(startNumber);
// }
// }