﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int N = Convert.ToInt32(Console.ReadLine());
int n = 0;
while (n<N-1)
{
    n+=2; 

Console.Write(n);
Console.Write(",");
}
