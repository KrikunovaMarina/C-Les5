﻿/* // Задача 34: Задайте массив заполненный случайными положительными
 трёхзначными числами. Напишите программу,
  которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */
 int size = 4;
int [] array = new int [size];
for (int i =0; i<array.Length; ++i )
{
    array[i]= new Random().Next(100,1000);
}
Console.WriteLine(string.Join( ",", array)); 

int chet = 0;

foreach (int element in array)
{
    if (element % 2 == 0)
        chet ++;
}
Console.WriteLine("Количество четных элементов массива ->" + chet);