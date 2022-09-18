// Вид 1. Методы, которые ничего не принимают и ничего не возвращают.

void Method1()
{
    Console.WriteLine("Автор: Запорожец Марина Владимировна");
}

//Method1();

// Вид 2. Методы, которые на вход принимают аргументы, но ничего не возвращают.

void Method2(string msg)
{
    Console.WriteLine(msg);
}

//Method2(msg: "Тект сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Текст", count: 4);

//Вид 3. Методы, которые на вход ничего не принимают, но что-то возвращают.

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();

//Console.WriteLine(year);

// Вид 4. Методы, которые принимают что-то на вход и что-то возвращают.

string Method4(int count, string text)
{
    // int i = 0;
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    // while (i < count)
    {
        result = result + text;
        // i++;
    }
    return result;
}
string res = Method4(10, "z");

//Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        //        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    //    Console.WriteLine();
}

//=======Работа с текстом.
// Дан текст. В тексте все пробелы нужно заменить черточками,
// маленькие буква "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

string text = 
    "- Я думаю, - сказал князь, улыбаясь, -что, "
    + "ежели бы вас послали вместо нашего милого Винценгероде,"
    + "вы бы взяли приступом согласие прусского короля."
    + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
            result = result + $"{newValue}";
        else
            result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
Console.WriteLine();

int[] arr = { 1, 2, 8, 4, 5, 6, 1, 7, 9, 3, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j<array.Length; j++)
    {
        if (array[j]<array[minPosition]) minPosition = j;
    }
        int tempopary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = tempopary;
    }
}
// PrintArray(arr);
// SelectionSort(arr);
