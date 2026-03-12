using System;

namespace StudentReport
{
    class Student
    {
        string studentName;
        string rollNumber;
        int[] marks = new int[5];

        public Student(string name, string roll, int[] m)
        {
            studentName = name;
            rollNumber = roll;
            for (int i = 0; i < 5; i++)
            {
                marks[i] = m[i];
            }
        }

        public double calculateAverage()
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += marks[i];
            }
            return sum / 5.0;
        }

        public string calculateGrade()
        {
            double avg = calculateAverage();

            if (avg >= 90 && avg <= 100)
                return "A+";
            else if (avg >= 80)
                return "A";
            else if (avg >= 70)
                return "B";
            else if (avg >= 60)
                return "C";
            else if (avg >= 50)
                return "D";
            else
                return "Fail";
        }

        public void printReport()
        {
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Roll Number: " + rollNumber);

            Console.WriteLine("Marks:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Subject " + (i + 1) + ": " + marks[i]);
            }

            Console.WriteLine("Average: " + calculateAverage());
            Console.WriteLine("Grade: " + calculateGrade());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Roll Number: ");
            string roll = Console.ReadLine();

            Console.WriteLine("Enter marks for 5 subjects:");
            for (int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            Student s = new Student(name, roll, marks);
            s.printReport();
        }
    }
}