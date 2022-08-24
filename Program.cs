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

PrintArray(Array);