Console.Write("Enter number: ");
int n = int.Parse(Console.ReadLine());
int res = 1;
for (int i = 1; i <= n; i++)
{
    res *= i;
}
Console.WriteLine("factorial is: " + res);

