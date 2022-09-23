//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
//Ввод переменной
int numMax = num1;
//Условия
if(num2 > numMax)
{
numMax = num2;
}
if(num3 > numMax)
{
numMax = num3;
}
//Вывод наибольшего числа
Console.WriteLine($"Наибольшее число:{numMax}");

