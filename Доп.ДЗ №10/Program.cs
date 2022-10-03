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

int left = 2;
int top = 1;

PrintArray(array2d);

Checker(left, top, array2d);

void Spaces()
{
    Console.Write(" ", Console.CursorVisible = false);
}

void Cursor(int left, int top)
{
    Console.SetCursorPosition(left, top);
}

void Mine()
{
    Console.Write("@", Console.CursorVisible == false);
}

void Checker(int startT, int startL, int[,] playingField)
{
    ConsoleKeyInfo key;
    for (int i = startT; i < playingField.GetLength(0); )
    {
        for (int j = startL; j < playingField.GetLength(1); )
        {  
            
            Console.CursorVisible = false;
            Cursor(j, i);
            Mine();
            Cursor(j, i);
            
            if (i == playingField.GetLength(0))
            {
                Console.WriteLine();
                Console.WriteLine("Поздравляю ");
                return;
            }
            key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.DownArrow:
                    Cursor(j, i);
                    Spaces();
                    if (playingField[i, j] != 1)
                    {
                        Cursor(j, ++i);
                        Mine();
                    }
                    else
                    {
                        Cursor(j, i);
                        Mine();
                    }
                    break;
                case ConsoleKey.UpArrow:
                    Cursor(j, i);
                    Spaces();
                    if (playingField[i - 2, j] != 1)
                    {
                        Cursor(j, --i);
                        Mine();
                    }
                    else
                    {
                        Cursor(j, i);
                        Mine();
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    Cursor(j, i);
                    Spaces();
                    if (playingField[i - 1, j - 1] != 1)
                    {
                        Cursor(--j, i);
                        Mine();
                    }
                    else
                    {
                        Cursor(j, i);
                        Mine();
                    }
                    break;
                case ConsoleKey.RightArrow:
                    Cursor(j, i);
                    Spaces();
                    if (playingField[i - 1, j + 1] != 1)
                    {
                        Cursor(++j, i);
                        Mine();
                    }
                    else
                    {
                        Cursor(j, i);
                        Mine();
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
