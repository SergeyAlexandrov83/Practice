int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange=0, int rightRange=50)
{
    int[,] matr = new int[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange +1);
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

string returnAnswer(int[,] matr, int row, int column)
{
    if (row <= matr.GetLength(0) && column <= matr.GetLength(1))
    {
        string answer = Convert.ToString(matr[row - 1, column - 1]);
        return answer;
    }
    else
    {
        return "Такого числа нет!";
    }
    
}

int rows = GetNumber("Число строк: ");
int columns = GetNumber("Число столбцов: ");
int[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);

int inRows = GetNumber("Число в какой строке? ");
int inColumns = GetNumber("Число в каком столбце?: ");
Console.WriteLine(returnAnswer(matrix, inRows, inColumns));