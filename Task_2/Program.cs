// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите два числа...\nВведите первое число: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = int.Parse(Console.ReadLine());

if (n > m) Console.Write($"max = {n}");
else if (n == m) Console.Write("Два числа равны!");
else Console.Write($"max = {m}");
