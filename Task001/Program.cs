// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// _тип_возвращаемого_значения_ _название_функции_ (_принимаемые_аргументы_)
// {
//      _тело_функции_
// return <>
// }

int FindSum(int A)
{
    int sum = 0;

    for (int i = 1; i <= A; i++)
        sum -= i;

    return sum;
}

System.Console.WriteLine("Введите значение: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));


System.Console.WriteLine(FindSum(number));

System.Console.WriteLine(FindSum(7));

//string? strNumber = Console.ReadLine();
//System.Console.WriteLine(strNumber?.Length);