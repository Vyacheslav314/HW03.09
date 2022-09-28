int[,] array2d = new int[,]
{
    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
    { 1, 0, 1, 0, 1, 1, 1, 0, 0, 1, 1, 0, 1, 1 },
    { 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
    { 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1 },
    { 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
    { 1, 1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 0, 0, 1 },
    { 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1 },
    { 1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1 },
    { 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1 },
    { 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 1 },
    { 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1 },
    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1 },
};

PrintArray(array2d);

Checker(2, 1, array2d);

void Spaces(int left, int top)
{
    Console.SetCursorPosition(left, top);
    Console.Write(" ", Console.CursorVisible);
}

void CursorVis()
{
    Console.Write("@", Console.CursorVisible);
}

void Checker(int startL, int startT, int[,] playingField)
{
    ConsoleKeyInfo key;

    for (int i = startL; i < playingField.GetLength(0); )
    {
        for (int j = startT; j < playingField.GetLength(1); )
        {
            Console.SetCursorPosition(j, i);
            if (i == playingField.GetLength(0))
            {
                Console.WriteLine("Поздравляю ");
                return;
            }
            key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.DownArrow:
                    Spaces(j, i);
                    if (playingField[i, j] != 1)
                    {
                        Console.SetCursorPosition(j, ++i);
                        CursorVis();
                    }
                    break;
                case ConsoleKey.UpArrow:
                    Spaces(j, i);
                    if (playingField[i - 2, j] != 1)
                    {
                        Console.SetCursorPosition(j, --i);
                        CursorVis();
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    Spaces(j, i);
                    if (playingField[i - 1, j - 1] != 1)
                    {
                        Console.SetCursorPosition(--j, i);
                        CursorVis();
                    }
                    break;
                case ConsoleKey.RightArrow:
                    Spaces(j, i);
                    if (playingField[i - 1, j + 1] != 1)
                    {
                        Console.SetCursorPosition(++j, i);
                        CursorVis();
                    }
                    break;
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
