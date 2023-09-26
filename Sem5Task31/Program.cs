// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

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

(int, int) NegotivPositivSum(int[] array)
{
    int posSum = 0;
    int negSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            posSum = posSum + array[i];
        }
        else
        {
            negSum += array[i];
        }
    }
    return(posSum,negSum);
}

int[] array = GenArray(12, -9, 9);
PrintArray(array);
(int pos, int neg) sum = NegotivPositivSum(array);

Console.WriteLine(" Сумма > 0 : "+sum.pos+" Сумма < 0 :" + sum.neg);
