// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// ["Hello", "2", "world", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] → ["-2"]
// ["Russia", "Denmark", "Kazan"] → []


using System;

Console.Write("Введите элементы массива: ");
string? s = Console.ReadLine();
char[] razdel = { ' ', ',', '"' };
string[] arrayStr1 = s!.Split(razdel, StringSplitOptions.RemoveEmptyEntries);
string[] arrayStr2 = new string[arrayStr1.Length];

Solve(arrayStr1, arrayStr2);

for (int i = 0; i < arrayStr2.Length; i++) Console.Write($"{arrayStr2[i]} ");
Console.WriteLine();





void Solve(string[] a, string[] b)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
        if (a[i].Length <= 3)
        {
            b[count] = a[i];
            count++;
        }
}
