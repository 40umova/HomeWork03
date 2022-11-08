// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите число: ");
string? n = Console.ReadLine();

void CheckingNumber(string n)
{
  if (n[0]==n[4] || n[1]==n[3]){
    Console.WriteLine($"Ваше число: {n} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {n} - НЕ палиндром.");
}

if (n!.Length == 5){
  CheckingNumber(n);
}
else Console.WriteLine($"Введи правильное число");
