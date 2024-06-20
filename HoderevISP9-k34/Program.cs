using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Вызов всех задач
        Zadacha1();
        Zadacha2();
        Zadacha3();
        Zadacha4();
        Zadacha5();
        ZadachaPoCiklam1();
        ZadachaPoCiklam2();
        ZadachaPoCiklam3();
        ZadachaPoMassivam1();
        ZadachaPoMassivam2();
        ZadachaPoMassivam3();
    }

    // Задача 1
    static void Zadacha1()
    {
        Console.WriteLine("Введите первое число:");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        if (number1 == number2)
        {
            Console.WriteLine("Числа равны.");
        }
        else if (number1 > number2)
        {
            Console.WriteLine("Первое число больше второго.");
        }
        else
        {
            Console.WriteLine("Первое число меньше второго.");
        }
    }

    // Задача 2
    static void Zadacha2()
    {
        Console.WriteLine("Введите число:");
        double number = Convert.ToDouble(Console.ReadLine());

        if (number >= 5 && number <= 10)
        {
            Console.WriteLine("Число больше 5 и меньше 10.");
        }
        else
        {
            Console.WriteLine("Неизвестное число.");
        }
    }

    // Задача 3
    static void Zadacha3()
    {
        Console.WriteLine("Введите число:");
        double number = Convert.ToDouble(Console.ReadLine());

        if (number == 5 || number == 10)
        {
            Console.WriteLine("Число либо равно 5, либо равно 10.");
        }
        else
        {
            Console.WriteLine("Неизвестное число.");
        }
    }

    // Задача 4
    static void Zadacha4()
    {
        Console.WriteLine("Введите сумму вклада:");
        double sum = Convert.ToDouble(Console.ReadLine());
        double interestRate;

        if (sum < 100)
        {
            interestRate = 0.05;
        }
        else if (sum <= 200)
        {
            interestRate = 0.07;
        }
        else
        {
            interestRate = 0.10;
        }

        double finalSum = sum + sum * interestRate;
        Console.WriteLine("Сумма вклада с процентами: " + finalSum);
    }

    // Задача 5
    static void Zadacha5()
    {
        Console.WriteLine("Введите номер операции: 1. Сложение 2. Вычитание 3. Умножение");
        int operation = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case 1:
                Console.WriteLine("Сложение");
                break;
            case 2:
                Console.WriteLine("Вычитание");
                break;
            case 3:
                Console.WriteLine("Умножение");
                break;
            default:
                Console.WriteLine("Операция неопределена.");
                break;
        }
    }

    // Задача по циклам 1
    static void ZadachaPoCiklam1()
    {
        Console.WriteLine("Введите сумму вклада:");
        decimal sum = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Введите количество месяцев:");
        int months = Convert.ToInt32(Console.ReadLine());
        decimal interestRate = 0.07m;

        for (int i = 0; i < months; i++)
        {
            sum += sum * interestRate;
        }

        Console.WriteLine("Конечная сумма вклада: " + sum);
    }

    // Задача по циклам 2
    static void ZadachaPoCiklam2()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write(i * j + "\t");
            }
            Console.WriteLine();
        }
    }

    // Задача по циклам 3
    static void ZadachaPoCiklam3()
    {
        while (true)
        {
            Console.WriteLine("Введите первое число:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 >= 0 && number1 <= 10 && number2 >= 0 && number2 <= 10)
            {
                Console.WriteLine("Произведение: " + (number1 * number2));
                break;
            }
            else
            {
                Console.WriteLine("Введены недопустимые числа. Попробуйте снова.");
            }
        }
    }

    // Задача по массивам 1
    static void ZadachaPoMassivam1()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Нечетные числа из массива:");

        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.WriteLine(number);
            }
        }
    }

    // Задача по массивам 2
    static void ZadachaPoMassivam2()
    {
        string[] strings = { "яблоко", "банан", "апельсин" };
        Console.WriteLine("Введите строку:");
        string inputString = Console.ReadLine();

        if (strings.Contains(inputString))
        {
            Console.WriteLine("Строка найдена!");
        }
        else
        {
            Console.WriteLine("Строка не найдена!");
        }
    }

    // Задача по массивам 3
    static void ZadachaPoMassivam3()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        double average = (double)sum / numbers.Length;
        Console.WriteLine("Сумма элементов массива: " + sum);
        Console.WriteLine("Среднее арифметическое значение элементов массива: " + average);
    }
}
