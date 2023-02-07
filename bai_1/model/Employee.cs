namespace bai1.model;

public class Employee
{
  public int Id { get; set; }
  public string? FullName { get; set; }
  public int Age { get; set; }
  public int Gender { get; set; }

  public Employee()
  {

  }

  public Employee(int Id, string? FullName, int Age, int Gender)
  {
    this.Id = Id;
    this.FullName = FullName;
    this.Age = Age;
    this.Gender = Gender;
  }
  
  public virtual Employee prepareInput(int Id, string FullName, int Age, int Gender, int Level)
  {
    return new Worker(Id, FullName, Age, Gender, Level);
  }
  public virtual Employee prepareInput(int Id, string FullName, int Age, int Gender, string MajorOrJob)
  {
    return new Engineer(Id, FullName, Age, Gender, MajorOrJob);
  }
  public virtual void displayEmployee()
  {

  }
}
