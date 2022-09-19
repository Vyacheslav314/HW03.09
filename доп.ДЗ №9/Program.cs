string[] userData =
{
    "Иванов Иван Иванович",
    "Петров Петр Петрович",
    "Федоров Федор Федорович",
    "Сидоров Максим Викторович",
    "Иванов Иван Иванович"
};
string[] post = { "директор", "уборщик", "бухгалтер", "водитель", "уборщик" };
string[] wages = { "60000", "30000", "50000", "38000", "30000" };

bool isValid = true;

while (isValid)
{
    Console.WriteLine();
    int command = Convert.ToInt32(
        ReadCommand(
            "Выберите номер команды: 1.Добавить досье 2.Удалить данные сотрудника\n3. Найти данные сотрудника по ФИО. 4.Получить данные всех сотрудников по должности\n5.Всего расходы на выплаты заработной платы 6.Найти заработные платы больше или меньше указанной\n7.Чтобы вывести все досье 8.Чтобы завершить работу программы "
        )
    );
    switch (command)
    {
        case 1:
            string addUserData = ReadCommand("Введите ФИО работаника: ");
            string addPost = ReadCommand("Введите должность работаника: ");
            string addWages = ReadCommand("Введите заработную плату работаника: ");
            userData = AddData(userData, addUserData);
            post = AddData(post, addPost);
            wages = AddData(wages, addWages);
            break;
        case 2:
            int numberUser = Convert.ToInt32(
                ReadCommand("Укажите номер сотрудника который необходимо удалить: ")
            );
            userData = RemoveData(userData, numberUser);
            post = RemoveData(post, numberUser);
            wages = RemoveData(wages, numberUser);
            break;
        case 3:
            string userName = ReadCommand("Введите ФИО работаника: ");
            SearchUserData(userData, post, wages, userName);
            break;
        case 4:
            string userPost = ReadCommand("Введите должность ");
            SearchUserPost(post, userData, wages, userPost);
            break;
        case 5:
            int sum = Sum(wages);
            Console.Write($"Всего на выплаты заработной платы {sum}");
            break;
        case 6:
            int com = Convert.ToInt32(
                ReadCommand(
                    "Введите 1 если хотите увидеть заработные платы выше вашей и 2 если ниже: "
                )
            );
            int midleWages = Convert.ToInt32(ReadCommand("Введите сумму: "));
            SearchUserWages(wages, post, userData, midleWages, com);
            break;
        case 7:
            PrintArray(userData, post, wages);
            break;
        case 8:
            Console.WriteLine("Программа завершена!!!");
            isValid = false;
            break;
        default:
            Console.WriteLine("Вы ввели несуществующую команду!");
            break;
    }
}

void SearchUserWages(string[] userWages, string[] userPost, string[] data, int wages, int com)
{
    if (com == 1)
    {
        int count = 0;
        for (int i = 0; i < userWages.Length; i++)
        {
            if (Convert.ToInt32(userWages[i]) >= wages)
            {
                Console.Write(
                    $"ФИО: {data[i]}\nДолжность: {userPost[i]}\nЗаработная плата: {userWages[i]}"
                );
                Console.WriteLine();
                count++;
            }
        }
        if (count == 0)
        {
            Console.Write("Таких нет ");
        }
    }
    else if (com == 2)
    {
        int count = 0;
        for (int i = 0; i < userWages.Length; i++)
        {
            if (Convert.ToInt32(userWages[i]) <= wages)
            {
                Console.Write(
                    $"ФИО: {data[i]}\nДолжность: {userPost[i]}\nЗаработная плата: {userWages[i]}"
                );
                Console.WriteLine();
                count++;
            }
        }
        if (count == 0)
        {
            Console.Write("Таких нет ");
        }
    }
}

void SearchUserPost(string[] userPost, string[] data, string[] userWages, string post)
{
    for (int i = 0; i < userPost.Length; i++)
    {
        if (userPost[i] == post)
        {
            Console.Write(
                $"ФИО: {data[i]}\nДолжность: {userPost[i]}\nЗаработная плата: {userWages[i]}"
            );
            Console.WriteLine();
        }
    }
}

void SearchUserData(string[] data, string[] userPost, string[] userWages, string userName)
{
    for (int i = 0; i < data.Length; i++)
    {
        if (data[i] == userName)
        {
            Console.Write(
                $"ФИО: {data[i]}\nДолжность: {userPost[i]}\nЗаработная плата: {userWages[i]}"
            );
            Console.WriteLine();
        }
    }
}

string[] RemoveData(string[] arr, int delData)
{
    delData = delData - 1;
    int startIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != delData)
        {
            arr[startIndex++] = arr[i];
        }
    }
    string[] newArray = new string[startIndex];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = arr[i];
    }
    return newArray;
}

int Sum(string[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += Convert.ToInt32(array[i]);
    }
    return sum;
}

string[] AddData(string[] arr, string data)
{
    string[] newArray = new string[arr.Length + 1];

    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }
    newArray[newArray.Length - 1] = data;
    return newArray;
}

void PrintArray(string[] data, string[] userPost, string[] userWages)
{
    for (int i = 0; i < data.Length; i++)
    {
        Console.Write($"ФИО: {data[i]}\nДолжность: {userPost[i]}\nЗаработная плата: {userWages[i]}");
        Console.WriteLine();
    }
}

string ReadCommand(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}
