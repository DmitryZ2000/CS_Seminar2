int number1 = new Random().Next(10, 100); //[10,99]
int number2 = new Random().Next(1, 10); //[10,99]
Console.WriteLine(number1);
Console.WriteLine(number2);
if ((number1 % number2) == 0)
    Console.WriteLine("Кратно");
else
{
    Console.Write("Не кратно. Остаток от деления:  ");
    Console.WriteLine(number1 % number2);
}
    