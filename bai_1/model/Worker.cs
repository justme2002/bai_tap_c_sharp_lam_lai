namespace bai1.model;

public class Worker : Employee
{
  public int Level { get; set; }
  public Worker() : base()
  {

  }
  public Worker(int Id, string FullName, int Age, int Gender, int Level) : base(Id, FullName, Age, Gender)
  {
    this.Level = Level;
  }

  public override void displayEmployee()
  {
    base.displayEmployee();
    System.Console.WriteLine($"Id: {this.Id}");
    System.Console.WriteLine($"Full Name: {this.FullName}");
    System.Console.WriteLine($"Age: {this.Age}");
    System.Console.WriteLine($"Gender: {(this.Gender == 0 ? "Male" : "Female")}");
    System.Console.WriteLine($"Level: {this.Level}");
  }
}
