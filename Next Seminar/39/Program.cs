int[] GetRandomArray(int size, int leftRange = 0, int rightRange = 50)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange +1);
    }

    return array;
}

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}

const int SIZE = 8;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 50;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", arr));

ReverseArray(arr);
Console.WriteLine();
Console.WriteLine(string.Join(", ", arr));