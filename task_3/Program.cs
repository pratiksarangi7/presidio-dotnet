List<string> students = new();
void printList()
{
    foreach (string student in students)
    {
        Console.WriteLine(student);
    }
}
while (true)
{
    Console.Write("Enter number 0/1/2/3: ");

    int n = int.Parse(Console.ReadLine()!);
    if (n == 0)
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine().Trim();
        students.Add(name);
    }
    else if (n == 1)
    {
        Console.Write("Enter index to erase: ");
        int ind = int.Parse(Console.ReadLine()!);
        students.RemoveAt(ind);
        Console.WriteLine("removed!!");
    }
    else if (n == 2)
    {
        printList();
    }
    else if (n == 3)
    {
        foreach (string student in students)
        {
            Console.WriteLine(student.ToUpper());
        }
    }
    else
    {
        break;
    }

}