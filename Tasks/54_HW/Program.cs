int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 50)
{
    int[,] matr = new int[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange + 1);
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

void SortRows(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int k = 0; k < matr.GetLength(1); k++)
        {
            for (int j = 0; j < matr.GetLength(1) - k - 1; j++)
            {
                if (matr[i, j] > matr[i, j + 1])
                {
                    int temp = matr[i, j];
                    matr[i, j] = matr[i, j + 1];
                    matr[i, j + 1] = temp;
                }
            }    
        }
    }
}

void SortRows2(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int k = 0; k < matr.GetLength(1); k++)
        {
            for (int j = 0; j < matr.GetLength(1) - k - 1; j++)
            {
                if (matr[i, j] < matr[i, j + 1])
                {
                    int temp = matr[i, j];
                    matr[i, j] = matr[i, j + 1];
                    matr[i, j + 1] = temp;
                }
            }    
        }
    }
}

int rows = GetNumber("Число строк: ");
int columns = GetNumber("Число столбцов: ");
int[,] matrix = GetMatrix(rows, columns);
Console.WriteLine("Заданная матрица: ");
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Строки сортируем по возрастанию: ");
SortRows(matrix); 
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Строки сортируем по убыванию: ");
SortRows2(matrix); 
PrintMatrix(matrix);