/*Практическая работа 5


/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2


/*int[] array = CreateArray(4, 100, 1000);


int count = 0;

for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
count ++;

}

PrintArray(array);
Console.Write($"\n {count}");

int[] CreateArray(int size, int min = 100, int max = 1000)

{
int[] _array = new int[size];
for (int i = 0; i < size; i++)
_array[i] = new Random().Next(min, max);
return _array;
}

void PrintArray(int[] _array)
{
foreach (var item in _array)
Console.Write($"{item} ");
}*/




/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

/*int[] array = CreateArray(6, -10, 100);


int Sum = 0;

for (int i = 0; i < array.Length; i++)
{
if (i % 2 == 0)
Sum = Sum + array[i];

}

PrintArray(array);
Console.Write($"\n {Sum}");

int[] CreateArray(int size, int min = -10, int max = 100)

{
int[] _array = new int[size];
for (int i = 0; i < size; i++)
_array[i] = new Random().Next(min, max);
return _array;
}

void PrintArray(int[] _array)
{
foreach (var item in _array)
Console.Write($"{item} ");
}*/






/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

double[] array = CreateArray(5);

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
if (array[i] > max)
max = array[i];
if (array[i]<min)
min = array[i];
}

PrintArray(array);
Console.Write($"\n{max-min}");

double[] CreateArray(int size)
{
double[] _array = new double[size];
for (int i = 0; i < size; i++)
_array[i] = new Random().NextDouble();
return _array;
}

void PrintArray(double[] _array)
{
foreach (var item in _array)
Console.Write($"{item} ");
}