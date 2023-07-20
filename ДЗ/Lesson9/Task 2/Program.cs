/*
 Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 M = 1; N = 15 -> 120
 M = 4; N = 8. -> 30 sumNumber
 */
 
Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

CallFunction(numberM, numberN);

// вызов функции сумма чисел от M до N
void CallFunction(int numberM, int numberN)
{
    Console.Write(sumNumber(numberM - 1, numberN));
}

// сама функция суммы чисел от M до N
int sumNumber(int numberM, int numberN)
{
    int result = numberM;
    if (numberM == numberN)
        return 0;
    else
    {
        numberM++;
        result = numberM + sumNumber(numberM, numberN);
        return result;
    }
}

