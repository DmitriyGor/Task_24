/*
Задача 24
Напишите программу, которая принимает на вход число(А) и выдает сумму чисел от 1 до (А).
7 -> 28
4 -> 10
8 -> 36
*/

Console.Write("Enter the number A: "); // Введите число А
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= A; i++)
{
   sum += i; // sum = sum + i
   
}
Console.WriteLine($"the Sum of numbers from 1 to {A} is  {sum}");
// Сумма чисел от 1 до A равна 
