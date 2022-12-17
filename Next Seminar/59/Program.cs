int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 9)
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

int[,] task(int[,] matr)
{
    int mini = -1;
    int minj = -1;
    int min = 999;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min)
            {
                mini = i;
                minj = j;
                min = matr[i, j];
            }
        }
    }

    int[,] result = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    int ii = 0;
    int jj = 0;
    Console.WriteLine("mini = " + mini);
    Console.WriteLine("minj = " + minj);
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (i != mini)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (j != minj)
                {
                    result[ii, jj] = matr[i, j];
                    jj++;
                }
            }
            jj = 0;
            ii++;
        }
    }
    return result;
}

int rows = GetNumber("Число строк: ");
int columns = GetNumber("Число столбцов: ");
int[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine();

int[,] res = task(matrix);
PrintMatrix(res);