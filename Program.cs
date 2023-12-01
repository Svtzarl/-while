using System;

Console.WriteLine("Введите 1 число(до 100)");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число(до 100)");
int y = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int i = x;

while (i <= y)
{
    sum += i;
    i++;
}

Console.WriteLine($"Сумма всех чисел от {x} до {y}: {sum}");
