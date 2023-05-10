// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D.

Console.WriteLine("Введите координаты x, y и z первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты x, y и z второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

int pointx = x2 - x1;
int pointy = y2 - y1;
int pointz = z1 - z2;

double S = Math.Round(Math.Sqrt(Math.Pow(pointx,2) + Math.Pow(pointy,2) + Math.Pow(pointz,2)), 2);
Console.WriteLine($"Расстояние между точками равно: {S}");