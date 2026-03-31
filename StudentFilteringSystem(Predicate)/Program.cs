using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student("Amit", 75, 17),
            new Student("Ravi", 55, 19),
            new Student("Anita", 82, 16),
            new Student("John", 45, 18),
            new Student("Arun", 65, 17),
            new Student("Kiran", 90, 20)
        };

        Predicate<Student> marksAbove60 = s => s.Marks > 60;
        Predicate<Student> ageBelow18 = s => s.Age < 18;
        Predicate<Student> nameStartsWithA = s => s.Name.StartsWith("A");

        var res1 = students.FindAll(marksAbove60);
        var res2 = students.FindAll(ageBelow18);
        var res3 = students.FindAll(nameStartsWithA);

        Console.WriteLine("Marks > 60");
        res1.ForEach(s => Console.WriteLine(s.Name));

        Console.WriteLine("Age < 18");
        res2.ForEach(s => Console.WriteLine(s.Name));

        Console.WriteLine("Name starts with A");
        res3.ForEach(s => Console.WriteLine(s.Name));

        bool exists = students.Exists(marksAbove60);
        Console.WriteLine("Any student with marks > 60: " + exists);
    }
}