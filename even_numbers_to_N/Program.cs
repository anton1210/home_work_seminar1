// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int n;
int i=1;

Console.WriteLine("Введите число");
n = Convert.ToInt32(Console.ReadLine());
while (n > i)
{
    Console.WriteLine(i + 1);
    i = i + 2;
}