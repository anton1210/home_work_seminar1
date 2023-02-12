// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

double first;
double second;
double third;
double max;

Console.WriteLine("Введите первое число");
first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
third = Convert.ToInt32(Console.ReadLine());
if (first > second && first > third)
{
    max = first;
}
else
{
    if (second > third)
    {
        max = second;
    }
    else
    {
        max = third;
    }
}
Console.WriteLine("Максимальное из введённых чисел = " + max);