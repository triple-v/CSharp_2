// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
if (99 < num && num < 1000) {
int secondDigit = num % 100 / 10;
Console.WriteLine($"{secondDigit}");
} else {
  Console.WriteLine("Число не является трёхзначным.");
}