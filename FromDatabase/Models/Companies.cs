using System;
using System.Collections.Generic;

namespace FromDatabase.Models
{
    public partial class Companies
    {
        public Companies()
        {
            Employees = new HashSet<Employees>();
        }

        public int Id { get; set; }
        public int? ModifiedByEmployeeId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int Status { get; set; }
        public string Name { get; set; }
        public string VatId { get; set; }
        public int CreatedByEmployeeId { get; set; }

        public ICollection<Employees> Employees { get; set; }
    }
}
