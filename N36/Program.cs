/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
 */
 int size = 4;
int [] array = new int [size];
for (int i =0; i<array.Length; ++i )

{
    array[i]= new Random().Next(-100,100);
}
Console.WriteLine(string.Join( ",", array)); 
int a= array[0]+array[2];
Console.WriteLine("Сумма элементов стоящих на нечетных позициях ->" + a);