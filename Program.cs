﻿//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Deg(int num1, int num2)
{
    int degree = Convert.ToInt32(Math.Pow(num1, num2));
    return degree;
}

Console.WriteLine("Input number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a + " в степени " + b + " -> " + Deg(a, b));

// ИЛИ

void Deg(int num1, int num2)
{
    int degree = Convert.ToInt32(Math.Pow(num1, num2));
    Console.WriteLine(num1 + " в степени " + num2 + " -> " + degree);
}

Console.WriteLine("Input number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B: ");
int b = Convert.ToInt32(Console.ReadLine());
Deg(a, b);

// * Все еще не понимаю, где же использовать void  а где с типом данных. И то и то работает
