using System;
using System.Globalization;

public class FirstTask
{
	public static void Main1()
    {
        /*
        UseCase:
        1. 	Пользователь запускает программу
        2. 	В терминале предлагается ввести число номер 1 – пользователь вводит число номер 1
        3. 	В терминале предлагается ввести допустимую операцию(+, -, *, /) – пользователь вводит операцию
        4. 	В терминале предлагается ввести число номер 2 – пользователь вводит число номер 2
        5. 	В терминал выводится результат выбранной операции
        */
        float firstNumber;
        float secondNumber;
        string operetion;

        Console.WriteLine("Введите первое число: ");
        string? firstNumberString = Console.ReadLine();

        Console.WriteLine("Введите операцию (+, -, /, *): ");
        string? operation = Console.ReadLine();

        Console.WriteLine("Введите второе число: ");
        string? secondNumberString = Console.ReadLine();

        firstNumber = float.Parse(firstNumberString, CultureInfo.InvariantCulture);
        secondNumber = float.Parse(secondNumberString, CultureInfo.InvariantCulture);

        switch (operation)
        {
            case "+":
                Console.WriteLine($"Результат операции: {firstNumber + secondNumber}");
                break;
            case "-":
                Console.WriteLine($"Результат операции: {firstNumber - secondNumber}");
                break;
            case "*":
                Console.WriteLine($"Результат операции: {firstNumber * secondNumber}");
                break;
            case "/":
                if (secondNumber == 0)
                {
                    Console.WriteLine("Нельзя делить на 0, иди в школу!");
                }
                else
                {
                    Console.WriteLine($"Результат операции: {firstNumber / secondNumber}");
                }
                break;
            default:
                Console.WriteLine("Введены недопустимые значения");
                break;

        }
    }
}
