/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
Console.Clear();
Console.Write("Введите массив целых чисел положительных и отрицательных: ");
int[] ints = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(i => int.Parse(i)).ToArray<int>();
Console.WriteLine($"[{String.Join(", ", ints)}]");
PositivNum(ints);

void PositivNum(int[] array)
{
    int sum = 0;
    foreach (var el in array)
    {
        if (el > 0) sum += 1;
    }

    if (sum > 0)
        Console.WriteLine($"В массиве положительных чисел: {sum}");
    else
        Console.WriteLine("В массиве нет положительных чисел");
}
