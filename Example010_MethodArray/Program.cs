int[] array = { 1, 22, 31, 22, 24, 55, 61, 77, 38 };

int n = array.Length;
// нахождение индекса в массиве
int find = 22;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}