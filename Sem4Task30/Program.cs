// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int[] GenArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        array[i] =rnd.Next(0,2);
    }
    return array;
}

void PrintArray(int[]array)
{
    Console.Write("[");
    for(int i=0; i<array.Length-1;i++)
    {
        Console.Write(array[i]+", ");
    }
    Console.Write(array[array.Length-1]+"]");
}
int len = ReadData("Введите размер массива: ");
int[] array = GenArray(len);
PrintArray(array);

