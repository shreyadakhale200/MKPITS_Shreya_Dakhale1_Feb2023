using API_Webapplication_Creation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_Webapplication_Creation.Models;

namespace API_Webapplication_Creation.Controllers
{
    public class EmployeeController : ApiController
    {
        //Creating an array of objects in employee class
        Employee[] employees = new Employee[]
        {
            new Employee{Id=1,Name="Mahima",JoiningDate = DateTime.Parse(DateTime.Today.ToString())}
        }
    }
}
