Console.WriteLine("Введите размер массива строк: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = CreateStrigArray(size);

int arraySize2 = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4)
    {
        arraySize2++;
    }
} 

string[] array2 = new string[arraySize2];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
   if (array[i].Length < 4)
    {
        array2[j] = array[i];
        j++;
    }
}

PrintArray(array);
Console.Write(" -> ");
PrintArray(array2);
Console.WriteLine();


/* Functions */
string[] CreateStrigArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine("Введите значение " + (i+1) + " : ");
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
