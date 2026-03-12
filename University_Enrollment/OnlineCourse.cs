using System;

class OnlineCourse : Course
{
    public OnlineCourse(string name, int capacity) : base(name, capacity) { }

    public override void EnrollStudent(string studentName)
    {
        if (EnrolledStudents < Capacity)
        {
            EnrolledStudents++;
            Console.WriteLine(studentName + " enrolled in Online Course: " + CourseName);
        }
        else
        {
            Console.WriteLine("Online course is full.");
        }
    }
}