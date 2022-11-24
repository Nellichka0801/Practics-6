﻿//  Напишите программу, которая найдёт точку пересечения 
//двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void FindingTheIntersectionPoint()
// {
//     Console.WriteLine("Введите значения b1");
//     double b1 = double.Parse(Console.ReadLine()!);
//     Console.WriteLine("Введите значения b2");
//     double b2 = double.Parse(Console.ReadLine()!);
//     Console.WriteLine("Введите значения k1");
//     double k1 = double.Parse(Console.ReadLine()!);
//     Console.WriteLine("Введите значения k2");
//     double k2 = double.Parse(Console.ReadLine()!);
//     double x = (b2-b1)/(k1-k2);
//     double y = k1*x+b1;   
//     Console.WriteLine("Координаты точки пересечения x = "+ x + " y = " + y);
//     System.Console.WriteLine();
// }
// FindingTheIntersectionPoint();

Console.WriteLine("Введите значения b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значения b2");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значения k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значения k2");
double k2 = double.Parse(Console.ReadLine()!);

void FindingTheIntersectionPoint(double k1, double k2,double b1,double b2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k1*x+b1;   
    Console.WriteLine("Координаты точки пересечения x = "+ x + " y = " + y);
    System.Console.WriteLine();
}
FindingTheIntersectionPoint(k1,k2,b1,b2);