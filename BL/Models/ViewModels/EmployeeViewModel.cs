using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Models.ViewModels
{
    public class EmployeeViewModel
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
    }
}
