using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace Wynright.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }

        [DisplayName("Employment Date")]
        public DateTime EmploymentDate { get; set; }
        public int  DepartmentID { get; set; }
        public virtual Department Department { get; set; }

    }
}