namespace bai1.model;

public class UIModel
{
  public string? Name { get; set; }
  public int Age { get; set; }
  public string? Gender { get; set; }
  public string? Major { get; set; }
  public string? Job { get; set; }
  public int Level { get; set; }

  public UIModel()
  {
    
  }

  public Employee prepareAddEmployeeUI()
  {
    int Id = new Random().Next(100);
    System.Console.WriteLine("name: ");
    this.Name = Console.ReadLine();
    System.Console.WriteLine("age: ");
    this.Age = Int32.Parse(Console.ReadLine()!);
    System.Console.WriteLine("gender: ");
    this.Gender = Console.ReadLine()!;

    return new Employee(Id, Name, Age, Gender == "male" ? 0 : 1);
  }


  public int prepareWorkerLevel()
  {
    System.Console.WriteLine("Level: ");
    this.Level = Int32.Parse(Console.ReadLine()!);
    return this.Level;
  }

  public string prepareMajor()
  {
    System.Console.WriteLine("Major: ");
    Major = Console.ReadLine();
    return Major!;
  }

  public string prepareJob()
  {
    System.Console.WriteLine("Job: ");
    Job = Console.ReadLine();
    return Job!;
  }

  public void preparePositionChoosenUI()
  {
    System.Console.WriteLine("1: Engineer");
    System.Console.WriteLine("2: Staff");
    System.Console.WriteLine("3: Worker");
  }
}