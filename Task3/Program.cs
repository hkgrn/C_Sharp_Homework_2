// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите N: ");
int Num = Convert.ToInt32(Console.ReadLine());
double result = 1;

Console.WriteLine("Кубы чисел от 1 до N: ");
for (int i=1; i <= Num; i++)
{
    result = Math.Pow(i, 3);
    Console.WriteLine(result);
}
