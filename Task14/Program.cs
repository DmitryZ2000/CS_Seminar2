int number1 = new Random().Next(1, 1000); //[1,1000]
int number1 = 161;
Console.WriteLine(number1);
if ((number1 % 7 == 0) && (number1 % 23 == 0))
{
    Console.WriteLine("Кратно");
}
else
    Console.WriteLine("Не кратно");