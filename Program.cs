/* Домашнее задание.
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

/*using System;
using static System.Console;

Write("Введите  число N: ");
int N = int.Parse(ReadLine());
int a = 1;

Write (WriteNumbers (N, a) );

string WriteNumbers (int N , int a) 
{
    if (a == N)
    {
        return N.ToString();
    }
    return  N + ", " + WriteNumbers(--N, a); 
}*/

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

/*using System;
using static System.Console;

Write("Введите  число N: ");
int N = int.Parse(ReadLine());
Write("Введите  число M: ");
int M = int.Parse(ReadLine());
// N > M

WriteLine($"{SumNumbers(N)}");

int SumNumbers(int N)
{
    if (M > N)
    return 0;
    return (N + SumNumbers(N-1));
}*/

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

using System;
using static System.Console;

Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return akkerman(m - 1, 1);
else return akkerman(m - 1, akkerman(m, n - 1));
}

Write($"Функция Аккермана равно {akkerman(m, n)} ");
