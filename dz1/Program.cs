// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
using static System.Console;
int APowB(int a, int b)
{
    int answer = 1;
    for (int i =1; i <= b; i++)
    {
        answer *=a;
    }
    return answer;
}
WriteLine("Введите число А ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите число В");
int b = Convert.ToInt32(ReadLine());

int answer= APowB(a,b);

Write(answer);
