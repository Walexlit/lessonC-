int[] array = { 1, 25, 3, 4, 45, 88, 78, 88 };
int n = array.Length;
int find = 88;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
   
    }
    index++;
}