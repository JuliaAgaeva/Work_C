/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/


int m = 3, n = 4;

double [,] array = new  double [m,n];
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double t = new Random().NextDouble()*32-10;
            array[i,j]=Math.Round(t, 1);      
}
}
}

 for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
       Console.Write ($"{array[i,j]}   ");
    
    Console.WriteLine();
    }




/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

   /*  int m = 3, n = 4;

    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

 int a, b;
 Console.Write($"Введите позиции элемента массива:  ");
int.TryParse(Console.ReadLine()!, out a);
b=a % 10;
a= a/10;

try
{
Console.Write($"{array[a, b]} ");
}

catch(SystemException)
{
 Console.Write($"Такого элемента нет! ");    

}
   */



/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


/*int m = 4, n = 5;
int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
array[i, j] = new Random().Next(10);
Console.Write($"{array[i, j]} ");
}
Console.WriteLine();
}

for (int j = 0; j < n; j++)
{
int sum = 0;
for (int i = 0; i < m; i++)
{
sum += array[i, j];
}
Console.Write($"Среднее арифметическое {j + 1} столбца = {(double)sum / m}\n");
}
*/