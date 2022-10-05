Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
while (999 < number){
  number = number / 10;
}
if (99 < number) {
Console.WriteLine(number % 10);
} else {
  Console.WriteLine("Третьей цифры нет.");
}