using System;

class InPersonCourse : Course
{
    public InPersonCourse(string name, int capacity) : base(name, capacity) { }

    public override void EnrollStudent(string studentName)
    {
        if (EnrolledStudents < Capacity)
        {
            EnrolledStudents++;
            Console.WriteLine(studentName + " enrolled in In-Person Course: " + CourseName);
        }
        else
        {
            Console.WriteLine("Classroom is full.");
        }
    }
}