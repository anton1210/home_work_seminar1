using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int firstNumber;
        int secondNumber;
        int max;
        
        Console.WriteLine("Введите первое число");
        firstNumber = (int) inputValue();
        Console.WriteLine("Введите второе число");
        secondNumber = (int) inputValue();
        if (firstNumber > secondNumber)
        {
            max = firstNumber;
        }
        else
        {
            max = secondNumber;
        }
        Console.WriteLine(max);
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
