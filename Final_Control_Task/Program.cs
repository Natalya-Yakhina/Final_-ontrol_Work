//  Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//ПРИМЕРЫ:
// ["hello", "2", "world", ":-)"-> ["2", ":-)"] 
// ["1234", "1567", "-2", "computer science"] -> ["-2"] 
// ["Russia", "Denmark", "Kazan"] -> [ ]

Console.Clear();
string[] stringArray = {"hello", "2", "world", ":-)"}; // Создание и заполнение первоначального массива
// string[] stringArray = {"1234", "1567", "-2", "computer science"};
// string[] stringArray = {"Russia", "Denmark", "Kazan"};
string[] stringNewArray = new string[stringArray.Length]; // Новый массив

void FillArray(string[] stringArray, string[] stringNewArray) // Метод, заполняющий новый массив строками, в которых <= 3 символа из первоначального массива
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            stringNewArray[count] = stringArray[i];
            count++;
        }
    }
}

void PrintArray(string[] array) // Метод вывода массива на печать
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("Массив [");
        if (i < array.Length - 1) Console.Write(array[i] + " ");
        else Console.Write(array[i] + "]");
    }
}

FillArray(stringArray, stringNewArray);
Console.Write("Исходный массив: ");
PrintArray(stringArray);
Console.WriteLine();
Console.Write("Новый массив: ");
PrintArray(stringNewArray);