int first = 0;
int second = 1;
int result = 0;
int count = 0;

while (true)
{
    Console.WriteLine("Введите число из числового порядка Фибаначчи чтобы узнать его место в порядке");
    string a = Console.ReadLine();
    int b = int.Parse(a);
    fub(b);
}

void fub(int b)
{
    for (int i = 0; ; i++)
    {
        result = first + second;
        first = second;
        second = result;
        count++;

        if (result == b)
        {
            Console.WriteLine($"Число в последовательности - {count + 2}");
            break;
        }
    }
}