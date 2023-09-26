// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// Генерируем массив
int[] GenArray(int num, int lowBorder, int highBorder)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder + 1);
    }
    return array;
}
// Печатаем результат
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
    Console.WriteLine("");
}


int MaxArray(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int MinArray(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

int DiffMaxMin(int[] array)
{
    int diff= 0;
    diff = (MaxArray(array) -MinArray(array));
    return diff;
}
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}
int[] array = GenArray(22, 0, 10);
PrintArray(array);
int max = MaxArray(array);
PrintResult("Max " + max);
int min = MinArray(array);
PrintResult("Min " + min);
int diff = DiffMaxMin(array);
PrintResult("Разница между максимальным и минимальным элементами массива: " + DiffMaxMin(array));

