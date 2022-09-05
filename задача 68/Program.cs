int firstnumber = ReadComand("Введите первое число: ");
int secondnumber = ReadComand("Введите второе  число: ");
AckermanFunction(firstnumber,secondnumber);
Console.Write(AckermanFunction(firstnumber, secondnumber) + " ");
int AckermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;

    if (m > 0 && n == 0)
        return AckermanFunction(m - 1, 1);
        
    if (m > 0 && n > 0)
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    return AckermanFunction(m, n);
}

int ReadComand(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}