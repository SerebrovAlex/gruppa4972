// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Variant1()
{
    Console.WriteLine("Способ 1");

    Console.WriteLine("Введите номер дня недели");
    int day = int.Parse(Console.ReadLine() ?? "0");
    string[] dayOfWeek = new string[7];
    dayOfWeek[0] = "Понедельник, нет";
    dayOfWeek[1] = "Вторник, нет";
    dayOfWeek[2] = "Среда, нет";
    dayOfWeek[3] = "Четверг, нет";
    dayOfWeek[4] = "Пятница, нет";
    dayOfWeek[5] = "Суббота, да";
    dayOfWeek[6] = "Воскресенье, да";
    if (day > 7 || day < 1)
    {
        Console.WriteLine("Число " + day + " не я является днем недели, введите число от 1 до 7! ");
    }
    Console.WriteLine(dayOfWeek[day - 1]);
}

void Variant2()
{
    Console.WriteLine("Способ 2");
    Console.WriteLine("Введите номер дня недели");
    int day = int.Parse(Console.ReadLine() ?? "0");
    string[] dayOfWeek = new string[7];
    dayOfWeek[0] = "Понедельник";
    dayOfWeek[1] = "Вторник";
    dayOfWeek[2] = "Среда";
    dayOfWeek[3] = "Четверг";
    dayOfWeek[4] = "Пятница";
    dayOfWeek[5] = "Суббота";
    dayOfWeek[6] = "Воскресенье";
    if (day > 7 || day < 1)
    {
        Console.WriteLine("Число " + day + " не я является днем недели, введите число от 1 до 7! ");
    }
    Console.Write(dayOfWeek[day - 1]);

    //Определили какие дни недели выходные
    if (day == 6 || day == 7)
    {
        Console.Write(", выходной");
    }
    else
    {
        Console.Write(", не выходной");
    }
}

void Variant3()
{
    // решение через dictionary

    // Приглашение в консоли ввести число
    Console.WriteLine("Способ 3");
    Console.WriteLine("Введите число");

    // Создаем переменную num И с консоли вводим ее значение.
    // При этом сразу проверяем на null и конвертируем в int
    int day = int.Parse(Console.ReadLine() ?? "0");

    // Проверка введеного числа на день недели
    if (day > 7 || day < 1)
    {
        // Выводим результат в консоль
        Console.WriteLine("Число " + day + " не является днем недели, введите число от 1 до 7! ");
    }

    else
    {
        // Иницилизация словаря со значениями
        Dictionary<int, string> dayOfWeek = new Dictionary<int, string>
{
{ 1, "Понедельник - Рабочий день" },
{ 2, "Вторник - Рабочий день" },
{ 3, "Среда - Рабочий день" },
{ 4, "Четверг - Рабочий день" },
{ 5, "Пятница - Рабочий день" },
{ 6, "Суббота - Выходной день" },
{ 7, "Воскресенье - Выходной день" },
};

        //Получим элемент по ключу == day
        Console.WriteLine(dayOfWeek[day]);
    }
}
Variant1();
Variant2();
Variant3();
