// int number1 = new Random().Next(1, 1000); //[1,1000]
// int number2 = new Random().Next(1, 1000); //[1,1000]
// int number1 = 25;
// int number2 = 51;
Console.Write("Введите любое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1*number1 == number2 || number2*number2 == number1)
{
    Console.WriteLine("Одно число является квадратом другого числа");
}
    
else
    Console.WriteLine("Числа не являются квадратами друг друга");