// EX:1

Console.WriteLine("This is exercise #1");

Console.WriteLine("Enter your first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"The {num1} is greater than {num2}.");
}

else if (num1 < num2)
{
    Console.WriteLine($"The {num1} is less than {num2}.");
}

else
{
    Console.WriteLine($"The first and second numbers are equal");
}

// EX:2

Console.WriteLine("This is exercise #2");

Console.WriteLine("Enter a random number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num3 > 5 && num3 < 10)
{
    Console.WriteLine($"The number is greater than 5 and less than 10.");
}

else
{
    Console.WriteLine($"Unknown number");
}

// EX:3

Console.WriteLine("This is exercise #3");

Console.WriteLine("Enter a random number: ");
int num4 = Convert.ToInt32(Console.ReadLine());

if (num4 == 5 || num4 == 10)
{
    Console.WriteLine($"The number is either 5 or 10.");
}

else
{
    Console.WriteLine($"Unknown number");
}

// EX: 4

Console.WriteLine("This is exercise #4");

Console.WriteLine("Enter an amount of deposit for bank: ");
double num5 = Convert.ToDouble(Console.ReadLine());

if (num5 < 100)
{
    Console.WriteLine($"The amount of deposit is : {num5}, and the amount with interest with 5% is: {num5 + (num5 * 0.05)}");
}

else if (num5 >= 100 && num5 <= 200)
{
    Console.WriteLine($"The amount of deposit is : {num5}, and the amount with interest with 7% is:  {num5 + (num5 * 0.07)}");
}

else if (num5 > 200)
{
    Console.WriteLine($"The amount of deposit is : {num5}, and the amount with interest with 10% is: {num5 + (num5 * 0.1)}");
}

// EX: 5

Console.WriteLine("This is exercise #5");

Console.WriteLine("Enter an amount of deposit for bank: ");
double num6 = Convert.ToDouble(Console.ReadLine());

if (num6 < 100)
{
    Console.WriteLine($"The amount of deposit is : {num6}, and the amount with interest is 5% and with bonus +15 is: {num6 + (num6 * 0.05) + 15}");
}

else if (num6 >= 100 && num6 <= 200)
{
    Console.WriteLine($"The amount of deposit is : {num6}, and the amount with interest is 7% and with bonus +15 is: {num6 + (num6 * 0.07) + 15}");
}

else if (num6 > 200)
{
    Console.WriteLine($"The amount of deposit is : {num6}, and the amount with interest is 10% and with bonus +15 is: {num6 + (num6 * 0.1) + 15}");
}

// EX:6

Console.WriteLine("This is exercise #6");

Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
int num7 = Convert.ToInt32(Console.ReadLine());

switch (num7)
{
    case 1:
        Console.WriteLine("Your action is Addition");
        break;
    case 2:
        Console.WriteLine("Your action is Subtraction");
        break;
    case 3:
        Console.WriteLine("Your action is Multiplication");
        break;
    default:
        Console.WriteLine("Operation is Undefined");
        break;
}

// EX:7

Console.WriteLine("This is exercise #7");

Console.WriteLine("Enter your first number: ");
int num8 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your second number: ");
int num9 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
int num10 = Convert.ToInt32(Console.ReadLine());

switch (num10)
{
    case 1:
        Console.WriteLine($"Addition of num1 and num2 is : {num8 + num9}");
        break;
    case 2:
        Console.WriteLine($"Subtraction of num1 and num2 is : {num8 - num9}");
        break;
    case 3:
        Console.WriteLine($"Multiplication of num1 and num2 is : {num8 * num9}");
        break;
    default:
        Console.WriteLine("Operation is Undefined");
        break;
}

