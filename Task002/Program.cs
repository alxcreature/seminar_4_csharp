// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int FindLen(int N)
{
    int len = 0;

    while (N > 0)
    {
        N /= 10;
        len++;
    }

    return len;
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

// -----------------------------------

int number = ReadInt("Введите число: ");
System.Console.WriteLine(FindLen(number));
