static void reverseArray(int[] array, int index)
{
    if (index < array.Length)
    {
        reverseArray(array, index + 1);
        Console.WriteLine(array[index]);
    }
}

int[] array = { 1, 2, 3, 4, 5 };
reverseArray(array, 0);