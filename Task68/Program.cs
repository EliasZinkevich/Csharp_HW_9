// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
// m = 3, n = 2 -> A(m,n) = 9
uint m=3;
uint n=2;
uint akkermann(uint n, uint m)
{
    if(n==0)
    {
    return m+1;
    }
    else if(m==0)
    {
    return akkermann(n-1,1);
    }
    else 
    {
    return akkermann(n-1, akkermann(n,m-1));
    }
}
Console.WriteLine(akkermann(n,m));