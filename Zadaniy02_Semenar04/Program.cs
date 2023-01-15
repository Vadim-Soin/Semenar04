


void Sum(int x)
{
    int sum = 0;
    for (int i = 1; i <= x; i = i * 10)
    {
        sum+= x / i % 10;
    }
    Console.WriteLine($"{sum}");
}


Console.WriteLine("Введите число");
int num =Convert.ToInt32(Console.ReadLine());
Sum(num);












