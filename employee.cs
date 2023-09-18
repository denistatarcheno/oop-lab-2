using System;

public class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void CalculateSalary(string position, int experience)
    {
        double baseSalary = 0.0;
        double tax = 0.0;
        switch (position.ToLower())
        {
            case "manager":
                baseSalary = 30000.0 + (experience * 1000);
                break;
            case "designer":
                baseSalary = 40000.0 + (experience * 1200);
                break;
            case "developer":
                baseSalary = 50000.0 + (experience * 1500);
                break;
            default:
                Console.WriteLine("Непідтримувана посада");
                return;
        }
        tax = baseSalary * 0.15;
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Оклад: {baseSalary} грн");
        Console.WriteLine($"Податковий збір: {tax} грн");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("Іванов", "Петро");
        string position = "developer";
        int experience = 5;
        employee.CalculateSalary(position, experience);
    }
}
