int[,] GetMatrix(int upBorder, int rightBorder)
{
    int[,] matr = new int[upBorder, rightBorder];
    int len = upBorder * rightBorder;
    int downBorder = 0;
    int leftBorder = -1;
    int i = 0;
    int j = 0;
    int way = 0;
    for (int k = 1; k <= len; k++)
    {
        matr[i, j] = k;
        if (way == 0) // Вправо
            j++;
        else if (way == 1) // Влево
            j--;
        else if (way == 2) // Вниз
            i++;
        else // Вверх
            i--;
        if (way == 0 && j == rightBorder)
        {
            j--;
            i++;
            way = 2;
            rightBorder--;
        }
        else if (way == 2 && i == upBorder)
        {
            i--;
            j--;
            way = 1;
            upBorder--;
        }
        else if (way == 1 && leftBorder == j)
        {
            j++;
            i--;
            way = 3;
            leftBorder++;
        }
        else if (way == 3 && downBorder == i)
        {
            i++;
            j++;
            way = 0;
            downBorder++;
        }
    }
    return matr;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int rows = GetNumber("Число строк: ");
int columns = GetNumber("Число столбцов: ");
int[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);