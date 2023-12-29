namespace DAl;
using Bol;

public class DBmanager

{
public static List<Employee> getallemp()
{
List<Employee> ob=new List<Employee> ();
ob.Add(new Employee{Id=10,Name="Vikram"});
ob.Add(new Employee{Id=69,Name="Aditya"});
return ob;


}
}
