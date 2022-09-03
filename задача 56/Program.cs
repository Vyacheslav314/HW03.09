int row = 3;
int col = 4;
int[,] array2D = new int[row, col];
int conditionallySmallest = 0; // условно наименьшая сумма строки.
int minSumRowIndex = 0;
int sumRow = 0;
FillArray2D(array2D);
PrintArray2D(array2D);
Console.WriteLine();

for (int i = 0; i < array2D.GetLength(1); i++)
{
    conditionallySmallest += array2D[0, i]; // инициализация условно наименьшей суммы строки.
}

for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        sumRow += array2D[i, j];  // находим сумму строки по индексу i
  
    }
        if (sumRow < conditionallySmallest)  // сравниваем сумму текущей строки с уловно меньшей
        {                                    
            conditionallySmallest = sumRow;  
            minSumRowIndex = i;                // сохраняем индекс наименьшей суммы строки
        }
    sumRow = 0;  // сбрасываем сумму текущей строки.
}

Console.Write($"Строка с минимальной суммой элементов {minSumRowIndex}"); 

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


