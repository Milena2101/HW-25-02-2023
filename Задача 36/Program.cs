
/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.Clear();
Console.Write("[");
Random rnd = new Random(); 
int[] myArray;
int n = rnd.Next(-10,10);
myArray = new int[n];
for (int i = 0; i < n; i++)
    {
        myArray[i] = rnd.Next(-10,100);
    }
foreach (int elem in myArray)
Console.Write("{0} ", elem);
Console.Write("]");
Console.WriteLine();
int sum = 0;
for ( int r = 0; r < myArray.Length; r++)
{
    if(myArray[r] % 2 != 0)
    {
        sum =sum + myArray[r];
    }
}
Console.Write($"Сумма {sum}");