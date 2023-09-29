// // Задайте массив вещественных чисел.
// // Найдите разницу между максимальным и минимальным элементов массива.

// // Генерируем массив
// int[] GenArray(int num, int lowBorder, int highBorder)
// {
//     int[] array = new int[num];
//     for (int i = 0; i < num; i++)
//     {
//         array[i] = new Random().Next(lowBorder, highBorder + 1);
//     }
//     return array;
// }
// // Печатаем результат
// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.Write(array[array.Length - 1] + "]");
//     Console.WriteLine("");
// }


// int MaxArray(int[] array)
// {
//     int max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         {
//             max = array[i];
//         }
//     }
//     return max;
// }

// int MinArray(int[] array)
// {
//     int min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//     }
//     return min;
// }

// int DiffMaxMin(int[] array)
// {
//     int diff = 0;
//     diff = (MaxArray(array) - MinArray(array));
//     return diff;
// }
// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }
// int[] array = GenArray(22, 0, 10);
// PrintArray(array);
// int max = MaxArray(array);
// PrintResult("Max " + max);
// int min = MinArray(array);
// PrintResult("Min " + min);
// int diff = DiffMaxMin(array);
// PrintResult("Разница между максимальным и минимальным элементами массива: " + DiffMaxMin(array));

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
Console.Write(message);
string value = Console.ReadLine()??",";
int number = Convert.ToInt32(value);

return number;
}
// Заполняет массив случайными цифрами
double[] RandomArray(int count, int min, int max)
{
double[] randomNumbers = new double[count];
Random rand = new Random();
for (int i = 0; i < randomNumbers.Length; i++)
randomNumbers[i] = rand.Next(min, max) + Math.Round(rand.NextDouble(), 3);
return randomNumbers;
}
// Вычитает мин из макс
double SubtractingElements(double[] array)
{
return SearchMaxElement(array) - SearchMinElement(array);
}
// Ищет макс элемент
double SearchMaxElement(double[] array)
{
double max = array[0];

for (int i = 1; i < array.Length; i++)
    if (array[i] > max) max = array[i];

return max;
}
// Ищет мин элемент
double SearchMinElement(double[] array)
{
double min = array[0];

for (int i = 1; i < array.Length; i++)
    if (array[i] < min) min = array[i];

return min;
}
// Выводит массив в консоль
void OutputArray(double[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length - 1; i++)
Console.Write(array[i] + ", ");
Console.WriteLine(array[array.Length - 1] + "]");
}

// Смена параметров локализации для точки в вещественных чисел
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

int count = Prompt("Введите размер массива: ");
double[] array = RandomArray(count, 0, 10);
Console.Write("Исходный массив: ");
OutputArray(array);

Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {SubtractingElements(array)}");