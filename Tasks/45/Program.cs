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

const int SIZE = 8;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 50;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", arr));

int[] arrayCopy = new int[SIZE];

for (int i=0; i < SIZE; i++)
{
    arrayCopy[i] = arr[i];
}

Console.WriteLine(string.Join(", ", arrayCopy));