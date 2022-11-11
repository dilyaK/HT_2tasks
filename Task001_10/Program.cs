// Напишите программу, которая принимает на входе 
// трехзначное число и на выходе показывает 2-цифру этого числа:
// 456 -> 5;
// 782 -> 8;

int  result = 0;
Console.WriteLine("Enter a three-digit number: ");
int  numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" The second digit is:  ");
result = numA / 10 % 10;
Console.Write(result);




