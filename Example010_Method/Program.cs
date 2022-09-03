int[] array = { 1, 2, 28, 33, 45, 57, 17, 28, 39 };

int n = array.Length;
int find = 28;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        
        //прерывание цикла. В массиве 2 значения "28", нам нужно, чтобы цикл прервался после нахождения первого значения
        break;
    }
    index++;

}