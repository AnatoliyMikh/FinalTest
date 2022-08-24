string[] Array = { "hello", "2", "world", ":-)", "1234", "1567" };

string PrintArray(string[] inputArray)// Метод для печати массива
{
    return string.Join(", ", inputArray);
}

int CountString(string[] input) // Метод пересчета количества строк длиной менее либо равной 3 символам
{
    int dl = Array.Length;
    int count = 0;
    int maxLengthString = 3;
    for (int i = 0; i < dl; i++)
    {
        if (Array[i].Length <= maxLengthString)
        {
            count++;
        }
    }
    return count;
}

string[] CreateNewArray(string[] inputArray, int Words) // Метод создания нового массива состоящего из 3 и менее символов 
{
    int len = inputArray.Length;
    string[] outputArray = new string[Words];
    int count = 0;
    int maxLengthString = 3;
    for (int i = 0; i < len; i++)
    {
        if (inputArray[i].Length <= maxLengthString)
        {
            outputArray[count] = inputArray[i];
            count++;
        }
    }

    return outputArray;
}

PrintArray(Array);

string[] outputArray = CreateNewArray(Array, CountString(Array));

PrintArray(outputArray);