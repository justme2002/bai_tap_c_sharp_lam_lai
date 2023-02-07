namespace bai1.model;

public class Engineer : Employee
{
  public string? Major { get; set; }

  public Engineer() : base()
  {

  }
  public Engineer(int Id, string FullName, int Age, int Gender, string Major) : base(Id, FullName, Age, Gender)
  {
    this.Major = Major;
  }

  public override void displayEmployee()
  {
    base.displayEmployee();
    System.Console.WriteLine($"Id: {this.Id}");
    System.Console.WriteLine($"Full Name: {this.FullName}");
    System.Console.WriteLine($"Age: {this.Age}");
    System.Console.WriteLine($"Gender: {(this.Gender == 0 ? "Male" : "Female")}");
    System.Console.WriteLine($"Major: {this.Major}");
  }
}
