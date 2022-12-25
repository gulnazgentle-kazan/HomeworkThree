/*Задача 21

Напишите программу, 
которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/


// Введение координат первой точки

Console.WriteLine("Введите координаты по X оси для первой точки");
double xFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты по Y оси для первой точки");
double yFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты по Z оси для первой точки");
double zFirst = Convert.ToInt32(Console.ReadLine());

// Введение координат второй точки

Console.WriteLine("Введите координаты по X оси для второй точки");
double xSecond = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты по Y оси для второй точки");
double ySecond = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты по Z оси для второй точки");
double zSecond = Convert.ToInt32(Console.ReadLine());

//Решения задачи и округление результата до сотых

double distance = Math.Round(Math.Sqrt(Math.Pow(xSecond - xFirst, 2) + Math.Pow(ySecond - yFirst, 2) + Math.Pow(zSecond - zFirst, 2)), 2);
Console.WriteLine($"Расстояние между координатами равно {distance}");