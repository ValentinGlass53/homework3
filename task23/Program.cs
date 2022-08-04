/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int i = 1;
Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());
while (i <= num)
{
    int cube = i * i * i;
    i++;
    Console.WriteLine(cube);

}