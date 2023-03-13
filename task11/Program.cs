// Напишите программу, которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа.

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int firstDigit = number % 10;
int secondDigit = number / 100;
int result = secondDigit*10+firstDigit;
Console.WriteLine(result);

