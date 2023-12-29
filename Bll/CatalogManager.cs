namespace Bll;
using DAl;
using Bol;

public class CatalogManager
{
    public List<Employee> getdata()
    {
     List<Employee> list=new List<Employee>();
    list=DBmanager.getallemp();
    return list;
    }
    

}
