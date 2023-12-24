int[,] array = new int[3, 3];

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }

    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();

    }
}


void FindMin()
{
    int min1 = 0;
    int k = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        min1 = min1 + array[0, j];
    }
    Console.WriteLine(min1);

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int min = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            min = min + array[i, j];
        }
        Console.WriteLine(min);
        if (min1 > min)
        {
            k = i;
            min1 = min;
        }
    }
    Console.WriteLine("Минимальная сумма в строке номер " + (k + 1));
}


CreateArray();
PrintArray();
Console.WriteLine();
FindMin();
