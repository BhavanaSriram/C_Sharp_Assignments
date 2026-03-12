using System;

class Student
{
    int id;
    string name;

    public Student()
    {
        id = 1;
        name = "Sita";
    }

    public Student(int i, string n)
    {
        id = i;
        name = n;
    }

    public void Display()
    {
        Console.WriteLine(id + " " + name);
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();
        Student s2 = new Student(101, "Ram");

        s1.Display();
        s2.Display();
    }
}