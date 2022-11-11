// Напишите программу, которая выводит 3-цифру 
// заданного числа или сообщает что 3-цифры нет.
// 645 -> 5;
// 78 -> 3-цифры нет;
// 37679 -> 6

int result = 0;
Console.WriteLine("Enter a number: ");

int numA = Convert.ToInt32(Console.ReadLine());
if (numA < 100)
{
    Console.WriteLine("NO THIRD DIGIT");
}

else
{

        result = numA / 1 % 10;
    
    Console.WriteLine(" The third digit is: [result]");
    Console.Write(result);
}


