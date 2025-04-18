/*
   Task 5: Employee Management System

Create an Interface IEmployee:

Methods: void Work(), void TakeBreak()
Create an Interface IReportable:

Method: void GenerateReport()
Create an Abstract Class Employee:

Implements IEmployee.
Properties: string Name, string Position
Abstract methods: Work(), TakeBreak()
Concrete method: GetEmployeeDetails()
Create Derived Classes:

Manager (Implements Work(), TakeBreak(), and IReportable)
Developer (Implements Work(), TakeBreak(), and IReportable)
Main Method:

Create instances of Manager and Developer.
Use polymorphism to call methods on IEmployee objects.

 */


using System;

// Interface for Employee actions
interface IEmployee
{
    void Work();
    void TakeBreak();
}

// Interface for reportable employees
interface IReportable
{
    void GenerateReport();
}

// Abstract class for Employee
abstract class Employee : IEmployee
{
    public string Name { get; set; }
    public string Position { get; set; }

    public Employee(string name, string position)
    {
        Name = name;
        Position = position;
    }

    public abstract void Work();
    public abstract void TakeBreak();

    public void GetEmployeeDetails()
    {
        Console.WriteLine($"Employee: {Name}, Position: {Position}");
    }
}

// Derived class for Manager
class Manager : Employee, IReportable
{
    public Manager(string name) : base(name, "Manager") { }

    public override void Work()
    {
        Console.WriteLine($"{Name} is managing the team.");
    }

    public override void TakeBreak()
    {
        Console.WriteLine($"{Name} is taking a break.");
    }

    public void GenerateReport()
    {
        Console.WriteLine($"{Name} is generating a management report.");
    }
}

// Derived class for Developer
class Developer : Employee, IReportable
{
    public Developer(string name) : base(name, "Developer") { }

    public override void Work()
    {
        Console.WriteLine($"{Name} is coding.");
    }

    public override void TakeBreak()
    {
        Console.WriteLine($"{Name} is taking a break.");
    }

    public void GenerateReport()
    {
        Console.WriteLine($"{Name} is generating a development report.");
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Manager and Developer
        Manager manager = new Manager("Alice");
        Developer developer = new Developer("Bob");

        // Using IEmployee methods
        manager.GetEmployeeDetails();
        manager.Work();
        manager.GenerateReport();
        manager.TakeBreak();

        Console.WriteLine(); // Line break for clarity

        developer.GetEmployeeDetails();
        developer.Work();
        developer.GenerateReport();
        developer.TakeBreak();
    }
}
