// int number1 = new Random().Next(1, 1000); //[1,1000]
// int number1 = 161;
Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number);
if ((number % 7 == 0) && (number % 23 == 0))
{
    Console.WriteLine("Кратно 7 и 23 одновременн");
}
else
    Console.WriteLine("Не кратно 7 и 23 одновременн");