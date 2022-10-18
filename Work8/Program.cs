//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int m = 3, n = 4;
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(10);

Console.Write($"{array[i, j]} ");
}
Console.WriteLine();
}

for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 1; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(1) - 1; k++)
        {
         if (array[i,k] < array[i,k+1])
        {
          int temp = array[i, k+1];
          array[i, k+1] = array[i, k];
          array[i,k] = temp;
        }
      }
}
}
  
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
Console.Write($"{array[i, j]} ");
Console.WriteLine();
}
*/




/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
/*
int m = 3, n = 4;
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(10);

Console.Write($"{array[i, j]} ");
}
Console.WriteLine();
}


int minSumLine = 0;
int sumLine = newsumLine (array,0);

for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = newsumLine(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");
  

int newsumLine(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}
*/



/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

/*int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
*/


/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


int[,] firstMartrix = new int[2, 2];
int[,] secondMartrix = new int[2, 2];


Console.Write($" Первая матрица \n" );

for (int i = 0; i < firstMartrix.GetLength(0); i++)
{
for (int j = 0; j < firstMartrix.GetLength(1); j++)
{
firstMartrix [i, j] = new Random().Next(10);

Console.Write($"{firstMartrix [i, j]} ");
}
Console.WriteLine();
}

Console.Write($" Вторая матрица \n" );

for (int i = 0; i < secondMartrix.GetLength(0); i++)
{
for (int j = 0; j < secondMartrix.GetLength(1); j++)
{
secondMartrix[i, j] = new Random().Next(10);

Console.Write($" {secondMartrix [i, j]} ");
}
Console.WriteLine();
}

Console.WriteLine($"\n Произведение первой и второй матриц:");


int[,] rezult = new int[firstMartrix.GetLength(0), secondMartrix.GetLength(1)];

      for (int i = 0; i < rezult.GetLength(0); i++)
      {
       for (int j = 0; j < rezult.GetLength(1); j++)
        {
          for (int k = 0; k < firstMartrix.GetLength(1); k++) 
          {
              rezult[i, j] += firstMartrix[i, k]*secondMartrix[k, j];
          }
        }
      }

   for (int i = 0; i < rezult.GetLength(0); i++)
      {
       for (int j = 0; j < rezult.GetLength(1); j++)
          
        Console.Write($"{rezult[i, j]} ");    
         
        Console.WriteLine();
      }  
  




/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/


/*int[,,] array3D = new int[2, 2, 2];
CreateArray(array3D);
WriteArray(array3D);


void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
  
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"{array3D[i,j,k]} {(i,j,k)}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        array3D[i, j, k] = temp[count];
        count++;
      }
    }
  }
}*/
