using Internal;
abstract class Employee
{
    public string Name;
    public abstract decimal CalculatePay();
}

abstract class SalaryEmployee : Employee
{

    protected decimal annualSalary;

    public SalaryEmployee(string name, float annualSalary) : base(name)
    {
        this.annualSalary = (decimal) annualSalary;
    }
    public abstract decimal CalculatePay();
    {
        return annualSalary / 26; // bi-weekly pay
    }
}
abstract class HourlyEmployee : Employee
{

    protected decimal hourlyRate;
    protected decimal hoursWorked;

    public SalaryEmployee(string name, double hoursWorked) : base(name)
    {
        this.hourlyRate = (decimal) hourlyRate;
        this.hoursWorked = hoursWorked;
    }
    public abstract decimal CalculatePay();
    {
        return (hourlyRate * hoursWorked) * 2 //bi-weekly pay
    }
}
SalaryEmployee salaryEmployee = new SalaryEmployee("John", 96000.13);
HourlyEmployee hourlyEmployee = new HourlyEmployee("Jane", 13.50, 40);

Console.WriteLine($"{salaryEmployee.name} makes ${salaryEmployee.CalculatePay():N} bi-weekly.");
Console.WriteLine($"{hourlyEmployee.name} makes ${hourlyEmployee.CalculatePay():N} bi-weekly.");
