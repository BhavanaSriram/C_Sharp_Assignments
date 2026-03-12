using System;

abstract class Course
{
    public string CourseName;
    public int Capacity;
    public int EnrolledStudents;

    public Course(string name, int capacity)
    {
        CourseName = name;
        Capacity = capacity;
        EnrolledStudents = 0;
    }

    public abstract void EnrollStudent(string studentName);

    public void DisplayDetails()
    {
        Console.WriteLine("Course: " + CourseName);
        Console.WriteLine("Capacity: " + Capacity);
        Console.WriteLine("Enrolled Students: " + EnrolledStudents);
        Console.WriteLine();
    }
}