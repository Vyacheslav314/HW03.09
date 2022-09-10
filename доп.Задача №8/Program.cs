string separatedNumbers = ReadCommand("Введите числа через пробел: ") + " ";
int[] arrayNumber = SetNumbers(separatedNumbers);

PrintArray(arrayNumber);
bool isValid = true;

while (isValid)
{
    Console.WriteLine();
    int comand = Convert.ToInt32(
        ReadCommand(
            "Выберите номер команды: 1.Добавить элементы в массив 2.Удалить число из массива\n3.Посчитать сумму всех элентов массива. 4.Показать текущий массив 5.Завершить программу: "
        )
    );
    switch (comand)
    {
        case 1:
            string addElem =
                ReadCommand("Введите числa через пробел что бы добавить их в массив: ") + " ";
            int[] newArrayNumber = SetNumbers(addElem);
            arrayNumber = AddNumbers(arrayNumber, newArrayNumber);
            break;
        case 2:
            int delNumber = Convert.ToInt32(
                ReadCommand("Введите число которое хотите удалить из массива: ")
            );
            arrayNumber = RemoveNumbers(arrayNumber, delNumber);
            break;
        case 3:
            Sum(arrayNumber);
            break;
        case 4:
        PrintArray(arrayNumber);
            break;
            case 5:
            Console.WriteLine("Программа завершена!!!");
            isValid = false;
            break;
        default:
            Console.WriteLine("Вы ввели несуществующую команду!");
            break;
    }
}

int[] RemoveNumbers(int[] arr, int delNumber)
{
    int startIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != delNumber)
        {
            arr[startIndex++] = arr[i];
        }
    }
    int[] newArray = new int[startIndex];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = arr[i];
    }
    return newArray;
}

void Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += Convert.ToInt32(array[i]);
    }
    Console.Write($"Сумма элементов в массиве {sum}");
}

int[] AddNumbers(int[] arr, int[] newArr)
{
    int[] newArray = new int[arr.Length + newArr.Length];

    int startIndex = arr.Length;

    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }
    for (int j = 0; j < newArr.Length; j++)
    {
        newArray[startIndex] = newArr[j];
        startIndex++;
    }
    return newArray;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] SetNumbers(string number)
{
    int count = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] == ' ')
        {
            count++;
        }
    }
    int[] arr = new int[count];
    int startIndex = 0;
    string strNumber = "";
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] != ' ')
        {
            strNumber += number[i];
        }
        else
        {
            arr[startIndex] = Convert.ToInt32(strNumber);
            startIndex++;
            strNumber = "";
        }
    }
    return arr;
}

string ReadCommand(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}
