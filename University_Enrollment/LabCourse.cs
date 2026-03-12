using System;

class LabCourse : Course
{
    public LabCourse(string name, int capacity) : base(name, capacity) { }

    public override void EnrollStudent(string studentName)
    {
        if (EnrolledStudents < Capacity)
        {
            EnrolledStudents++;
            Console.WriteLine(studentName + " enrolled in Lab Course: " + CourseName);
        }
        else
        {
            Console.WriteLine("Lab seats are full.");
        }
    }
}