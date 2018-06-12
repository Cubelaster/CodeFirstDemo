using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DatabasesEntities.Models.Enumerations;

namespace DatabasesEntities.Models.Abstracts
{
    public abstract class DatabaseEntity
    {
        public DatabaseEntity()
        {
            DateCreated = DateTime.Now;
            Status = DatabaseEntityStatusEnum.Active;
        }

        public int Id { get; set; }
        public int CreatedByEmployeeId { get; set; }
        //public virtual Employee CreatedByEmployee { get; set; }
        public DateTime DateCreated { get; set; }
        public int? ModifiedByEmployeeId { get; set; }
        //public virtual Employee ModifiedByEmployee { get; set; }
        public DateTime? DateModified { get; set; }
        public DatabaseEntityStatusEnum Status { get; set; }
    }
}
