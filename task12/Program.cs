// Наптштье программу, которая на вход будет принимать  2 числа и выводить,является ли
// первое чило кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления
Console.WriteLine("Введите первое число");
 int number1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите второе число");
 int number2 = Convert.ToInt32(Console.ReadLine());
 int remainsDigits = RemainsDigits (number1, number2);
 Console.WriteLine(remainsDigits == 0? "кратно": $"некратно, остаток = {remainsDigits}");

 int RemainsDigits(int num1, int num2)
 {
  return num1 % num2;
  Console.WriteLine();
 }