/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
using System;
Console.Clear();
Console.Write("Задайте массив: ");
int see = Convert.ToInt32(Console.ReadLine());
int [] array = new int [see];
Random rand = new Random();
for ( int j = 0; j < see; j++)
{
    array[j] = rand.Next(100,1000);
    Console.WriteLine(array[j]);
}
PrintArray(array);
int count = 0;
for ( int s = 0; s < array.Length; s++)
{
    if (array[s] % 2 == 0)
    count++;
}
Console.WriteLine($"{count} - чётные");

void PrintArray(int [] array)
{
    Console.Write("[");
    for ( int s = 0; s < array.Length; s++)
    {
        Console.Write(array[s] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}