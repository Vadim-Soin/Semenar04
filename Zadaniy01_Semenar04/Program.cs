




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

void Stp(int[]array)
{
    int pr = array[0];// возводимое число в степень
    int ar = array[1]-1;// степень в которую возводим число
    for (int i=0;i<ar;i++)
    {
        pr = pr * array[0];
    }
    Console.WriteLine($"{pr}");
}


int[] num = new int[2];
FillArray(num);
Stp(num);



