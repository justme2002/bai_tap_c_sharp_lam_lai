using bai1.model;
using bai1.IService;

public class EmployeeService : IEmployee
{
  public List<Employee>? Employees { get; set; }

  public EmployeeService()
  {
    this.Employees = new List<Employee>()
    {
      new Engineer
      {
        Id = 1,
        FullName = "Hoang Le Huy",
        Age = 20,
        Gender = 0,
        Major = "SE Intern"
      },
      new Staff
      {
        Id = 2,
        FullName = "Nguyen Van A",
        Age = 30,
        Gender = 0,
        Job = "Accountant"
      },
      new Worker 
      {
        Id = 3,
        FullName = "Jong Le",
        Age = 40,
        Gender = 1,
        Level = 5 
      }
    };
  }

  public EmployeeService(List<Employee> Employees)
  {
    this.Employees = Employees;
  }

  public void addEmployee(Employee employee)
  {
    this.Employees!.Add(employee);
  }

  public void displayEmployees()
  {
    foreach (var employee in this.Employees!)
    {
      employee.displayEmployee();
    } 
  }

  public void searchEmployee(string name)
  {
    System.Console.WriteLine("Employee_data");
    var result = from s in this.Employees where s.FullName == name select s;
    foreach (var employee in result)
    {
      employee.displayEmployee();
    }
  }
}
