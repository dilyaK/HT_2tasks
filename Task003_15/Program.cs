// Напишите программу, которая принимает на вход 
// цифру обозначающую день недели и проверяет, является ли этот день выходным.
//6 - да; 7 - да; 1 - нет;


int numA = 0;
Console.WriteLine($"Enter a number for the day of the week ");
numA = Convert.ToInt32(Console.ReadLine());

if (numA > 0 && numA <= 7)
{
    if (numA == 6 || numA == 7)
    {
        Console.WriteLine("This day is a weekend");
    }
    else
    {
        Console.WriteLine("It's a work day");
    }
}
