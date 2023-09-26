//Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

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
int FindElement(int[] array, int elm)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == elm)
        {
            return i;
        }
    }
    return -1;
}
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int[] array = GenArray(12, -9, 9);
PrintArray(array);
int elm = ReadData(" Введите искомое число: ");
PrintResult("Позиция числа в массиве: " + FindElement(array, elm));
