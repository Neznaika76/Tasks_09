// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void Enter(int x, int y)
    {
        Console.Write($"| {x} |");
        if(x<y)
            {
                x++;
                Enter(x,y);
            }
        return;
    }

// Программа
Console.WriteLine("Введите значение M - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N - ");
int n = Convert.ToInt32(Console.ReadLine());
if(m<n)
    {
        Console.Write("");
        Enter(m,n);
        Console.WriteLine("");  
    }
else Console.WriteLine("Число М должно быть меньше N");
