Console.Write("Enter number: ");
string input = Console.ReadLine()!;
if (!int.TryParse(input, out int n) || n < 0)
{
    Console.WriteLine("Please enter a positive integer only");
}
else
{
    int res = 1;
    for (int i = 1; i <= n; i++)
    {
        res *= i;
    }
    Console.WriteLine("factorial is: " + res);

}

