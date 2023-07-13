// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите пятизначное число: ");
int number ;

while (true)
{
    Console.Write("Введите пятизначное число: ");
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Вы не ввели число, пожалуйста повторите попытку");
        continue;
    }

    if (!int.TryParse(input, out number))
    {
        Console.WriteLine("Вы ввели некорректное значение, пожалуйста повторите попытку");
        continue;
    }

    if (number < 10000 || number >= 100000)
    {
        Console.WriteLine($"Вы ввели не пятизначное число >{number}<, пожалуйста повторите попытку");
        continue;
    }
    break;
}

static int ReverseNumber(int number)
    {
        int reversedNumber = 0;

        while (number != 0)
        {
            int remainder = number % 10;
            reversedNumber = reversedNumber * 10 + remainder;
            number /= 10;
        }

        return reversedNumber;
    }

    int reversedNumber = ReverseNumber(number);

    if (number == reversedNumber)
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
