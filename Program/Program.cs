//написать программу, которая из имеющегося массива строк формирует массив из строк,
//длина которых меньше либо равна 3 символа. Первоначальный массив вводится с клавиатуры
//либо задаётся на старте выполнения алгоритма. Решение через массивы.
//пример:
//["hello", "2", "world", ":-)"] -> ["2", ":-)"]



//задание массива
string[] stringArray = new[] {"hello", "2", "world", ":-)"};

//определить длину нового массива
int LentchNewArray(string[] array)
{
    int lengthNewArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length<=3)
        {
            lengthNewArray++;
        }
    }
    return lengthNewArray;
}

int a = LentchNewArray(stringArray);
Console.WriteLine(a);
