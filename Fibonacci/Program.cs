// See https://aka.ms/new-console-template for more information
int number = Convert.ToInt32(Console.ReadLine());
static void Fibonacci(int n)
{
    int a = 0;
    int b = 1;
    int sum = 2;
    for (int i = 0; i < n; i++)
    {
        int temp = a;
        a = b;
        b = temp + b;
        if (i == 0)
        {
            Console.Write("0" + "  ");
            Console.Write("1" + "  ");

        }
        Console.Write(b + "   ");
        sum++;
        if(sum%3 == 0) Console.WriteLine();
    }
}

Fibonacci(number);
