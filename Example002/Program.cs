// Показать числа Фибоначчи
int Fibonachi(int n)
{
    if (n == 0 || n == 1) return n;
     
    return Fibonachi(n - 1) + Fibonachi(n - 2);
}

int fib = Fibonachi(8);

 
Console.WriteLine($"число Фибоначчи = {fib}");
