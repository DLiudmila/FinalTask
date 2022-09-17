string[] array = new string[4] {"1Hello", "2", "world", ":-)"};
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

int k = 0;
Console.Write("[\"");
while (k < array.Length)
{
    Console.Write(array[k]);
    if(k != array.Length-1)
    {
        Console.Write("\", \"");
    }
    k++;
}
Console.Write("\"]");

Console.Write(" -> ");

k = 0;
Console.Write("[\"");
while (k < array2.Length)
{
    Console.Write(array2[k]);
    if(k != array2.Length-1)
    {
        Console.Write("\", \"");
    }
    k++;
}
Console.WriteLine("\"]");