// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine($"Введи числа с клавиатуры через запятую: ");
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
Console.WriteLine("Количество чисел больше ноля: " + count);
