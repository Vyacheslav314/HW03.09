int[,] array2d = new int[,]
{
    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
    { 1, 0, 1, 0, 1, 1, 1, 0, 0, 1, 1, 0, 1 },
    { 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1 },
    { 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 },
    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
    { 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1 },
    { 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1 },
    { 1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 1, 1, 1 },
    { 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1 },
    { 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
    { 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
};

PrintArray(array2d);
int startLeft = 11;
int startTop = 13;
Checker(startLeft, startTop);

int Checker(int startL, int startT, string arrow = "@")
{
    string empty = new string(' ', arrow.Length);
    int i = startL;
    int j = startT;
    Console.SetCursorPosition(startL, startT);
    Console.Write(arrow);
    ConsoleKeyInfo key;
    for (; ; )
    {
        for (; ; )
        {
            key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.DownArrow:

                    Console.SetCursorPosition(startL, startT);
                    Console.Write(empty);
                    Console.SetCursorPosition(startL, ++startT);
                    Console.Write(arrow);
                    break;
                case ConsoleKey.UpArrow:

                    Console.SetCursorPosition(startL, startT);
                    Console.Write(empty);
                    Console.SetCursorPosition(startL, --startT);
                    Console.Write(arrow);
                    break;
                    break;
                case ConsoleKey.LeftArrow:
                    Console.SetCursorPosition(i, j);
                    Console.WriteLine(" ", Console.CursorVisible);
                    Console.SetCursorPosition(--i, j);
                    Console.WriteLine("@", Console.CursorVisible);

                    break;
                case ConsoleKey.RightArrow:
                    Console.SetCursorPosition(i, j);
                    Console.WriteLine(" ", Console.CursorVisible);
                    Console.SetCursorPosition(++i, j);
                    Console.WriteLine("@", Console.CursorVisible);
                    break;
                case ConsoleKey.Enter:
                    return i + 1 - startL;
            }
        }
    }
}

void PrintArray(int[,] playingField)
{
    for (int i = 0; i < playingField.GetLength(0); i++)
    {
        for (int j = 0; j < playingField.GetLength(1); j++)
        {
            if (playingField[i, j] == 0)
            {
                Console.Write($" ");
            }
            else
            {
                Console.Write($"*");
            }
        }
        Console.WriteLine();
    }
}
