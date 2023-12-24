int[,] array = new int[10, 10];

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

void ChangeArray()
{
    int[] temp = new int[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp[j] = array[0, j];
    }
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[0, j] = array[array.GetLength(0) - 1, j];
    }
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[array.GetLength(0) - 1, j] = temp[j];
    }
}


CreateArray();
PrintArray();
Console.WriteLine();
Console.WriteLine();
ChangeArray();
PrintArray();


