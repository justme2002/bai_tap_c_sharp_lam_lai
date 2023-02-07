using bai1.model;

namespace bai1.IService;

public interface IEmployee
{
  public void addEmployee(Employee employee);
  public void searchEmployee(string name);
  public void displayEmployees();
}