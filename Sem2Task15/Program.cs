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

Variant1();
Variant2();
