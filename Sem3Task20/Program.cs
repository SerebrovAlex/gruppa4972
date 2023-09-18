// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
// Поиск решения
double Calc2DDist(int x1, int y1, int x2, int y2)
{
    double res = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2)*(y1 - y2)); // для дз добавить +(z1-z2)
    return res;
}
// Выводим результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int x1 = ReadData("Введите координату X1: ");
int y1 = ReadData("Введите координату Y1: ");

int x2 = ReadData("Введите координату X2: ");
int y2 = ReadData("Введите координату Y2: ");

double res = Calc2DDist(x1, y1, x2, y2);

PrintResult("Расстояние между точками " + res);
