// Задача 4: Напишите программу,
// которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.
Console.Clear();
Console.Write("Введите натуральное число: ");
int n = int.Parse(Console.ReadLine()!);
while (n > 0)
{   int x = n % 10;
    Console.Write($"{x}, ");
    n /= 10;
}

// Console.Clear();
// Console.Write("Введите натуральное число: ");
// int n = int.Parse(Console.ReadLine()!);
// for (int i = 1; i <= n; i++)
// Console.Write($"{i},"); выдает все числа до заданного через запятую

// как сделать, чтобы после последней цифры не было запятой?
