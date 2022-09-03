void FillArray(int[] collection)

{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int indexOf(int[] collection, int find) 
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;            
        }
        index++;
    }
    return position;
}

// Создаем новый массив, в котором будет 10 элементов
int[] array = new int[10];

// Заполним наш массив.
FillArray(array);
// После автоматического заполнения массива можно вручную назначить определенным элементам массива нужные значения.
array[2] = 4;
array[8] = 4;

//Распечатаем массив.
PrintArray(array);

Console.WriteLine();
int pos = indexOf(array, 444);
Console.WriteLine(pos);