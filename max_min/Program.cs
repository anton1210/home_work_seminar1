int firstNumber;
int secondNumber;
int max;
int min;

Console.WriteLine("Введите первое число");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
    max = firstNumber;
    min = secondNumber;
}
else
{
    max = secondNumber;
    min = firstNumber;
}
Console.WriteLine("Максимальное число: " + max);
Console.WriteLine("Минимальное число: " + min);