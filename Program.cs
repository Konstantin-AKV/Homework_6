// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

/* Console.WriteLine($"Введи числа с клавиатуры через запятую: ");
string s = Console.ReadLine();
string[] M = s.Split(',');
int[] mass = new int[M.Length];
int count = 0;
for (int i = 0; i < M.Length; i++)
{
    mass[i] = int.Parse(M[i]);

if (mass[i] > 0)
    {
        count++;
    }
}
Console.WriteLine("Количество чисел больше ноля: " + count); */

// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.WriteLine("Введите коэффициенты уравнений прямых: ");
double b1 = double.Parse(Console.ReadLine());
double k1 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());
double k2 = double.Parse(Console.ReadLine());
double x = 0;
double y = 0;
if (k1 == k2 || b1 == b2)
{
    Console.WriteLine("Прямые не пересекаются");
}
else
{
    x = (b1 - b2) / (k2 - k1);
    y = (k2 * b1 - k1 * b2) / (k2 - k1);
    Console.WriteLine("Точка пересечения:" + "(" + x + ";" + y + ")");
}