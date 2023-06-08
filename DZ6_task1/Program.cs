/* Задача 45: Напишите программу,
которая будет создавать копию заданного массива 
с помощью поэлементного копирования. */
Console.Clear();
Console.Write("Введите размер массива sizeArr: ");
int sizeArr = int.Parse(Console.ReadLine()!);
int[] originArr = FillArray(sizeArr);
Console.WriteLine($"[{String.Join(", ", originArr)}]");
Console.WriteLine($"[{String.Join("| ", CopyArray(originArr))}]");

int[] FillArray(int sizeArr)
{
    int[] resultArr = new int[sizeArr];
    for (int i = 0; i < resultArr.Length; i++)
    {
        resultArr[i] = new Random().Next(10);
    }
    return resultArr;
}

int[] CopyArray(int[] array)
{
    int[] copyArr = new int[array.Length];
    for (int i = 0; i < copyArr.Length; i++)
    {
        copyArr[i] = array[i];
    }
    return copyArr;
}