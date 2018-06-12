using DatabasesEntities.Models.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabasesEntities.Models
{
    public class Company : DatabaseEntity
    {
        public Company() : base() { }

        public string Name { get; set; }
        public string VatId { get; set; }

        [InverseProperty("Company")]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
