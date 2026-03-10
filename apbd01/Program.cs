for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Hello, World! " + (i + 1) + " time");
}
// Console.WriteLine("Enter 2 numbers you want to operate with");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter an operation");
// char operation = Convert.ToChar(Console.Read());
// Console.Write("The result is ");
// if (operation == '+')
// {
//     Console.WriteLine(a + b);
// }
// else if (operation == '-')
// {
//     Console.WriteLine(a - b);
// }
// else if (operation == '*')
// {
//     Console.WriteLine(a * b);
// }
// else if (operation == '/')
// {
//     Console.WriteLine((float) a / (float) b);
// }

static int CalculateMax(int[] values)
{
    int max = values[0];
    for (int i = 1; i < values.Length; i++)
    {
        if (values[i] > max)
        {
            max = values[i];
        }
    }
    return max;
}
static int CalculateMin(int[] values)
{
    int min = values[0];
    for (int i = 1; i < values.Length; i++)
    {
        if (values[i] < min)
        {
            min = values[i];
        }
    }
    return min;
}
Console.WriteLine("Enter the amount of numbers you want to find the maximum from");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the numbers");
List<int> numbers = new List<int>();
for (int i = 0; i < n; i++)
{
    numbers.Add(Convert.ToInt32(Console.ReadLine()));
}
Console.WriteLine("The maximum is equal to "  + CalculateMax(numbers.ToArray()));