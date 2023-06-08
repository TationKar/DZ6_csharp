/* Задача 43: Напишите программу, 
которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */
Console.Clear();
Console.WriteLine("Введите, последовательно параметры уравнений: ");
int[] param = new int[4];
Console.Write("Введите переменную b1: ");
param[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную k1: ");
param[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную b2: ");
param[2] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную k2: ");
param[3] = Convert.ToInt32(Console.ReadLine());
CrossLine(param);

void CrossLine(int[] par){
    decimal crossX = Convert.ToDecimal(-par[2] + par[0])/(par[3] - par[1]);
    decimal crossY = Convert.ToDecimal(par[1])*crossX + Convert.ToDecimal(par[0]);
    Console.WriteLine($"Точка пересечений линий ({crossX}; {crossY})");
}