using System;

class Program
{
    static void Main()
    {
        OnlineCourse oc = new OnlineCourse("dot net", 2);
        InPersonCourse ic = new InPersonCourse("java fullstack", 2);
        LabCourse lc = new LabCourse("Physics Lab", 1);

        oc.EnrollStudent("Bhavana");
        oc.EnrollStudent("jack");
        oc.EnrollStudent("jill");

        ic.EnrollStudent("David");
        ic.EnrollStudent("sita");

        lc.EnrollStudent("raj");
        lc.EnrollStudent("ravi");

        Console.WriteLine();

        oc.DisplayDetails();
        ic.DisplayDetails();
        lc.DisplayDetails();
    }
}