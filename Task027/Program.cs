/* Знакомство с языками программирования (семинары)
Урок 4. Функции

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
 */

 int SumSplitNum(int num){
    int result = 0;
    for(int i = num; i > 0; i/=10) result+=i%10;
    return result;
 }

 System.Console.Write("Введите число: ");
 System.Console.WriteLine(SumSplitNum(Convert.ToInt32(System.Console.ReadLine())));