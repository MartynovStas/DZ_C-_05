/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int[] RandArrey(int saiz)
{
    int[] arrey = new int[saiz];
    Random rand = new Random();
    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = rand.Next(0, 30);
    }
    return arrey;
}

int ResultMax(int[] mass)
{
    int max = int.MinValue;

    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > max) { max = mass[i]; }
    }
    return max;
}

int ResultMin(int[] mass)
{
    int min = int.MaxValue;

    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] < min) { min = mass[i]; }
    }
    return min;
}

var myArrey = RandArrey(6);
int max = ResultMax(myArrey);
int min = ResultMin(myArrey);
int result = max - min;
System.Console.WriteLine("[" + string.Join(", ", myArrey) + "]");
System.Console.WriteLine($"Разность между {max} и {min}  равна: {result}");