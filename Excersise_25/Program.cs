// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Enter number: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Enter degree of a number: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Number " + a + " in degree " + b + " is " + Math.Pow(a,b));