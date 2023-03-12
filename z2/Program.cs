// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int summa(int m, int n)
{  
    return m == n ? n : m + summa(m + 1, n);  // Тернарная операция: если m = n, то возворащается n, иначе возвращается m + summa(m + 1, n)
}
Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {summa(m,n)}");