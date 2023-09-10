Console.WriteLine("Введите число, ");
int numN = int.Parse(Console.ReadLine() ?? "0");
int evNumN = (-1) * numN;
while (evNumN < numN)
{
    Console.WriteLine(evNumN + ",");
    evNumN = evNumN + 1;
}
Console.WriteLine(numN);
