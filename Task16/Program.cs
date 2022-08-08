// int number1 = new Random().Next(1, 1000); //[1,1000]
// int number2 = new Random().Next(1, 1000); //[1,1000]
int number1 = 25;
int number2 = 51;
if (number1*number1 == number2 || number2*number2 == number1)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");