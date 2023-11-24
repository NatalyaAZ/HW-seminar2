// Задача 3: Напишите программу, 
// которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

Console.Clear();
Console.Write("Введите число от 10 до 99: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 10 || n > 99)
{
Console.WriteLine("Errore: недопустимое значение. Попробуй ещё раз: "!);
n = int.Parse(Console.ReadLine()!);
}
if ((n / 10) > (n % 10))
Console.WriteLine(n / 10);
if ((n / 10) < (n % 10))
Console.WriteLine(n % 10);
if ((n / 10) == (n % 10)) 
Console.WriteLine("Цифры одинаковы"); 