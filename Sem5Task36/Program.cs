// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

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
int SumNegPos(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
        sum=sum+array[i];
    }
    return sum;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int[] array = GenArray(22, 0, 100);
PrintArray(array);
int sum = SumNegPos(array);
PrintResult("Сумма нечетных позиций элементов массива: " + sum);
