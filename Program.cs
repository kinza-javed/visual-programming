using System;

// Enum for Department
public enum Department
{
    ComputerScience,
    Business,
    Engineering,
    Arts,
    Medical
}

// Base class: Person
public class Person
{
    // Nullable Property for Name
    public string? Name { get; set; }

    // No-argument constructor (default value)
    public Person()
    {
        Name = null; // Nullable, so null is allowed
    }

    // Multi-argument constructor
    public Person(string name)
    {
        Name = name;
    }
}

// Derived class: Student
public class Student : Person
{
    
    public string? RegNo { get; set; }
    public int Age { get; set; }
    public Department Program { get; set; }

    // No-argument constructor
    public Student() : base()
    {
        RegNo = null; // Nullable, so null is allowed
        Age = 0;
        Program = Department.ComputerScience;
    }

    // Multi-argument constructor
    public Student(string name, string regNo, int age, Department program)
        : base(name)
    {
        RegNo = regNo;
        Age = age;
        Program = program;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using no-argument constructor
        Student student1 = new Student("kinza", "561", 20, Department.ComputerScience);

        // Using multi-argument constructor
        Student student2 = new Student("maryum", "551", 20, Department.ComputerScience);

       
        Console.WriteLine("Student 1: Name = " + student1.Name + ", RegNo = " + student1.RegNo);
        Console.WriteLine("Student 2: Name = " + student2.Name + ", RegNo = " + student2.RegNo + ", Age = " + student2.Age + ", Program = " + student2.Program);
    }
}
