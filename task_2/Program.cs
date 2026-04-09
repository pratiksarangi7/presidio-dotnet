
namespace task_2;


public class Person
{
    private readonly string name;
    private readonly int age;
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void Greeting()
    {
        Console.WriteLine($"Hello! I am {name}. I am {age} years old");
    }
    static void Main(string[] args)
    {
        Person p1 = new("Pratik", 22);
        Person p2 = new("Sagnik", 30);
        Person p3 = new("Bhavya", 40);
        Person p4 = new("Mayur", 102);
        p1.Greeting();
        p2.Greeting();
        p3.Greeting();
        p4.Greeting();
    }
}

