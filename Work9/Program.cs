/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/

/*Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите начальное число N:");
int numberN = int.Parse(Console.ReadLine()!);

///Метод вычисления функции Аккермана:
int AckermannFunction (int _numberM, int _numberN)
{
    if (_numberM == 0) return _numberN + 1;
    if (_numberM != 0 && _numberN == 0) return AckermannFunction(_numberM - 1, 1);
    if (_numberM > 0 && _numberN > 0) return AckermannFunction(_numberM - 1, AckermannFunction(_numberM, _numberN - 1));
return AckermannFunction(_numberM, _numberN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");



Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


/*int a;
Console.Write($"Введите число:  ");
int.TryParse(Console.ReadLine()!, out a);

PrintNumbers (a,1);

void PrintNumbers (int _start, int _end)
{
    if (_start >= _end)
    {
        Console.Write($"{_start}  ");
        PrintNumbers (_start-1, _end);
    }
}*/


/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int m;
Console.Write($"Введите число:  ");
int.TryParse(Console.ReadLine()!, out m);
int n;
Console.Write($"Введите число:  ");
int.TryParse(Console.ReadLine()!, out n);

int CalculateSumm(int _m, int _n)
		{
			int start = _m;
			int end = _n;
			if(_m > _n)
			{
				start = _n;
				end = _m;
			}
			return (end + start)*(end - start + 1)/2; // по формуле суммы членов арифметической прогрессии
		}
		
		Console.WriteLine(CalculateSumm(m, n));
	



