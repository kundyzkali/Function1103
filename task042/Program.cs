// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int num = Prompt("Введите число: ");
int found = Prompt("Введите целое десятичное число основание системы исчесления: ");
Console.WriteLine(DecToBin(num, found));
Console.WriteLine(DecToBin(num));
 
 int DecToBin(int num)
{
    int res = 0;
    int multiplier = 1;
    while(num > 0)
    {
     res += (num % 2)* multiplier; 
     num = num / 2;
     multiplier *=10;
    }
return res;
}

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}