// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Summ(int x, int y, int sumChisel)
    {
        if(x <= y)
                sumChisel = x + Summ(x+1,y,sumChisel);
        return sumChisel;
    }

// Программа
Console.Write("Введите значение M - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N - ");
int n = Convert.ToInt32(Console.ReadLine());
int sumChisel = 0;
if(m<n)
    Console.WriteLine($"Сумма чисел = {Summ(m,n,sumChisel)}");
else Console.WriteLine("Число М должно быть меньше N");