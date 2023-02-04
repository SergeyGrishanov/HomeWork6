﻿// программа, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();

Console.WriteLine ("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine()!);

Console.WriteLine ("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine()!);

Console.WriteLine ("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine()!);

Console.WriteLine ("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine()!);

double x = (b2-b1)/(k1-k2);
double y = k1*x+b1;
Console.WriteLine ($"Точка пересечения 2-х прямых имеет координаты: ({x};{y})");