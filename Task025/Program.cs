﻿/* Знакомство с языками программирования (семинары)
Урок 4. Функции
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
 */

 int Pow(int number, int power){
    int result = 1;
    for (int i=1; i<=power;i++) result*=number;
    return result;
 }

 int InputNum(){
    System.Console.Write("Введите число: ");
    return Convert.ToInt32(System.Console.ReadLine());
 }

int A=InputNum(), B=InputNum();
System.Console.WriteLine(Pow(A, B));