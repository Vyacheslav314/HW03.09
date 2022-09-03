int digre = ReadComand("Ввдите количество строк");
int[] array = new int[1];
int index = 0;
int numb = 1;

while (index <= digre)
{ 
    
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = numb; 
        for(int j = 1; j < array.Length - 1; j++)
        {
            array[j] = array[i] + array[i];
            
        }
        
    }
    PrintArray2D(array);
    Console.WriteLine();
    
    array = new int[array.Length+1];
    index++;
    
}

void PrintArray2D(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}



int ReadComand(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
