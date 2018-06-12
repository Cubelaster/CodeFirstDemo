using System;
using System.Collections.Generic;

namespace FromDatabase.Models
{
    public partial class Employees
    {
        public int Id { get; set; }
        public int? ModifiedByEmployeeId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int Status { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int CompanyId { get; set; }
        public int CreatedByEmployeeId { get; set; }
        public bool? IsPotentialBuyer { get; set; }

        public Companies Company { get; set; }
    }
}
