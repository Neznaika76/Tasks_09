// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int Akkerman(int number, int argument)
    {
        if(number == 0)
            return argument + 1;
        else
            if((number != 0) && (argument == 0))
                return Akkerman(number-1,1);
            else
                return Akkerman(number-1, Akkerman(number, argument-1));
    }

// Программа
Console.Write("Введите значение m - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n - ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({m},{n}) = {Akkerman(n,m)}");