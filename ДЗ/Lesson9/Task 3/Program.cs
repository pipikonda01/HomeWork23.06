/*
 Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
 m = 2, n = 3 -> A(m,n) = 9
 m = 3, n = 2 -> A(m,n) = 29
*/
 
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

callAkkermanFunction(m,n);


// вызов функции Аккермана
void callAkkermanFunction(int m, int n)
{
    Console.Write(Akkermanfunction(m, n)); 
}

// функция Аккермана
int Akkermanfunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkermanfunction(m - 1, 1);
    }
    else
    {
        return (Akkermanfunction(m - 1, Akkermanfunction(m, n - 1)));
    }
}