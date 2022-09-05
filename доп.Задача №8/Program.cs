string separatedNumbers = ReadCommand("Введите числа через пробел: ");
int countComma = CommaCounter(separatedNumbers);
string[] substring = new string[countComma];
SetNumbers(substring, separatedNumbers);
PrintArray(substring);
bool isValid = true;

while (isValid)
{
    int comand = Convert.ToInt32(ReadCommand("Выберите номер команды: 1.создать массив чисел"));
    switch (comand)
    {
        case 1:
        int addElem = Convert.ToInt32(ReadCommand("Введите число которое хотите добавить в массив"));
            string[] newarray = AddNumbers(substring, addElem);
            break;
            case 2:
            break;
            case 3:
            int delNumber = Convert.ToInt32(ReadCommand("Введите число которое хотите удалить из массива"));
            RemoveNumbers(substring, delNumber);
            break;
            case 4:
            Sum(substring);
            break;
            case 5:
            isValid = false;
            break;
    }
}

string[] RemoveNumbers(string[] arr, int number)
{
    string[] newArray = new string[arr.Length - 1];
    for (int i = 0; i < newArray.Length; i++)
    {
        if (Convert.ToInt32(arr[i]) != number)
        {
            newArray[i] = Convert.ToString(arr[i]);
        }
        else if (Convert.ToInt32(arr[i]) == number)
        {
            newArray[i] = Convert.ToString(arr[i + 1]);
        }
    }
    return newArray;
}

void Sum(string[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += Convert.ToInt32(array[i]);
    }
    Console.Write($"Сумма элементов в массиве {sum}");
}

string[] AddNumbers(string[] arr, int addElem)
{
    string[] newArray = new string[arr.Length + 1];
    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }
    newArray[arr.Length] = Convert.ToString(addElem);
    return newArray;
}

int CommaCounter(string number)
{
    int count = 1;
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] == ' ')
        {
            count++;
        }
    }
    return count;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void SetNumbers(string[] array, string number)
{
    int startIndex = 0;
    for (int i = 0; i < separatedNumbers.Length; i++)
    {
        if (separatedNumbers[i] != ' ')
        {
            substring[startIndex] += separatedNumbers[i];
        }
        else
        {
            startIndex++;
        }
    }
}

string ReadCommand(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}
