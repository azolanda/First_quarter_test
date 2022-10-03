/*  Контрольная работа. Написать программу, которая из имеющегося массива строк 
    формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
    Первоначальный массив можно ввести с клавиатуры, 
    либо задать на старте выполнения алгоритма. 
    При решении не рекомендуется пользоваться коллекциями, 
    лучше обойтись исключительно массивами.

    Примеры:
    [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
    [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
    [“Russia”, “Denmark”, “Kazan”] → []
*/

int CountNewArrayLength(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] MakeNewArray(string[] array, int countLength)
{
    string[] newArray = new string[countLength];
    int k = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            newArray[k] = array[j];
            k++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    int length = array.Length;

    if (length == 0)
    {
        Console.WriteLine("[]");
    }
    else
    {
        string result = "[";
        for (int i = 0; i < length; i++)
        {
            if (i == length - 1)
            {
                result += $"{array[i]}]";
            }
            else
            {
                result += $"{array[i]}, ";
            }
        }
        Console.WriteLine($"Сгенерированный массив: {result}");
    }
}

string[] firstArray = new string[] { "Hello", ":-)", "world", "2l", "1567", "7y" };

int countNewArrayLength = CountNewArrayLength(firstArray);

string[] resultArray = MakeNewArray(firstArray, countNewArrayLength);

PrintArray(resultArray);
