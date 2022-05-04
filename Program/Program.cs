//написать программу, которая из имеющегося массива строк формирует массив из строк,
//длина которых меньше либо равна 3 символа. Первоначальный массив вводится с клавиатуры
//либо задаётся на старте выполнения алгоритма. Решение через массивы.
//пример:
//["hello", "2", "world", ":-)"] -> ["2", ":-)"]



//задание массива
string[] stringArray = new[] { "hello", "2123", "world", "аа:-)" };

//определить длину нового массива
int LengthNewArray(string[] stringArray)
{
    int lengthNewArray = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            lengthNewArray++;
        }
    }
    return lengthNewArray;
}

//задать новый массив длиной, равной количеству строк исходного массива с длиной <=3
string[] stringNewArray = new string[LengthNewArray(stringArray)];

// заполнить новый массив
string[] FillStringArray(string[] stringArray, string[] stringNewArray)
{
    int length = stringArray.Length;
    int index = 0;
    int lengthNew = stringNewArray.Length;
    int count = 0;
    while (index < length)
    {
        if (stringArray[index].Length <= 3)
        {
            stringNewArray[count] = stringArray[index];
            count++;
        }
        index++;
    }
    return stringNewArray;
}

//напечатать массив
Console.WriteLine($"[{String.Join(',', FillStringArray(stringArray, stringNewArray))}]");