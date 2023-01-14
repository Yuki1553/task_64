// Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от N до M. Выполнить с помощью рекурсии.
Console.Clear();
int m = InputInt("Введите число M ");
int n = InputInt("Введите число N ");
if (n <= 0)
{
    Console.WriteLine("Ввели не положительное число");
}
Console.WriteLine(NaturalNumber(n, m));

int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}