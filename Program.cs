/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

Console.WriteLine("Введите число А ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int b = Convert.ToInt32(Console.ReadLine());
if (b > 0)
{
    Console.WriteLine($"Число {b} является натуральным");
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
Console.WriteLine($"Число {a} в степени {b} равно {result}");
}
else
{
    Console.WriteLine($"Число {b} не является натуральным");
}

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number > 0)
{
    int num = number % 10;
    number = number / 10;
    sum += num;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"[{String.Join("; ",(col[position]))}]");
        position++;
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);
*/
