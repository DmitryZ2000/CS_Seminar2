int number = new Random().Next(10,100); //[10,99]
int digit1 = number / 10;
int digit2 = number % 10;
Console.WriteLine(number);
if (digit1 > digit2)
    Console.WriteLine(digit1);
else
    Console.WriteLine(digit2);