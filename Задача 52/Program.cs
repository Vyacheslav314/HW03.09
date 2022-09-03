int row = ReadComand("Укажите количество строк ");
int col = ReadComand("Укажите количество столбцов ");
int[,] array2D = new int[row, col];

FillArray2D(array2D);
PrintArray2D(array2D);
Console.WriteLine();

for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        for (int k = 0; k < array2D.GetLength(1); k++)
        {
            if (array2D[i, j] > array2D[i, k])
            {
                int temp = array2D[i, k];
                array2D[i, k] = array2D[i, j];
                array2D[i, j] = temp;
            }
        }
    }
}
PrintArray2D(array2D);
void PrintArray2D(int[,] array)
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

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

int ReadComand(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
