/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите 
программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] RandArrey(int saiz)
{
    int[] arrey = new int[saiz];
    Random rand = new Random();
    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = rand.Next(100, 1000);
    }
    return arrey;
}

int ResultPositiv(int[] mass)
{
    int namber = 0;

    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] % 2 == 0)
        {
            namber++;
        }
    }
    return namber;
}

var myArrey = RandArrey(4);
int namber = ResultPositiv(myArrey);
System.Console.WriteLine("[" + string.Join(", ", myArrey) + "]");
System.Console.WriteLine($"Чётных чисел в масиве: {namber}");