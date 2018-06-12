using System;
using System.ComponentModel.DataAnnotations.Schema;
using DatabasesEntities.Models.Abstracts;

namespace DatabasesEntities.Models
{
    public class Employee : DatabaseEntity
    {
        public Employee() : base() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public bool? IsPotentialBuyer { get; set; }
    }
}
