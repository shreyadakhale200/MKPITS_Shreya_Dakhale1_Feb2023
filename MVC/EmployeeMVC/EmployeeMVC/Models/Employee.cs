using EmployeeMVC.Models;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Xml.Linq;

namespace EmployeeMVC.Models
{
    public class Employee
    {
        public int EmployeeId;
        string EmployeeName;
        int age;
        double salary;
        string designation;

        public Employee(string ename,int eid,int eage, double esal, string edesig) 
        { 
            EmployeeId = eid;
            EmployeeName = ename;
            age = eage;
            salary = esal;
            designation = edesig;
        }

        public int ID {get { return EmployeeId; }}
        public string Name { get { return EmployeeName; }}
        public int Age { get { return age; }}
        public double Salary { get {  return salary; }}
        public string Designation { get {  return designation; }}
              
       
    }
}
