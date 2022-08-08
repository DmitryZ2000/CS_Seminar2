int number = new Random().Next(10, 1000); //[10,99]
Console.WriteLine(number);
int digit1 = number / 100;
int digit2 = number % 10;
int newdigit = digit1 * 10 + digit2;
Console.WriteLine(newdigit);
