// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigit(int num)
{
    int sum = 0;
    if (num > 0)
    {
        while (num > 0)
        {
            sum = sum + num % 10;
            num = num / 10;
        }
    }
    return sum;
}

Console.WriteLine(SumDigit(number));
