// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
using static System.Console;
int SummDigitsNumber (int number)
{
    int sum = 0;

    while (number>0)
    {
        int i = number % 10;
        number = number /10;
        sum = sum + i;
    }
    return sum;
}
WriteLine("Введите число");
int a = Convert.ToInt32(ReadLine());
int sum = 0;

Write("Сумма цифр в числе : " + a + " = " + SummDigitsNumber(a));
