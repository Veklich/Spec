string[] GetArrayFromString(string stringArray)
{
    string[] array = stringArray.Split(' ');
    return array;
}

string GetElLenLessThree (string[] array)
{
    string result = String.Empty;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= 3) result = result + $"{array[i]}";
    }

    return result;
}

System.Console.WriteLine("Привет! Я Итоговое Задание");
System.Console.WriteLine("Введи текст через пробел и нажми ''Enter''. Я выведу массив из строк, длина которых меньше, либо равна 3 символам");
System.Console.Write("Пиши, не стесняйся: ");
string[] array = GetArrayFromString(Console.ReadLine());
string str = GetElLenLessThree(array);

System.Console.WriteLine(string.Join(", ", str));