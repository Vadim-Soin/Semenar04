Console.WriteLine("Hello, World!");


void FillArray(int[]unmber)
{
    int length = unmber.Length;
    int i = 0;
    while (i<length)
    {
        Console.WriteLine($"Введите число{i+1}");
        unmber[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
}

void PrintArray(int[]unmber)
{
    int count = unmber.Length;
    int position = 0;
    while (position<count)
    {
        Console.Write( unmber[position]+". " );
        position++;
    }
}


int[] number = new int[8];
FillArray(number);
Console.WriteLine();
PrintArray(number);
Console.WriteLine();


















