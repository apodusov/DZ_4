﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B");
int num2 = int.Parse(Console.ReadLine());

int result = 1;
for (int i = 0; i < num2; i++)
{
    result = result * num1;
}

Console.WriteLine(result);