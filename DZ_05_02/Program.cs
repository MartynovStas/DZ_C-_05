/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих 
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] RandArrey(int saiz)
{
    int[] arrey = new int[saiz];
    Random rand = new Random();
    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = rand.Next(-20, 20);
    }
    return arrey;
}

int ResultPositiv(int[] mass)
{
    int namber = 0;

    for (int i = 0; i < mass.Length; i++)
    {
        if(i%2 !=0)
        {
            namber += mass[i];
        }
    }
    return namber;
}

var myArrey = RandArrey(4);
int namber = ResultPositiv(myArrey);
System.Console.WriteLine("[" + string.Join(", ", myArrey) + "]");
System.Console.WriteLine($"Сумма нечётных массивов: {namber}");