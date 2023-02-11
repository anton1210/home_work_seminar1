int firstNumber;
int secondNumber;
int max;

Console.WriteLine("Введите первое число");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
    max = firstNumber;
}
else
{
    max = secondNumber;
}
Console.WriteLine("Максимальное число: " + max);