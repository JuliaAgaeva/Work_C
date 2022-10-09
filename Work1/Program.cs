Практическая работа 1

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*int N;
N = new Random().Next(0, 38);
Console.WriteLine(N);

for (int i = 2; i <= N; i += 2)
{
Console.Write($"{i} ");
}*/


/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a, b;
Console.Write($"Введите первое число: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите второе число: ");
int.TryParse(Console.ReadLine()!, out b);

if (a > b)
Console.Write($"Большее число = {a}, меньшее число = {b}");
else
Console.Write($"Большее число = {b}, меньшее число = {a}");*/


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


/*int a, b, c;
Console.Write($"Введите 3 числа:  ");
int.TryParse(Console.ReadLine()!, out a);
int.TryParse(Console.ReadLine()!, out b);
int.TryParse(Console.ReadLine()!, out c);
int max = a;
if (b > max)
max = b;
if (c > max)
max = c;
Console.Write($"Наибольшее из введённых чисел {max} ");*/


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int a;
Console.Write($"Введите число:  ");
int.TryParse(Console.ReadLine()!, out a);

if (a%2 == 1)
{
    Console.Write($"Число является: НЕЧЁТНЫМ");    
}
else
{
    Console.WriteLine("Число является: ЧЁТНЫМ");   
