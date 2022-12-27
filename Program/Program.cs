﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


void FillingArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
string[] startArray = { "cat", "qwerty", "21", "022", "hello", "Sum", "world", "yes", "no", ":-)"};
string[] resultArray = new string[startArray.Length];
FillingArray(startArray, resultArray);
resultArray = resultArray.Where(x => x != null).ToArray();
Console.WriteLine($"\n" + '[' + string.Join(", ", startArray) + ("] -> [") + string.Join(", ", resultArray) + ']' + "\n\n");