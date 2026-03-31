using System;

class Employee
{
    public int Id;
    public string Name;
    public double Basic;

    public Employee(int id, string name, double basic)
    {
        Id = id;
        Name = name;
        Basic = basic;
    }

    public virtual double CalculateSalary()
    {
        return Basic;
    }

    public void Display()
    {
        double monthly = CalculateSalary();
        double annual = monthly * 12;
        Console.WriteLine(Id + " " + Name + " " + monthly + " " + annual);
    }
}

class Manager : Employee
{
    public Manager(int id, string name, double basic) : base(id, name, basic) { }

    public override double CalculateSalary()
    {
        return Basic + (0.5 * Basic) + (0.4 * Basic);
    }
}

class Developer : Employee
{
    public Developer(int id, string name, double basic) : base(id, name, basic) { }

    public override double CalculateSalary()
    {
        return Basic + (0.4 * Basic);
    }
}

class Tester : Employee
{
    public Tester(int id, string name, double basic) : base(id, name, basic) { }

    public override double CalculateSalary()
    {
        return Basic + (0.3 * Basic);
    }
}

class Program
{
    static void Main()
    {
        Employee e1 = new Manager(1, "A", 10000);
        Employee e2 = new Developer(2, "B", 8000);
        Employee e3 = new Tester(3, "C", 6000);

        e1.Display();
        e2.Display();
        e3.Display();
    }
}