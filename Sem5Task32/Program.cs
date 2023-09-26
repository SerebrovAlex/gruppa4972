// Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

// Заполняем одномерныый массив
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
}

void InversArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i]*-1;
    }
}

int[] array = GenArray(12, -9, 9);
PrintArray(array);
InversArray(array);
PrintArray(array);



