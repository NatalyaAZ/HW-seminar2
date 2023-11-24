// Задача 2: Напишите программу, 
// которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

Console.Clear();
Console.Write("Введите координаты x: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты y: ");
int y = int.Parse(Console.ReadLine()!);
if (x == 0 || y == 0)
{
Console.WriteLine("Error: X ≠ 0 и Y ≠ 0");
// x = int.Parse(Console.ReadLine()!);  // ??? не знаю как сделать так, чтобы после Error преребрасывало опять на ввод координат
// y = int.Parse(Console.ReadLine()!);
}
else
if ((x > 0) && (y > 0))
Console.Write("Точка в 1 координатной четверти");
if ((x < 0) && (y < 0))
Console.Write("Точка в 3 координатной четверти");
if ((x > 0) && (y < 0))
Console.Write("Точка в 4 координатной четверти");
if ((x < 0) && (y > 0))
Console.Write("Точка во 2 координатной четверти");