﻿// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;

if (numberB > max) {max = numberB;
Console.WriteLine("максимальное число " + max);}
else if (numberC > max) {max = numberC;
Console.WriteLine("максимальное число " + max);}
else 
{
    Console.WriteLine("все три числа равны");
}

