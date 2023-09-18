// Напишите программу, которая по заданному номеру четверти, показывает
// диапазон возможных координат точек в этой четверти (x и y).

// Ввести номер четверти
// Поиск ответа
// Вывод результата

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
// Поиск номера четверти
string QuterBorderAsk(int numQuter)
{
    if (numQuter == 1) return "x > 0, y > 0";
    if (numQuter == 2) return "x < 0, y > 0";
    if (numQuter == 3) return "x < 0, y < 0";
    if (numQuter == 4) return "x > 0, y < 0";
    return string.Empty;
}
// Выводим результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int numQuter = ReadData("Введите номер четверти: ");

string res = QuterBorderAsk(numQuter);

PrintResult("Диапазон возможных координат точек в этой четверти " + res);
