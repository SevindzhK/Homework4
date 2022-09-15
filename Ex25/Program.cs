// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.Write("Enter the number you want to raise to a power: ");
int number = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Enter the power you want to raise the number to: "); 
int power = Convert.ToInt32(Console.ReadLine());

double ExponentiateNumber(int num, int pow)
{
    if (pow == 0) 
    {
        return 1;
    }

    if (pow == 1) 
    {
        return num;
    }
    
    int result = num;
    if (pow > 0)
    {
        for (int count = 1; count < pow; count++)
        {
            result = result * num;
        }
    }
    else
    {
        return 1 / ExponentiateNumber(num, -1 * pow);  
    }
    
    return result;
}

Console.WriteLine(ExponentiateNumber(number, power)); 