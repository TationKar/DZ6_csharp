// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5-> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// <aside>
// ❗️ Числа Фибоначчи — числовая ****последовательность,
// каждый элемент которой равен сумме двух предыдущих.
Console.Clear();
Console.Write("Введите число, N: ");
int fiboN = int.Parse(Console.ReadLine()!);
PrintFiboN(fiboN);

void PrintFiboN(int firstN)
{
    int first = 0, second = 1;
    int sum = 0;
    Console.Write($"{first} {second} ");
    for (int i = 1; i < firstN - 1; i++)
    {
        sum = first + second;
        Console.Write($"{sum} ");
        first = second;
        second = sum;
    }
    Console.WriteLine();
}