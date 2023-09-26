// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

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
int CountElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] >= 10) && (array[i] <= 99))
        {
            count++;
        }
    }
    return count;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int[] array = GenArray(123, 0, 100);
PrintArray(array);
int count = CountElement(array);
PrintResult("Количество элементов в данном отрезке: " + count);
