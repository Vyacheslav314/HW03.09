int a = ReadInt("Введите первое число: ");
int b = ReadInt("Введите второе число: ");
int result = 1;
for (int i = 0; i < b; i++)
{
    result *= a;
}

Console.WriteLine(result);


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}