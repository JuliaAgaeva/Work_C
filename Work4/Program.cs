


/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12


int a = 0;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

Console.Write($"Сумма цифр {a} = {Sum(a)}");

int Sum(int _a)
{
int sum = 0;
for (int i=0; 0 <_a/((int)Math.Pow(10, i));  i++)
sum = sum +_a/((int)Math.Pow(10, i)) % 10;
return sum;
}*/



/*Задача 25: Напишите функцию, используя цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

int a, b;
Console.Write($"Введите a: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите b: ");
int.TryParse(Console.ReadLine()!, out b);

Console.Write($"a в степени b = {rezult (a,b)} ");

int rezult (int _a, int _b) 
{
int Rezult = 1;
for (int i = 1; i <= _b; i++)
Rezult = (int)Math.Pow(a, i);
return Rezult;
}*/


/*Напишите функцию, которая задаёт массив из 8 элементов и выводит их на экран.



int[] array;

array = CreateArray();
for (int i = 0; i < 8; i++)
Console.Write($" {array[i]} ");


int[] CreateArray()
{
int[] _array = new int[8];
for (int i = 0; i < 8; i++)
_array[i] = new Random().Next(0, 100);
return _array;
}

