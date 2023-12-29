using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HRPortal.Models;
using Bll;
using Bol;
//using System.Collections.Generic;

namespace HRPortal.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

      public IActionResult getEmployee()
    {
       CatalogManager obg=new CatalogManager();
       List<Employee> data= new List<Employee>();
       data=obg.getdata();
    
      ViewData["key"]=data;


// List<Employee> employees=HRDBManager.GetAllEmployees();
// ViewData["employees"]=employees;
// return View();

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
