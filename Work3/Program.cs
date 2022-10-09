Практическая работа 3

Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

int a;
int.TryParse(Console.ReadLine()!, out a);

if (a % 10 == a / 10000 && a / 10 % 10 == a / 1000 % 10)
Console.Write($"Это палиндромом");
else
Console.Write($"Это не палиндромом");


Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

int[] A = new int [3]; 
int[] B = new int [3];
Console.Write($"Введите координату X первой точки  ");
int.TryParse(Console.ReadLine()!, out A[0]);
Console.Write($"Введите координату Y первой точки  ");
int.TryParse(Console.ReadLine()!, out A[1]);
Console.Write($"Введите координату Z первой точки  ");
int.TryParse(Console.ReadLine()!, out A[2]);
Console.Write($"Введите координату X2 второй точки  ");
int.TryParse(Console.ReadLine()!, out B[0]);
Console.Write($"Введите координату Y2 второй точки  ");
int.TryParse(Console.ReadLine()!, out B[1]);
Console.Write($"Введите координату Z2 второй точки  ");
int.TryParse(Console.ReadLine()!, out B[2]);
double c = Math.Sqrt((A[0] - B[0]) * (A[0] - B[0]) + (A[1] - B[1]) * (A[1] - B[1]) + (A[2] - B[2]) * (A[2] - B[2])); // определили расстояние по формуле

Console.Write($"Расстояние между точками = {c} ");



Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

int a;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

for (int i = 1; i <= a; i++)
    Console.Write($"{i*i*i}  ");

