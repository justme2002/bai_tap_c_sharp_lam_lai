using bai1.IService;
using bai1.model;

namespace bai1.ui;

public class UIService : IUIService
{
  public EmployeeService? EmployeeService;
  public Employee? Employee;
  public UIModel? UIModel;

  enum EPosition {
    ENGINEER = 1,
    STAFF = 2,
    WORKER = 3
  };

  public UIService()
  {
    this.EmployeeService = new EmployeeService();
    this.Employee = new Employee();
    this.UIModel = new UIModel();
  }

  public void renderUI()
  {
    System.Console.WriteLine("EMPLOYEE MANAGEMENT CONSOLE APP");
    System.Console.WriteLine("1: ADD NEW EMPLOYEE");
    System.Console.WriteLine("2: SEARCH EMPLOYEE");
    System.Console.WriteLine("3: DISPLAY EMPLOYEE");
    System.Console.WriteLine("4: EXIT");    
  }

  public void Running()
  {
    while (true)
    {
      this.renderUI();
      int choice = Int32.Parse(Console.ReadLine()!);
        switch(choice)
        {
          case 1:
            this.AddEmployeeUI();
          break;

          case 2:
            this.SearchEmployeeUI();
          break;

          case 3:
            this.DisplayEmployeeUI();
          break;
          case 4:
            Environment.Exit(0);
          break;
        }
      }
    }

  public void AddEmployeeUI()
  {
    var prepareAddEmployeeUI = this.UIModel!.prepareAddEmployeeUI();
    UIModel!.preparePositionChoosenUI();
    int choice = Int32.Parse(Console.ReadLine()!);

    switch (choice)
    {
      case (int) EPosition.ENGINEER:
        String major = this.UIModel!.prepareMajor();

        this.EmployeeService!.addEmployee(
          this.Employee!.prepareInput(
            Id: new Random().Next(100),
            FullName: prepareAddEmployeeUI.FullName!,
            Age: prepareAddEmployeeUI.Age,
            Gender: prepareAddEmployeeUI.Gender,
            MajorOrJob: major  
          )
        );
      break;

      case (int) EPosition.STAFF:
        string job = this.UIModel!.prepareJob();

        this.EmployeeService!.addEmployee(
          this.Employee!.prepareInput(
            Id: new Random().Next(100),
            FullName: prepareAddEmployeeUI.FullName!,
            Age: prepareAddEmployeeUI.Age,
            Gender: prepareAddEmployeeUI.Gender,
            MajorOrJob: job
          )
        );
       break;

      case (int) EPosition.WORKER:
        int level = this.UIModel!.prepareWorkerLevel();

        this.EmployeeService!.addEmployee(
          this.Employee!.prepareInput(
            Id: new Random().Next(100),
            FullName: prepareAddEmployeeUI.FullName!,
            Age: prepareAddEmployeeUI.Age,
            Gender: prepareAddEmployeeUI.Gender,
            Level: level
          )
        ); 
      break;
    }

    this.EmployeeService!.displayEmployees();
  }

  public void DisplayEmployeeUI()
  {
    this.EmployeeService!.displayEmployees();
  }

  public void SearchEmployeeUI()
  {
    string name = Console.ReadLine()!;
    System.Console.WriteLine("Input employee name");
    this.EmployeeService!.searchEmployee(name);
  }
}

  
