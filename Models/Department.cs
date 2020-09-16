using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Wynright.Models
{
    public class Department
    {
        public int ID { get; set; }

        [DisplayName("Department")]
        public string Name { get; set; }
    }
}