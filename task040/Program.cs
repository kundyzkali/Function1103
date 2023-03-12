// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.WriteLine("Введите первую сторону треугольника:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону треугольника:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону треугольника:");
int c = Convert.ToInt32(Console.ReadLine());

bool isExistTriangle = IsExistTriangle(a, b, c);
Console.WriteLine(isExistTriangle ?"треугольник существует": "треугольник не существует" );

bool IsExistTriangle(int side1, int side2, int side3)
{
    return side1< side2 + side3 && side2< side1 + side3 && side3 < side2 + side1;
}
