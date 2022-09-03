int row = ReadComand("Укажите количество строк: ");
int col = ReadComand("Укажите количество столбцов: ");
int[,] array2D = new int[row, col];
int startI = 0;
int finishI = 0;
int startJ = 0;
int finishJ = 0;
int k = 1;
int i = 0;
int j = 0;



while (k <= row * col)
{
    array2D[i, j] = k;
    if (i == startI && j < col - finishJ - 1)
        j++;
    else if (j == col - finishJ - 1 && i < row - finishI - 1)
        i++;
    else if (i == row - finishI - 1 && j > startJ)
        j--;
    else
        i--;
    if ((i == startI + 1) && (j == startJ) && (startJ != col - finishJ - 1))
    {
        startI++;
        finishI++;
        startJ++;
        finishJ++;
    }
    k++;
}

Console.WriteLine();
PrintArray2D(array2D);
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array2D[i,j] < 10)
            {
                Console.Write("0");
            }
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int ReadComand(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
