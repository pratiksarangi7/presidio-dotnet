public class Student
{
    public readonly string name;
    public readonly int age;
    public readonly double grade;
    public Student(string name, int age, double grade)
    {
        this.name = name;
        this.age = age;
        this.grade = grade;
    }

    static void Main(string[] args)
    {
        Student s1 = new("Pratik", 22, 9.3);
        Student s2 = new("Raj", 19, 8.5);
        Student s3 = new("Virat", 18, 7.3);
        Student s4 = new("Rohit", 25, 8.8);
        Student s5 = new("Modi", 24, 3.3);
        List<Student> list = new() { s1, s2, s3, s4, s5 };
        var gradeTh = list.Where(s => s.grade >= 7.5);
        var sorted = gradeTh.OrderBy(s => s.age);
        foreach (var student in sorted)
        {
            Console.WriteLine($"{student.name}, {student.age}, {student.grade}");
        }
    }
}