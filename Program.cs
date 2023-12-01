using System;

int sum = 0;
int input;

do
{
    Console.WriteLine("Введите число (для окончания введите 0): ");
    input = int.Parse(Console.ReadLine());
    sum += input;
}
while (input != 0);


Console.WriteLine($"Сумма введенных чисел: {sum}");