using System;
using System.ComponentModel.DataAnnotations;
using DatabasesEntities.Models.Enumerations;

namespace DatabasesEntities.Models.Abstracts
{
    public abstract class DatabaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public DatabaseEntityStatusEnum Status { get; set; }
    }
}
