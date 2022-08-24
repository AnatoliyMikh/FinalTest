string[] Array = { "hello", "2", "world", ":-)", "1234", "1567" };

// Метод для печати массива
string PrintArray(string[] inputArray)
{
    return string.Join(", ", inputArray)
}


PrintArray(Array);