int number = ReadComand("Введите число: ");
SequenceNumbers(number);

int SequenceNumbers(int num)
{
    if (num <= 0)
        return 1;
    
    else
    {
        int temp = num;
        Console.Write(temp + " ");
        SequenceNumbers(num - 1);

        return temp;
    }
}

int ReadComand(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
