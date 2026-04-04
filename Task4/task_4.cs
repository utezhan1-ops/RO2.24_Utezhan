Console.WriteLine("Task 1");

int[] numbers = { 3, 7, 2, 9, 5, 1 };
int totalSumma = 0;

foreach (int number in numbers)
{
    totalSumma += number;
}

Console.WriteLine(totalSumma);

// task 2.1

Console.WriteLine("Task 2");

int[] temp = { 12, -3, 45, 0, 28, -10, 33 };

int minNumber = temp.Min();
int maxNumber = temp.Max();

Console.WriteLine($"min: {minNumber},max: {maxNumber}");


// task 2.2

int[] temps = { 12, -3, 45, 0, 28, -10, 33 };
Array.Sort(temps);
int minSort = temps[0];
int maxSort = temps[temps.Length - 1];
Console.WriteLine($"min: {minSort}, max: {maxSort}");

// task 3

Console.WriteLine("Task 3");

string[] words = { "apple", "banana", "cherry", "date" };
Array.Reverse(words);
Console.WriteLine(string.Join(" ", words));

// task 4

Console.WriteLine("Task 4");

int[] data = { 4, 7, 2, 11, 6, 9, 14, 3, 8 };

int evenNumber = 0;
int oddNumber = 0;

foreach (int number4 in data)
{
    if (number4 % 2 == 0)
    {
        evenNumber++;
    }
    else
    {
        oddNumber++;
    }
}

Console.WriteLine($"Even: {evenNumber} Odd: {oddNumber}");

// task 5

Console.WriteLine("Task 5");

int[] raw = { 1, 3, 2, 3, 5, 1, 4, 2, 5 };
int[] arr = raw.ToArray();

for (int i = 0; i < arr.Length; i++)
{
    if (Array.IndexOf(arr, arr[i]) == i)
    {
        Console.WriteLine(arr[i] + " ");
    }
}

// task 6

Console.WriteLine("Task 6");

int[] arr2 = { 1, 2, 3, 4, 5, 6, 7 };
int k = 3;

static int[] RotateLeft(int[] arr, int k)
{
    int n = arr.Length;
    k %= n;
    int[] rotated = new int[n];

    for (int i = 0; i < n; i++)
    {
        rotated[i] = arr[(i + k) % n];
    }

    return rotated;
}

Console.WriteLine(string.Join(", ", RotateLeft(arr2, k)));

// Task 7
string s = "madam";
int length = s.Length;
int half = length / 2;
bool isPalindrome = true;

for (int i = 0; i < half; i = i + 1)
{
    if (s[i] != s[length - 1 - i])
    {
        isPalindrome = false;
    }
}
Console.WriteLine("Task 7");
Console.WriteLine("madam - " + isPalindrome);

// Task 8
int n8 = 5;
long result8 = 1;
for (int i = 2; i <= n8; i = i + 1)
{
    result8 = result8 * i;
}
Console.WriteLine("Task 8");
Console.WriteLine("Factorial of 5 = " + result8);

// Task 9
Console.WriteLine("Task 9");
for (int i = 1; i <= 20; i = i + 1)
{
    if (i % 15 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i.ToString());
    }
}

// Task 10
Console.WriteLine("Task 10");
double[] celsius = { 0, 20, 37, 100, -40 };
for (int i = 0; i < celsius.Length; i = i + 1)
{
    double c = celsius[i];
    double f = c * 9.0 / 5.0 + 32.0;
    Console.WriteLine(c + "C = " + f + "F");
}