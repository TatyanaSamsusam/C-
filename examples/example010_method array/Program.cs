int[] array = {15, 201, 329, 112, 23, 133, 18, 55, 133, 28};

int n = array.Length;
int find = 133;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index + 1;
}
