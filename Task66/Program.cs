// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = 4;
int N = 8;
int sum=0;
int printNaturals(int M)
    {   
        if(M<=N)
        {
        sum+=M;
        printNaturals(M+1);
        }
    return sum;
    }
Console.Write(printNaturals(M));
