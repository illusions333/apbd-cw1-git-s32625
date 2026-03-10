for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Hello, World! " + (i + 1) + " time");
}
Console.WriteLine("Enter 2 numbers you want to operate with");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter an operation");
char operation = Convert.ToChar(Console.Read());
Console.Write("The result is ");
if (operation == '+')
{
    Console.WriteLine(a + b);
}
else if (operation == '-')
{
    Console.WriteLine(a - b);
}
else if (operation == '*')
{
    Console.WriteLine(a * b);
}
else if (operation == '/')
{
    Console.WriteLine((float) a / (float) b);
}