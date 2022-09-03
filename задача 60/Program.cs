int[,,] array3D = { { { 22, 33 }, { 12, 54 } }, { { 25, 87 }, { 16, 77 } }, };

PrintArray3D(array3D);

void PrintArray3D(int[,,] array)
{
    int[,] newArray2D = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(2); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(1); k++)
            {
                Console.Write($" {array[i, k, j]}  ({j},{k},{i})");
            }      
        }  
        Console.WriteLine();   
    }
}
