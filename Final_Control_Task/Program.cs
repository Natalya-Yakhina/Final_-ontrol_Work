//  Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//ПРИМЕРЫ:
// ["hello", "2", "world", ":-)"-> ["2", ":-)"] 
// ["1234", "1567", "-2", "computer science"] -> ["-2"] 
// ["Russia”, "Denmark", "Kazan"] -> [ ]


// string[] CreateArray (string[] array) // вывод массива
// {
//    int count = 0; // переменная для подсчета длины нового массива
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i].Length <= 3)
//       count++;
//    }

//    string[] arrayNew = new string[count];
//    // инициализация 2-го массива с длиной, которую выше определили
//    Console.Write($"Новый массив: [");

//    int j = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i].Length <= 3) // проверка по заданному условию
//       {
//          arrayNew[j] = array[i]; // присвоение подходящего элемента
//          Console.Write($"{arrayNew[j]} ");
//          j++; // увеличение индекса у второго массива
//       }
//    }
//    Console.Write($"]");
//    return arrayNew;
// }  

// string[] initialarray = {"hello", "2", "world", ":-)"};
// //string[] initialarray = {"hello", "2", "world", ":-)"};   for test
// //string[] initialarray = {"Russia", "Denmark", "Kazan"};   for test
// CreateArray (initialarray); 
//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// string[] FindLengthString(int lenElem, string[] arrayInput) // метод поиска длинны строки
// {
//     int len = arrayInput.Length;    // Измерил длину массива и записал в переменную
//     int count = 0; // Заводим переменную счётчик
//     for (int i = 0; i < len; i++)  // В этом цикле считаем количество строк в массиве нужной длины
//     {
//         if (arrayInput[i].Length <= lenElem)
//         {
//             count++;
//         }
//     }
//     // Создаём новый массив в который будем записывать строки нужной длины
//     string[] resultArray = new string[count];
//     count = 0;
//     // В этом цикле берём определённые элементы из старого массива
//     // и записываем их в новый
//     for (int i = 0; i < len; i++)
//     {
//         if (arrayInput[i].Length <= lenElem)
//         {
//             resultArray[count] = arrayInput[i];
//             count++;
//         }
//     }
//     return resultArray;
// }

// // Сделаем метод, который будет печатать результирующий массив в консоль
// void PrintArray(string[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i == array.Length - 1)
//         {
//             Console.Write(array[i]);
//         }
//         else
//         {
//             Console.Write(array[i] + ", ");
//         }
//     }
//     Console.WriteLine("]");
// }

// // В эту переменную записывается не большу какой длины должны быть
// // элементы результирующего массива
// int lenElemArray = 3;
// // Печатаем три примера работы метода
// Console.WriteLine("Максимальный размер элементов в массиве: " + lenElemArray);
// string[] array1 = new string[] {"hello", "2", "world", ":-)"};
// PrintArray(FindLengthString(lenElemArray, array1));
// string[] array2 = new string[] {"1234", "1567", "-2", "computer science"};
// PrintArray(FindLengthString(lenElemArray, array2));
// string[] array3 = new string[] {"Russia", "Denmark", "Kazan"};
// PrintArray(FindLengthString(lenElemArray, array3));
//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

Console.Clear();
string[] CreateArray(int lengthElement, string[] array)
{
    int length = array.Length; // длинна массива
    int count = 0; // переменная счётчик
    for (int i = 0; i < length; i++)  // считаем количество строк в массиве нужной длины
    {
        if (array[i].Length <= lengthElement)
        {
            count++;
        }
    }
    // Создаём новый массив в который будем записывать строки нужной длины
    string[] arrayNew = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthElement)
        {
            arrayNew[count] = array[i];
            count++;
        }
    }
    return arrayNew;
}

void PrintArray(string[] arr) // вывод массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + "]");
    }
    Console.WriteLine();
}

int lengthElement = 3;
Console.WriteLine("Максимальный размер элементов в массиве: " + lengthElement);
string[] array = new string[] { "hello", "2", "world", ":-)" };
PrintArray(CreateArray(lengthElement, array));