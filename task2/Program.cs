﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
// Ввод чисел пользователями
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
// Условия и строки вывода 
if(num1 > num2)
{
Console.WriteLine("Первое число больше второго");
}
else if (num1 < num2)
{
Console.WriteLine("Первое число меньше второго");
}


