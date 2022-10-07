﻿// Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
{
    Console.WriteLine("Число вне допустимого диапазона.");
} else if (number >= 1 && number <= 5) {
    Console.WriteLine("Не выходной.");
} else {
    Console.WriteLine("Выходной.");
}