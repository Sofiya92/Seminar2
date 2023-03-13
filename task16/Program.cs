// Напишите программу, которая принимает на вход 2 числа и проверяет, является ли 
// одно число квадратом другого.

Console.WriteLine("Введите первое число");
 int number1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите второе число");
 int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sqrt(number1, number2) ? "да" : "нет");

 bool Sqrt(int num1, int num2)
 {
    return num1 * num1 == num2 || num2 * num2 == num1;

 }
