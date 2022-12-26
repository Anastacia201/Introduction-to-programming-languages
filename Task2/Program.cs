// Задача 21: Напишите программу, которая принимает
// на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.

Console.WriteLine("Enter xA: ");
int xA = int.Parse(Console.ReadLine());

Console.WriteLine("Enter yA: ");
int yA = int.Parse(Console.ReadLine());

Console.WriteLine("Enter zA: ");
int zA = int.Parse(Console.ReadLine());

Console.WriteLine("Enter xB: ");
int xB = int.Parse(Console.ReadLine());

Console.WriteLine("Enter yB: ");
int yB = int.Parse(Console.ReadLine());

Console.WriteLine("Enter zB: ");
int zB = int.Parse(Console.ReadLine());

double AC = (xB - xA);
double BC = (yB - yA);
double CD = (zB - zA);

double AB = Math.Pow(AC, 2) + Math.Pow(BC, 2) + Math.Pow(CD, 2);

double result = Math.Sqrt(AB);

Console.WriteLine(result);