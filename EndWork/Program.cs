
string[] array = { "Asphodel", "faw", "n",  "Fawn", "45698", "1897",
                  "run", "world", "gift", "18)!", "per", "Aurora", 
                  "Denmark", "gif", "t" };
string[] FindStringLength(string[] array)
{
    int length = 3;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length)
        {
            count++;
        }
    }

    int index = 0;
    string[] newarray = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length)
        {
            newarray[index] = array[i];
            index++;
        }
    }
    return newarray;
}
string[] newarray = FindStringLength(array);
for (int i = 0; i < newarray.Length; i++)
{
    Console.Write($"{newarray[i]} ");
}





/*using static System.Console;

string ReadString()
{
    WriteLine("Введите буквы, слова, цифры или символы через пробел и нажмите Enter:");
    return ReadLine()!;
}

string[] StringToArray(string s)
{
    string[] stringArray = s.Split(" ");
    return stringArray;
}

string[] CreateMaxThreeDigitsArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] targetArray = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            targetArray[count] = array[i];
            count++;
        }
    }
    return targetArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

string str = ReadString();
string[] array = StringToArray(str);
string[] targetArray = CreateMaxThreeDigitsArray(array);
WriteLine();
PrintArray(targetArray);*/