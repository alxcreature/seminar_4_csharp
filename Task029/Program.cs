/* Знакомство с языками программирования (семинары)
Урок 4. Функции

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33-> [6, 1, 33] */

int[] FillArray(int elementsNum){
   int[] filledArray = new int[elementsNum]; 
    for (int i=0; i<elementsNum; i++){
        System.Console.Write($"Введите {i} элемент массива: ");
        filledArray[i] = Convert.ToInt32(Console.ReadLine());
 
    }
    return filledArray;
}

void PrintArray(int[] array){
    System.Console.Write("[");
    for (int i=0; i<array.Length-1; i++) System.Console.Write($"{array[i]}, ");
    System.Console.Write($"{array[array.Length-1]}");
    System.Console.Write("]");
}

System.Console.Write("Введите количество элементов мссива: ");
PrintArray(FillArray(Convert.ToInt32(Console.ReadLine())));