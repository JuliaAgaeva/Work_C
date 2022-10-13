
/*  Практическая работа 6


Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/




/*int k1, k2, b1, b2;
Console.Write($"Введите k1:  ");
int.TryParse(Console.ReadLine()!, out k1);
Console.Write($"Введите k2:  ");
int.TryParse(Console.ReadLine()!, out k2);
Console.Write($"Введите : b1 ");
int.TryParse(Console.ReadLine()!, out b1);
Console.Write($"Введите b2:  ");
int.TryParse(Console.ReadLine()!, out b2);

double x,y;

x = (b2-b1)/(k1-k2);
x = Math.Round (Convert.ToDouble(b2-b1)/Convert.ToDouble(k1-k2),1);
y=k1*x+b1;
y = Math.Round (Convert.ToDouble(k1*x)+Convert.ToDouble(b1),1);
Console.Write($"Координата точки пересечения прямых: {(x,y)}"); */ 




/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4 */

Console.Write("Введите M:\n ");
int M = int.Parse(Console.ReadLine()!);
int[] array = new int[M];
int count = 0;

for (int i = 0; i < M; i++)
{
Console.Write($"Введите число {i+1}: \n ");
array[i] =int.Parse(Console.ReadLine()!);
}

 for (int i = 0; i < M; i++)
{  
 if (array[i] > 0)
        count++;   
}   
Console.WriteLine($"Положительных чисел: {count}");



