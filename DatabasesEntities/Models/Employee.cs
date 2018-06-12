using System;
using DatabasesEntities.Models.Abstracts;

namespace DatabasesEntities.Models
{
    public class Employee : DatabaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
