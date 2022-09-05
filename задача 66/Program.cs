int Firstnumber = ReadComand("Введите первое число: ");
int Secondnumber = ReadComand("Введите второе  число: ");
SumNumberFirstOrSecond(Firstnumber,Secondnumber + 1);
Console.Write(SumNumberFirstOrSecond(Firstnumber, Secondnumber));

int SumNumberFirstOrSecond(int first, int second)
{
    if(second == first)
        return second;
        
    int temp = first + SumNumberFirstOrSecond(first + 1,second) ;  
    return temp;
}

int ReadComand(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
