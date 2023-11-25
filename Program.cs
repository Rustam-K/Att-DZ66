Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = CalcSum(m, n);

Console.WriteLine($"Сумма натуральных чисел от {m} до {n}: {sum}");


int CalcSum(int start, int end)
{
    if (start > end)
    {
        return 0;
    }
    return start + CalcSum(start + 1, end);
}