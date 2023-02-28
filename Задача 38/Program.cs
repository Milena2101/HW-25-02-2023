/*
Задайте массив вещественных чисел.
Найдиет разницу между макисмальным и минимальным элементов массива.
[3 7 22 2 78] > 76
*/


Console.Clear();
Console.Write("Array: ");
Random rnd = new Random();
int n = Convert.ToInt32(Console.ReadLine());
double[] j = new double[n];

double max = 0, min = 100;
Console.Write("[");
for (int f = 0; f < j.Length; f++)
{
    j[f] = rnd.Next(100);
}
for (int k = 0; k < j.Length; k++)
{
    if(j[k] > max) 
    max = j[k];
    if(j[k] < min)
    min = j[k];
}
for ( int v =0; v < j.Length; v++)
{
    Console.Write(" " + j[v]);
}
Console.Write("]");
Console.WriteLine();
Console.WriteLine("max "+ max);
Console.WriteLine("min " + min);
Console.WriteLine("Разница между min and max " + (max - min));
