// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// if (number % 1 == number % 10000 || number % 100 == number % 1000)
// {
//     Console.WriteLine($"Число {number} является палиндромом");
// }
// else
// {
//     Console.WriteLine($"Число {number} не является палиндромом");
// }

int number1 = number % 1;
int number2 = number % 10;
int number3 = (number % 100) / 10;
int number4 = number % 1000;
int number5 = number % 10000;

Console.WriteLine($" {number} % 1 = {number1}");
Console.WriteLine($" {number} % 10 = {number2}");
Console.WriteLine($" {number} % 100 = {number3}");
Console.WriteLine($" {number} % 1000 = {number4}");
Console.WriteLine($" {number} % 10000 = {number5}");