int rowA = ReadComand("Укажите количество строк матрицы a: ");
int colA = ReadComand("Укажите количество столбцов  a: ");
int rowB = ReadComand("Укажите количество строк матрицы b: ");
int colB = ReadComand("Укажите количество столбцов матрицы b: ");
int[,] matrixA = new int[rowA, colA];
int[,] matrixB = new int[rowB, colB];
int[,] matrixC = new int[rowA, colB];

if (colA != rowB)
{
    Console.WriteLine("Произведение вычеслить нельзя ");
    return;
}
FillArray2D(matrixA);
FillArray2D(matrixB);
PrintArray2D(matrixA);
Console.WriteLine();
PrintArray2D(matrixB);
Console.WriteLine();


for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        matrixC[i,j] = 0;
        for(int k = 0; k < matrixB.GetLength(0); k++)
        {
           matrixC[i,j] += matrixA[i,k] * matrixB[k,j];
        }  
    }   
}
PrintArray2D(matrixC);


void PrintArray2D(int[,] array)
{
    int[,] newArray2D = new int[array.GetLength(1), array.GetLength(0)];
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


