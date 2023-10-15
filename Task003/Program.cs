/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120 */

int Mult(int N){
    int res = 1;
    for (int i = 1; i <= N; i++) res *= i;
    return res;
}
int ReadNum(){
    System.Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine(Mult(ReadNum()));