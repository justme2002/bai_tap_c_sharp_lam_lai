namespace bai1.model;

public class Staff : Employee
{
  public string? Job { get; set; }
  public Staff() : base()
  {

  }
  public Staff(int Id, string FullName, int Age, int Gender, string Job) : base(Id, FullName, Age, Gender)
  {
    this.Job = Job;
  }

  public override void displayEmployee()
  {
    base.displayEmployee();
    System.Console.WriteLine($"Id: {this.Id}");
    System.Console.WriteLine($"Full Name: {this.FullName}");
    System.Console.WriteLine($"Age: {this.Age}");
    System.Console.WriteLine($"Gender: {(this.Gender == 0 ? "Male" : "Female")}");
    System.Console.WriteLine($"Job: {this.Job}");
  }
}
