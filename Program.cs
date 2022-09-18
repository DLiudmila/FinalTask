Console.WriteLine("Введите размер массива строк: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = CreateStrigArray(size);

Console.WriteLine("Введите максимальную длинну строк во втором массиве: ");
int strLength = Convert.ToInt32(Console.ReadLine());
string[] array2 = CreateShortArray(array, strLength);

PrintArray(array);
Console.Write(" -> ");
PrintArray(array2);
Console.WriteLine();


/* Functions */

int CountShortStrings(string[] array, int strLen)
{
    int s = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= strLen)
        {
            s++;
        }
    } 
    return s;
}

string[] CreateShortArray(string[] array, int strLen)
{
    int arraySize2 = CountShortStrings(array, strLen);
    string[] ar = new string[arraySize2];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i].Length <= strLen)
        {
            ar[j] = array[i];
            j++;
        }
    }
    return ar;
}

string[] CreateStrigArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine("Введите строку номер " + (i+1) + ": ");
        string? newString = Console.ReadLine();
        array[i] = newString == null ? "" : newString;
    }
    return array;
}

void PrintArray(string[] arr)
{
    int k = 0;
    Console.Write("[\"");
    while (k < arr.Length)
    {
        Console.Write(arr[k]);
        if(k != arr.Length-1)
        {
            Console.Write("\", \"");
        }
        k++;
    }
    Console.Write("\"]");
}
