using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

int[,] array = new int[10, 10];
int x = 0;
int y = 0;

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 1000);
        }

    }
}


void PrintElement(int i, int j)
{
    if (i < array.GetLength(0) && j < array.GetLength(1))
    {
        Console.WriteLine($"{array[i, j]}");
    }
    else
    {
        Console.WriteLine("Такого элемента нет в массиве");
    }

}

CreateArray();
Console.WriteLine("Введите первый индекс");
x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второй индекс");
y = int.Parse(Console.ReadLine());
PrintElement(x, y);






