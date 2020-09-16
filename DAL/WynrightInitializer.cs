using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Wynright.Models;

namespace Wynright.DAL
{
    public class WynrightInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<WynrightContext>
    {
        protected override void Seed(WynrightContext context)
        {
            var departments = new List<Department>
            {
                new Department{ ID = 1, Name = "Human Resource"},
                new Department{ ID = 2, Name = "Information Technology"},
            };
            departments.ForEach(s => context.Departments.Add(s));
            context.SaveChanges();

            var employees = new List<Employee>
            {
                new Employee{ FirstName="Gytis", LastName="Li", Location="Tampa", EmploymentDate=DateTime.Parse("2002-09-01"),  DepartmentID = 1 },
                new Employee{ FirstName="Pat", LastName="Joy", Location="Clearwater", EmploymentDate=DateTime.Parse("2002-10-21"), DepartmentID = 2 },
            };
            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
        }
    }
}